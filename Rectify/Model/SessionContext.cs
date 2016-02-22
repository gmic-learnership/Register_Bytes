using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectify.Data;

namespace Rectify.Model
{
    public enum Role { AttendanceMaster, Student, facilitator };

    public static class SessionContext
    {
        public static int UserID;
        public static string UserName;
        public static Role UserRole;
        public static Student CurrentStudent;
        public static AttendanceMaster CurrentTeacher;
    }
}
