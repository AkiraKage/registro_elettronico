using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_elettronico
{
    public static class GlobalConfig
    {
        public static bool logged = false;
        public static bool privilege = false;
        public static bool fullPrivilege = false;
        public static string userRecords { get; private set; }
        public static string teacherRecords { get; private set; }

        public static Student loggedUser;

        public static List<Student> allStudents;
        public static Dictionary<string, List<Student>> schoolClasses = new Dictionary<string, List<Student>>();

        static GlobalConfig()
        {
            userRecords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "students.json");
            teacherRecords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "teachers.json");

            if (!File.Exists(userRecords))
            {
                MessageBox.Show("Il file students.json non è stato trovato. Assicurati che il file esista nella directory corretta.", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string json = File.ReadAllText(userRecords);
            allStudents = JsonConvert.DeserializeObject<List<Student>>(json);
        }
    }
}
