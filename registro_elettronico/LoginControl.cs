using registro_elettronico.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace registro_elettronico
{
    public partial class LoginControl : UserControl
    {
        bool visible = false;
        List<Student> studenti;
        List<Teacher> insegnanti;
        public LoginControl()
        {
            InitializeComponent();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            studenti = GlobalConfig.allStudents;
        }
        private void pass_visibility_Click(object sender, EventArgs e)
        {
            if (visible)
            {
                visible = false;
                password_txtbox.UseSystemPasswordChar = false;
                pass_visibility.BackgroundImage = Resources.eye;
            }
            else
            {
                visible = true;
                password_txtbox.UseSystemPasswordChar = true;
                pass_visibility.BackgroundImage = Resources.no_eye;
            }
        }

        private void access_btn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;
            string username = username_txtbox.Text.Trim();
            string password = password_txtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                login_error_lbl.Text = "Attenzione! I campi non possono essere vuoti";
                return;
            }

            if (password.Substring(password.Length - 4) == "0000")
            {
                if (!File.Exists(GlobalConfig.teacherRecords))
                {
                    MessageBox.Show("Il file teachers.json non è stato trovato. Assicurati che il file esista nella directory corretta.", "Errore",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string json = File.ReadAllText(GlobalConfig.teacherRecords);
                insegnanti = JsonConvert.DeserializeObject<List<Teacher>>(json);

                for (int i = 0; i < insegnanti.Count; i++)
                {
                    string expectedUsername = insegnanti[i].name + "_" + insegnanti[i].surname;
                    string expectedPassword = insegnanti[i].perskey + insegnanti[i].numericID.ToString();
                    if (username == expectedUsername && password == expectedPassword)
                    {
                        GlobalConfig.logged = true;
                        GlobalConfig.privilege = true;
                        if (password.Substring(password.Length - 5) == "00000")
                            GlobalConfig.fullPrivilege = true;

                        mainForm.PrivilegeEntry();
                        return;
                    }
                }

            }
            for (int i = 0; i < studenti.Count; i++)
            {
                string expectedUsername = studenti[i].name + "_" + studenti[i].surname;
                string expectedPassword = studenti[i].numericID.ToString() + studenti[i].year_section;
                if (username == expectedUsername && password == expectedPassword)
                {
                    GlobalConfig.logged = true;

                    mainForm.StudentEntry();

                    GlobalConfig.loggedUser = studenti[i];
                    return;
                }
            }
            if (!GlobalConfig.logged)
                login_error_lbl.Text = "Le credenziali inserite risultano errate";
        }
    }
}
