using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace registro_elettronico
{
    public partial class AdminControl : UserControl
    {
        List<Teacher> allTeachers;
        public AdminControl()
        {
            InitializeComponent();
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText(GlobalConfig.teacherRecords);
            allTeachers = JsonConvert.DeserializeObject<List<Teacher>>(json);
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            bool error = false;
            string newname, newsurname, newkey;

            //assegnazione nome
            if (newNameBox.Text.Trim().Length > 0)
                newname = newNameBox.Text.Trim();
            else
            {
                MessageBox.Show("Inserire un nome valido", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }

            //assegnazione cognome
            if (newSurnameBox.Text.Trim().Length > 0)
                newsurname = newSurnameBox.Text.Trim();
            else
            {
                MessageBox.Show("Inserire un cognome valido", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }

            //assegnazione chiave personale
            if (keyBox.Text.Trim().Length > 0)
                newkey = keyBox.Text.Trim();
            else
            {
                MessageBox.Show("Inserire una chiave valida", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }

            if (!error)
            {
                ResetFormFields();
                Teacher newTeacher = new Teacher
                {
                    numericID = GenerateTeacherID(),
                    name = newname,
                    surname = newsurname,
                    perskey = newkey
                };
                allTeachers.Add(newTeacher);
                UpdateTeacherJson();
                MessageBox.Show("Nuovo insegnante registrato correttamente", "Successo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = false;
            }
        }

        private void ResetFormFields()
        {
            newNameBox.Clear();
            newSurnameBox.Clear();
            keyBox.Clear();
        }

        private int GenerateTeacherID()
        {
            var lastTeacher = allTeachers[allTeachers.Count - 1];

            int lastID = Convert.ToInt32(lastTeacher.numericID.ToString().TrimEnd('0'));
            int newID = lastID + 2;

            string newIDString = newID.ToString();
            newIDString += "0000";

            newID = Convert.ToInt32(newIDString);

            return newID;
        }

        private void UpdateTeacherJson()
        {
            string json = JsonConvert.SerializeObject(allTeachers, Formatting.Indented);
            File.WriteAllText(GlobalConfig.teacherRecords, json);
        }
    }
}
