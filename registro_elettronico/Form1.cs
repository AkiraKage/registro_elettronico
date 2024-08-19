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
        
        public Form1()
        {
            InitializeComponent();
            menubtns = new Button[5] { login_btn, summary_btn, new_btn, add_btn, delete_btn };

            foreach (Button btn in menubtns)
                btn.Hide();
            login_btn.Show();
        }

        public void UpdateVisibility(Student currentUser)
        {
            if (GlobalConfig.logged)
            {
                login_btn.Enabled = false;
                if (GlobalConfig.privilege)
                {
                    foreach (Button btn in menubtns)
                        btn.Show();
                }
                else
                {
                    summary_btn.Show();
                }
            }
        }
    }
}
