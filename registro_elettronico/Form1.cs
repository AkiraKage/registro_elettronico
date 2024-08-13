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

namespace registro_elettronico
{
    public partial class Form1 : Form
    {
        bool logged;
        bool privilege;
        Button[] menubtns;
        public Form1()
        {
            InitializeComponent();
            menubtns = new Button[5] { login_btn, summary_btn, new_btn, add_btn, delete_btn };
            if ( !logged ) 
            { 
                foreach( Button btn in menubtns )
                {
                    btn.Hide();
                }
                login_btn.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logged = false;
        }
    }
}
