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
    public partial class UserControl1 : UserControl
    {
        bool visible = false;
        List<Student> studenti;
        public UserControl1()
        {
            InitializeComponent();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(GlobalConfig.userRecords))
            {
                MessageBox.Show("Il file students.json non è stato trovato. Assicurati che il file esista nella directory corretta.", "Errore", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string json = File.ReadAllText(GlobalConfig.userRecords);

            studenti = JsonConvert.DeserializeObject<List<Student>>(json);

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
            string username = username_txtbox.Text.Trim();
            string password = password_txtbox.Text.Trim();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                login_error_lbl.Text = "Attenzione! I campi non possono essere vuoti";
                return;
            }
            for (int i = 0; i < studenti.Count; i++)
            {
                string expectedUsername = studenti[i].name + "_" + studenti[i].surname;
                string expectedPassword = studenti[i].numericID.ToString() + studenti[i].year_section;
                if (username == expectedUsername && password == expectedPassword)
                {
                    GlobalConfig.logged = true;

                    Form1 parentForm = this.FindForm() as Form1;
                    if (parentForm != null)
                    {
                        parentForm.UpdateVisibility(studenti[i]);
                    }

                    break;
                }
            }
            if (!GlobalConfig.logged)
                login_error_lbl.Text = "Le credenziali inserite risultano errate";
        }

    }
}
