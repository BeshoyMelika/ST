using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace students_management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == Properties.Settings.Default.username && txtpass.Text == Properties.Settings.Default.Passowed)
            {
                this.Visible = false;
            }
            else if (txtuser.Text != Properties.Settings.Default.username || txtpass.Text != Properties.Settings.Default.Passowed)
            {
                txtuser.Clear();
                txtuser.Clear();
                MessageBox.Show("Erorr");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button1.PerformClick();
            }

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
