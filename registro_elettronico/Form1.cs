using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace registro_elettronico
{
    public partial class Form1 : Form
    {
        Button[] menubtns;
        UserControl[] usercontrols;
        
        public Form1()
        {
            InitializeComponent();
            menubtns = new Button[5] { login_btn, summary_btn, new_btn, add_btn, delete_btn };
            usercontrols = new UserControl[5] { loginControl1, summaryControl1, addNewControl1, addScoresControl1, delStudentControl1 };

            foreach (Button btn in menubtns)
                btn.Hide();
            login_btn.Show();
            foreach (UserControl userControl in usercontrols)
                userControl.Hide();
            loginControl1.Show();
        }

        public void StudentEntry(Student currentUser)
        {
            if (GlobalConfig.logged)
            {
                login_btn.Enabled = false;
                summary_btn.Show();
                
                foreach (UserControl userControl in usercontrols)
                    userControl.Hide();
                summaryControl1.Show();
            }
        }
    }
}
