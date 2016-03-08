using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectify.Data;
using Rectify.ModelData;

namespace Rectify.Data.ViewModel
{
    class SignModel
    {
        DigitalEntities digitalContext = null;
        public string SignRegister(AttendanceDetail detail)
        {
            try
            {
                digitalContext = new DigitalEntities();
                digitalContext.AttendanceDetails.Add(detail);
                digitalContext.SaveChanges();
                    return "You signed";                
            }
            catch (Exception )
            {
                return null;
            }
        }
        public string MasterRecord(AttendanceMaster master)
        {
            try
            {
                digitalContext = new DigitalEntities();
                digitalContext.AttendanceMasters.Add(master);
                digitalContext.SaveChanges();
                 return "You signed";
            }
            catch (Exception ex)
            {
                return "Register was not signed, Please try again" + ex.Message;
            }
        }
        public string DeleteLearner(int id)
        {
            try
            {
                digitalContext = new DigitalEntities();
                Person student = digitalContext.People.Find(id);
                digitalContext.People.Attach(student);
                digitalContext.People.Remove(student);
                digitalContext.SaveChanges();
                return student.FirstName + "was successfully Deleted";
            }
            catch (Exception )
            {
                return "Learner not deleted" ; 
            }
        }
        public string InsertLearner(Person student)
        {
            try
            {
                digitalContext = new DigitalEntities();
                digitalContext.People.Add(student);
                digitalContext.SaveChanges();
                return student.FirstName + "was successfully added";
            }
            catch (Exception ex)
            {
                return "Learner not Added" + ex.Message;
            }
        }
        public string InsertMentor( Person mentor)
        {
            try
            {
                digitalContext = new DigitalEntities();
                digitalContext.People.Add(mentor);
                digitalContext.SaveChanges();
                return mentor.FirstName + " " + " was successfully added";
            }
            catch (Exception ex)
            {

                return "Mentor not added" + ex.Message;
            }
        }

    }
}
