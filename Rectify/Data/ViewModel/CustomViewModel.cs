using Rectify.Model;
using Rectify.ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectify.Data.ViewModel
{
   public  class CustomViewModel
    {
        DigitalEntities digitalContext = null;
        public dynamic LoadData()
        {
            digitalContext = new DigitalEntities();
            List<Person> person = (from x in digitalContext.People
                                   select x).ToList();
            IList<AttendanceDetail> details = (from x in digitalContext.AttendanceDetails
                                              select x).ToList();
            var query = person.Join(details,
                                c => c.PersonID,
                                ct => ct.PersonID,                                
                                (c, ct) => new CustomModel
                                {
                                    Name = c.FirstName,
                                    Hours = ct.HoursPerDay
                                });
            return query;
        }
        public dynamic GetAttendance(DateTime picker)
        {
            digitalContext = new DigitalEntities();
            var q = from a in digitalContext.AttendanceDetails
                    join b in digitalContext.People  on new { a.PersonID } equals new { b.PersonID }
                    join c in digitalContext.AttendanceMasters on new { a.MasterID } equals new { c.MasterID }
                    where c.AttendanceDate == picker
                    select new
                    {
                       Name = b.FirstName,
                       Hours = a.HoursPerDay
                    };

            return q;
        }
    }
    public class CustomModel
    {
        public decimal Hours { get; set; }
        public string Name { get; set; }
        public string Trained { get; set; }
    }
}
