using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;

namespace registro_elettronico
{
    public partial class AddScoresControl : UserControl
    {
        TextBox[] subjectGradeBoxes;
        string[] subjects;

        public AddScoresControl()
        {
            InitializeComponent();
            subjectGradeBoxes = new TextBox[8] { itaBox, storiaBox, mateBox, ingleseBox, infoBox, sistemiBox, tpsitBox, teleBox };
            subjects = new string[8] { "Italiano", "Storia", "Matematica", "Inglese", "Informatica", "Sistemi e Reti", "Tpsit", "Telecomunicazioni" };

            GlobalConfig.StudentsUpdated += UpdateStudentList;
        }

        private void AddScoresControl_Load(object sender, EventArgs e)
        {
            classSelBox.Items.Clear();
            var classes = GlobalConfig.schoolClasses.Keys.ToArray();
            classSelBox.Items.Add("");
            classSelBox.Items.AddRange(classes);

            if (classes.Length > 0)
            {
                classSelBox.SelectedIndex = 0;
                UpdateStudentList();
            }
            else
            {
                classSelBox.SelectedIndex = -1;
                studentSelBox.Items.Clear();
            }
        }

        private void classSelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStudentList();
        }

        private void UpdateStudentList()
        {
            var selectedClass = classSelBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedClass) && GlobalConfig.schoolClasses.ContainsKey(selectedClass))
            {
                var students = GlobalConfig.schoolClasses[selectedClass];

                studentSelBox.Items.Clear();
                studentSelBox.Items.Add("");
                studentSelBox.Items.AddRange(students.Select(s => $"{s.name} {s.surname}").ToArray());
                studentSelBox.SelectedIndex = 0;
            }
            else
            {
                studentSelBox.Items.Clear();
                studentSelBox.SelectedIndex = -1;
            }
        }

        private void addScoresButton_Click(object sender, EventArgs e)
        {
            if (classSelBox.SelectedIndex < 1)
            {
                MessageBox.Show("Seleziona una classe", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (studentSelBox.SelectedIndex < 1)
            {
                MessageBox.Show("Seleziona uno studente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedStudentName = studentSelBox.SelectedItem.ToString();
            var selectedClass = classSelBox.SelectedItem as string;

            Student selectedStudent = null;
            if (GlobalConfig.schoolClasses.ContainsKey(selectedClass))
            {
                var studentsInClass = GlobalConfig.schoolClasses[selectedClass];

                foreach (var student in studentsInClass)
                {
                    if ($"{student.name} {student.surname}" == selectedStudentName)
                    {
                        selectedStudent = student;
                        break;
                    }
                }
            }

            if (selectedStudent == null)
            {
                MessageBox.Show("Studente non trovato nella classe selezionata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool error = false;

            for (int i = 0; i < subjects.Length; i++)
            {
                List<int> numbers = new List<int>();
                string input = subjectGradeBoxes[i].Text;

                if (!string.IsNullOrEmpty(input))
                {
                    string[] values = input.Split(',');

                    foreach (string value in values)
                    {
                        string trimVal = value.Trim();
                        try
                        {
                            int number = Convert.ToInt32(trimVal);
                            if (number > 0 && number <= 10)
                                numbers.Add(number);
                            else throw new Exception("Voto fuori dall'intervallo valido.");
                        }
                        catch
                        {
                            MessageBox.Show("Inserire voti validi compresi tra 1 e 10", "Errore",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            error = true;
                            return;
                        }
                    }
                }

                if (selectedStudent.scores.ContainsKey(subjects[i]))
                {
                    selectedStudent.scores[subjects[i]].AddRange(numbers);
                }
                else
                {
                    selectedStudent.scores[subjects[i]] = numbers;
                }
            }

            if (!error)
            {
                GlobalConfig.UpdateStudentJson();
                ResetFormFields();
            }
        }

        private void ResetFormFields()
        {
            studentSelBox.SelectedIndex = 0;
            foreach (var txtbox in subjectGradeBoxes)
                txtbox.Clear();
        }
    }
}