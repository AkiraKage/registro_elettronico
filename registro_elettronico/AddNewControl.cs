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
    public partial class AddNewControl : UserControl
    {
        string[] schoolClasses;
        TextBox[] subjectGradeBoxes;
        string[] subjects;
        public AddNewControl()
        {
            InitializeComponent();
            subjectGradeBoxes = new TextBox[8] { itaBox, storiaBox, mateBox, ingleseBox, infoBox, sistemiBox, tpsitBox, teleBox };
            subjects = new string[8] { "Italiano", "Storia", "Matematica", "Inglese", "Informatica", "Sistemi e Reti", "Tpsit", "Telecomunicazioni" };
        }
        private void AddNewControl_Load(object sender, EventArgs e)
        {
            schoolClasses = GlobalConfig.schoolClasses.Keys.ToArray();
            classSelBox.Items.Add("");
            classSelBox.Items.AddRange(schoolClasses);

        }

        private void registerNewBox_Click(object sender, EventArgs e)
        {
            bool error = false;
            string targetClass, newname, newsurname, newbirthPlace;
            DateTime newbirthDate;
            Dictionary<string, List<int>> newGrades = new Dictionary<string, List<int>>();

            //assegnazione classe
            if (classSelBox.SelectedIndex > 0)
                targetClass = classSelBox.SelectedItem.ToString();
            else
            {
                if (newClass.Text.Trim().Length > 0)
                    targetClass = newClass.Text;
                else
                {
                    MessageBox.Show("Seleziona una classe o creane una nuova", "Errore",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                    return;
                }
            }

            //assegnazione nome
            if (newNameBox.Text.Trim().Length > 0)
                newname = newNameBox.Text;
            else
            {
                MessageBox.Show("Inserire un nome valido", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }
            if (newSurnameBox.Text.Trim().Length > 0)
                newsurname = newSurnameBox.Text;
            else
            {
                MessageBox.Show("Inserire un cognome valido", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }

            //assegnazione cognome
            if (newSurnameBox.Text.Trim().Length > 0)
                newsurname = newSurnameBox.Text;
            else
            {
                MessageBox.Show("Inserire un cognome valido", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }

            //assegnazione data di nascita
            if (newBirthDatePicker.Value <= DateTime.Now)
                newbirthDate = newBirthDatePicker.Value;
            else
            {
                MessageBox.Show("Inserire una data di nascita valida", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }

            //assegnazione del luogo di nascita
            if (newBirthPlaceBox.Text.Trim().Length > 0)
                newbirthPlace = newBirthPlaceBox.Text;
            else
            {
                MessageBox.Show("Inserire un luogo di nascita valido", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }

            //convalida voti
            for (int i = 0; i < subjects.Length; i++)
            {
                List<int> numbers = new List<int>();
                string input = subjectGradeBoxes[i].Text;

                if (input.Length > 0)
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
                newGrades.Add(subjects[i], numbers);
            }

            if (!error)
            {
                ResetFormFields();
                Student newStudent = new Student
                {
                    numericID = GenerateStudentID(),
                    name = newname,
                    surname = newsurname,
                    birthdate = newbirthDate,
                    birthplace = newbirthPlace,
                    year_section = targetClass,
                    scores = newGrades
                };
                GlobalConfig.allStudents.Add(newStudent); 
                
                if (GlobalConfig.schoolClasses.ContainsKey(targetClass))
                {
                    GlobalConfig.schoolClasses[targetClass].Add(newStudent);
                }
                else
                {
                    GlobalConfig.schoolClasses[targetClass] = new List<Student> { newStudent };
                }

                GlobalConfig.UpdateStudentJson();
                error = false;
            }
        }
        private void ResetFormFields()
        {
            classSelBox.SelectedIndex = 0;
            newClass.Clear();
            newNameBox.Clear();
            newSurnameBox.Clear();
            newBirthPlaceBox.Clear();
            foreach (var txtbox in subjectGradeBoxes)
                txtbox.Clear();
            newBirthDatePicker.Value = newBirthDatePicker.MaxDate;
        }

        private int GenerateStudentID()
        {
            Random random = new Random();
            int newID;

            do
            {
                newID = random.Next(100000, 1000000);
            }
            while (GlobalConfig.allStudents.Any(s => s.numericID == newID));

            return newID;
        }
    }
}
