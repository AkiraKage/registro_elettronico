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
        Dictionary<string, List<Student>> allStudents;
        string[] studentNames;
        string[] studentBirthData;
        Dictionary<string, List<int>>[] studentGrades;
        public SummaryControl()
        {
            InitializeComponent();
            gradeTables = new TableLayoutPanel[8] { italianoTable, storiaTable, matematicaTable, ingleseTable, informaticaTable, sistemiTable, tpsitTable, telecomunicazioniTable };

            GlobalConfig.StudentsUpdated += classUpdate;
        }

        private void SummaryControl_Load(object sender, EventArgs e)
        {
            allStudents = GlobalConfig.schoolClasses;
            if (GlobalConfig.privilege)
            {
                classSelectBox.Items.AddRange(allStudents.Keys.ToArray());
                classSelectBox.SelectedIndex = 0;

                classUpdate();
            }
            else
            {
                var currStudent = GlobalConfig.loggedUser;
                if (currStudent == null) //controllo per evitare errore stupido di vs
                {
                    MessageBox.Show("Nessun utente loggato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                classSelectBox.Items.Add(currStudent.year_section);
                classSelectBox.SelectedIndex = 0;

                studentSelectBox.Items.Add(currStudent.name + " " + currStudent.surname);
                studentSelectBox.SelectedIndex = 0;

                BirthDataBox.Text = currStudent.birthplace + " " + currStudent.birthdate.ToString("dd/MM/yyyy");

                UpdateGradeTables(currStudent.scores);
            }
        }

        private void studentSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GlobalConfig.privilege)
            {
                BirthDataBox.Text = studentBirthData[studentSelectBox.SelectedIndex];
                UpdateGradeTables(studentGrades[studentSelectBox.SelectedIndex]);
            }
        }

        private void classSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GlobalConfig.privilege)
                classUpdate();
        }

        public void classUpdate()
        {
            var selectedClass = classSelectBox.SelectedItem as string;
            var students = allStudents[selectedClass];

            studentNames = students.Select(st => st.name + " " + st.surname).ToArray();
            studentBirthData = students.Select(st => $"{st.birthplace} {st.birthdate:dd/MM/yyyy}").ToArray();
            studentGrades = students.Select(st => st.scores).ToArray();

            studentSelectBox.DataSource = studentNames;
            studentSelectBox.SelectedIndex = 0;
        }
        private void UpdateGradeTables(Dictionary<string, List<int>> grades)
        {
            foreach (var table in gradeTables)
                table.Controls.Clear();

            string[] subjects = { "Italiano", "Storia", "Matematica", "Inglese", "Informatica", "Sistemi e Reti", "Tpsit", "Telecomunicazioni" };

            for (int i = 0; i < gradeTables.Length; i++)
            {
                var subject = subjects[i];
                if (grades.ContainsKey(subject))
                {
                    foreach (var grade in grades[subject])
                    {
                        Label gradeLabel = new Label
                        {
                            Text = grade.ToString(),
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Fill,
                        };
                        if ((int)grade > 5)
                            gradeLabel.BackColor = Color.GreenYellow;
                        else
                        {
                            if((int)grade < 5)
                                gradeLabel.BackColor = Color.IndianRed;
                            else
                                gradeLabel.BackColor = Color.Yellow;
                        }

                        gradeTables[i].Controls.Add(gradeLabel);
                    }
                }
            }
        }
    }
}
