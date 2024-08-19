using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_elettronico
{
    public static class GlobalConfig
    {
        public static bool logged = false;
        public static bool privilege = false;
        public static string userRecords { get; private set; }
        public static Student loggedUser;

        static GlobalConfig()
        {
            userRecords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "students.json");
        }
    }
}
