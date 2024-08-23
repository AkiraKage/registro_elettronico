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
    public partial class DelStudentControl : UserControl
    {
        private Dictionary<string, List<Student>> allStudents;
        private Dictionary<string, string[]> studentNamesByClass;

        public DelStudentControl()
        {
            InitializeComponent();
        }

        private void DelStudentControl_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            classSelectBox.Items.Clear();
            allStudents = GlobalConfig.schoolClasses;
            studentNamesByClass = new Dictionary<string, string[]>();

            var classes = allStudents.Keys.ToArray();
            classSelectBox.Items.Add("");
            classSelectBox.Items.AddRange(classes);

            if (classes.Length > 0)
            {
                classSelectBox.SelectedIndex = 0;
                UpdateStudentList();
            }
            else
            {
                classSelectBox.SelectedIndex = -1;
                studentSelectBox.Items.Clear();
                studentSelectBox.SelectedIndex = -1;
            }
        }

        private void classSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStudentList();
        }

        private void UpdateStudentList()
        {
            var selectedClass = classSelectBox.SelectedItem as string;
            studentSelectBox.Items.Clear();

            if (!string.IsNullOrEmpty(selectedClass) && allStudents.ContainsKey(selectedClass))
            {
                var students = allStudents[selectedClass];
                var studentNames = students.Select(s => $"{s.name} {s.surname}").ToArray();
                studentNamesByClass[selectedClass] = studentNames;

                studentSelectBox.Items.Add("");
                studentSelectBox.Items.AddRange(studentNames);
                studentSelectBox.SelectedIndex = 0;
            }
            else
            {
                studentSelectBox.SelectedIndex = -1;
            }
        }

        private void delStudentBtn_Click(object sender, EventArgs e)
        {
            if (classSelectBox.SelectedIndex < 1)
            {
                MessageBox.Show("Seleziona una classe valida", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (studentSelectBox.SelectedIndex < 1)
            {
                MessageBox.Show("Seleziona uno studente valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedStudentName = studentSelectBox.SelectedItem.ToString();
            var selectedClass = classSelectBox.SelectedItem as string;

            if (allStudents.ContainsKey(selectedClass))
            {
                var studentsInClass = allStudents[selectedClass];
                Student studentToRemove = null;

                foreach (var student in studentsInClass)
                {
                    if ($"{student.name} {student.surname}" == selectedStudentName)
                    {
                        studentToRemove = student;
                        break;
                    }
                }

                if (studentToRemove != null)
                {
                    studentsInClass.Remove(studentToRemove);
                    GlobalConfig.allStudents.Remove(studentToRemove);
                    GlobalConfig.UpdateStudentJson();
                    LoadClasses();
                    studentSelectBox.Text = "";
                    MessageBox.Show("Studente rimosso con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Studente non trovato nella classe selezionata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Classe non valida", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}