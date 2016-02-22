using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectify.Data;

namespace Rectify.Data.ViewModel
{
    class SignModel
    {
        public string SignRegister(AttendanceDetail1 detail)
        {
            try
            {
                RegisterDBEntities registerContext = new RegisterDBEntities();               
                    registerContext.AttendanceDetail1.Add(detail);
                    registerContext.SaveChanges();
                    return "You signed";                
            }
            catch (Exception ex)
            {
                return "Register was not signed, Please try again" + ex.Message ;
            }
        }
        public string DeleteLearner(int id)
        {
            try
            {
                RegisterDBEntities registerContext = new RegisterDBEntities();
                Student student = registerContext.Students.Find(id);
                registerContext.Students.Attach(student);
                registerContext.Students.Remove(student);
                registerContext.SaveChanges();
                return student.FirstName + "was successfully Deleted";
            }
            catch (Exception )
            {
                return "Learner not deleted" ; 
            }
        }
        public string InsertLearner(Student student)
        {
            try
            {
                RegisterDBEntities registerContext = new RegisterDBEntities();
                registerContext.Students.Add(student);
                registerContext.SaveChanges();
                return student.FirstName + "was successfully added";
            }
            catch (Exception ex)
            {
                return "Learner not Added" + ex.Message;
            }
        }
    }
}
