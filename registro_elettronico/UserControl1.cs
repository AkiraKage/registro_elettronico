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

namespace registro_elettronico
{
    public partial class UserControl1 : UserControl
    {
        bool visible = false;
        public UserControl1()
        {
            InitializeComponent();
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

    }
}
