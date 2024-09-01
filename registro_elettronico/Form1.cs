using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        UserControl currentOpen;

        public Form1()
        {
            InitializeComponent();
            menubtns = new Button[6] { login_btn, summary_btn, new_btn, add_btn, delete_btn, admin_btn };
            usercontrols = new UserControl[6] { loginControl1, summaryControl1, addNewControl1, addScoresControl1, delStudentControl1, adminControl1 };

            foreach (Button btn in menubtns)
                btn.Hide();
            login_btn.Show();
            foreach (UserControl userControl in usercontrols)
                userControl.Hide();
            loginControl1.Show();
            currentOpen = loginControl1;
        }

        public void StudentEntry()
        {
            if (GlobalConfig.logged && !GlobalConfig.privilege)
            {
                login_btn.Enabled = false;
                summary_btn.Show();
                currentOpen = summaryControl1;

                foreach (UserControl userControl in usercontrols)
                    userControl.Hide();
                summaryControl1.Show();
            }
        }

        public void PrivilegeEntry()
        {
            if (GlobalConfig.logged && GlobalConfig.privilege)
            {
                login_btn.Enabled = false;
                foreach (Button btn in menubtns)
                    btn.Show();
                currentOpen = summaryControl1;

                var students = GlobalConfig.allStudents;
                foreach (var student in students)
                {
                    if (GlobalConfig.schoolClasses.ContainsKey(student.year_section))
                    {
                        GlobalConfig.schoolClasses[student.year_section].Add(student);
                    }
                    else
                    {
                        GlobalConfig.schoolClasses[student.year_section] = new List<Student> { student };
                    }
                }

                foreach (UserControl userControl in usercontrols)
                    userControl.Hide();
                summaryControl1.Show();

                if (!GlobalConfig.fullPrivilege)
                    admin_btn.Hide();
            }
        }

        private void SwitchUserControl(UserControl newControl)
        {
            currentOpen.Hide();

            newControl.Show();
            currentOpen = newControl;
        }

        private void summary_btn_Click(object sender, EventArgs e)
        {
            SwitchUserControl(summaryControl1);
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            SwitchUserControl(addNewControl1);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            SwitchUserControl(addScoresControl1);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SwitchUserControl(delStudentControl1);
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            SwitchUserControl(adminControl1);
            Console.WriteLine("Risk zone");
        }
    }
}