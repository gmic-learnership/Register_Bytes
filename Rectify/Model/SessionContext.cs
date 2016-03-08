using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectify.Data;
using Rectify.ModelData;

namespace Rectify.Model
{
    public enum Role { Person, Student, Administrator };
    public static class SessionContext
    {
        public static int UserID;
        public static string UserName;
        public static Role UserRole;
        //public static Student CurrentStudent;
        public static Person CurrentMentor;
    }
}
