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
            classSelBox.Items.AddRange(GlobalConfig.schoolClasses.Keys.ToArray());
            classSelBox.SelectedIndex = 0;
            UpdateStudentList();
        }

        private void classSelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStudentList();
        }

        private void UpdateStudentList()
        {
            var selectedClass = classSelBox.SelectedItem as string;
            var students = GlobalConfig.schoolClasses[selectedClass];

            studentSelBox.Items.Clear();
            studentSelBox.Items.Add("");
            studentSelBox.Items.AddRange(students.Select(s => $"{s.name} {s.surname}").ToArray());
            studentSelBox.SelectedIndex = 0;
        }

        private void addScoresButton_Click(object sender, EventArgs e)
        {
            if (studentSelBox.SelectedIndex < 1)
            {
                MessageBox.Show("Seleziona uno studente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedStudentName = studentSelBox.SelectedItem.ToString();
            var selectedClass = classSelBox.SelectedItem as string;
            var selectedStudent = GlobalConfig.schoolClasses[selectedClass].FirstOrDefault(s => $"{s.name} {s.surname}" == selectedStudentName);

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
            classSelBox.SelectedIndex = 0;
            studentSelBox.SelectedIndex = 0;
            foreach (var txtbox in subjectGradeBoxes)
                txtbox.Clear();
        }
    }
}