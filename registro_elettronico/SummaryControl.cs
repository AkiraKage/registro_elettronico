using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_elettronico
{
    public partial class SummaryControl : UserControl
    {
        TableLayoutPanel[] gradeTables;
        public SummaryControl()
        {
            InitializeComponent();
        }

        private void SummaryControl_Load(object sender, EventArgs e)
        {
            Student currStudent;
            Dictionary<string, List<Student>> allStudents;

            if (GlobalConfig.privilege)
            {
                allStudents = GlobalConfig.schoolClasses;
                Console.WriteLine(allStudents);
                classSelectBox.Items.AddRange(allStudents.Keys.ToArray());
                classSelectBox.SelectedIndex = 0;
                var selectedClass = classSelectBox.SelectedItem as string;
                List<string> studentNames = new List<string>();
                foreach (Student student in allStudents[selectedClass])
                {
                    studentNames.Add(student.name + " " + student.surname);
                }
                studentSelectBox.Items.AddRange(studentNames.ToArray());
                studentSelectBox.SelectedIndex = 0;
            } 
            else
            {
                currStudent = GlobalConfig.loggedUser;

                classSelectBox.Items.Add(currStudent.year_section);
                classSelectBox.SelectedIndex = 0;

                studentSelectBox.Items.Add(currStudent.name + " " + currStudent.surname);
                studentSelectBox.SelectedIndex = 0;

                BirthDataBox.Text = currStudent.birthplace + " " + currStudent.birthdate.ToString("dd/MM/yyyy");
            }
        }
    }
}
