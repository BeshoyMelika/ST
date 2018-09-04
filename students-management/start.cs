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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width = rectangleShape2.Width + 1;
          label3.Text = label3.Text + ".";
            if (label3.Text == "loading.....")
                label3.Text = "loading";
            if (rectangleShape2.Width == 355)
            {
                timer1.Enabled = false;
                Form fr = new Form1();
                fr.Show();
                this.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        
    }
}
