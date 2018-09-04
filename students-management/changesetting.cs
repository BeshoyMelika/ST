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
    public partial class changesetting : Form
    {
        public changesetting()
        {
            InitializeComponent();
        }

        private void changesetting_Load(object sender, EventArgs e)
        {
            usern.Text = Properties.Settings.Default.username;
        }

        private void usern_TextChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.username = usern.Text;
            //Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pass.Text == Properties.Settings.Default.Passowed)
            {
                if (newpass1.Text == newpass2.Text)
                {
                    Properties.Settings.Default.Passowed = newpass2.Text;
                    Properties.Settings.Default.Save();
                    pass.Clear();
                    newpass1.Clear();
                    newpass2.Clear();

                }
                else
                    erorr2.Visible = true;
            }
            else
                erorr1.Visible = true;
            Application.Restart();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                newpass1.Focus();

            }
        }

        private void newpass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();

            }
        }

        private void newpass1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                newpass2.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
