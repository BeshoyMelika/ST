using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace students_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=BESHOY;Initial Catalog=school; integrated security =true ");

      

        SqlDataAdapter d;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string TableName="";
        int count;


        private void filltable() {
            d = new SqlDataAdapter("select * from "+TableName,con);
            dt.Rows.Clear();
            d.Fill(dt);
            dgv.DataSource = dt;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form edit = new edit();
            edit.Show();
            timer6.Enabled = true;
            // show items
           /* SqlDataAdapter d2 = new SqlDataAdapter("select * from " + TableName + " where student_id= " + dgv.CurrentRow.Cells[0].Value, con);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);
            text1.Text = dt2.Rows[0]["sudent_name"].ToString();
            text2.Text = dt2.Rows[0]["father_name"].ToString();
            text3.Text = dt2.Rows[0]["address"].ToString();
            text4.Text = dt2.Rows[0]["number_phone"].ToString();
            byte[] b1 = (byte[])(dt2.Rows[0]["photo"]);
            MemoryStream m2 = new MemoryStream(b1);
            picture1.Image = Image.FromStream(m2);*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                p1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(txt1.Text == ""&&txt1.Text == ""&&txt1.Text == ""&&txt1.Text == ""&&p1.Image==null)) {
                byte[] b = null;
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                b = br.ReadBytes((int)fs.Length);
                con.Open();
                cmd = new SqlCommand("insert into " + TableName + " (sudent_name ,father_name ,address , number_phone ,photo ) values ('"+txt1.Text+"','"+txt2.Text+"','"+txt3.Text+"',"+Convert.ToInt32(txt4.Text)+",@img );", con);
                cmd.Parameters.Add(new SqlParameter("@img",b));
                cmd.ExecuteNonQuery();
                con.Close();
                txt1.Clear(); txt2.Clear(); txt3.Clear(); txt4.Clear();
                p1.Image = null;
            }
            filltable();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* if (Properties.Settings.Default.Passowed != "" && Properties.Settings.Default.username != "")
            {
                login l = new login();
                l.ShowDialog();
            }*/
            dgv.ForeColor = Color.Black;
            comboBox1.SelectedIndex = 1;  
        }

        private void اعداداتالحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ch = new changesetting();
            ch.Show();
            
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void الشعبةالاولىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableName = "Class1_s1";
            filltable();
            dgv.Columns[5].Width = 400;
        }

        private void الشعبةالثانيةToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TableName = "Class1_s2";
            filltable();
            dgv.Columns[5].Width = 400;
        }

        private void الشعبةالاولىToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TableName = "Class2_s1";
            filltable();
            dgv.Columns[5].Width = 400;
        }

        private void الشعبةالثانيةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TableName = "Class2_s2";
            filltable();
            dgv.Columns[5].Width = 400;
        }

        private void الشعبةالاولىToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TableName = "Class3_s1";
            filltable();
            dgv.Columns[5].Width = 400;
        }

        private void الشعبةالثانيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableName = "Class3_s2";
            filltable();
            dgv.Columns[5].Width = 400;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter d2 = new SqlDataAdapter("select * from "+TableName+" where "+comboBox1.Text+" like '%"+search.Text +"%'",con);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);
            dgv.DataSource = dt2;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TableName != "") {
                groupBox1.Enabled = true;
                count=dgv.Rows.Count-1;
                countStudent.Text = count.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                cmd = new SqlCommand("delete from " + TableName + " where student_id= " + dgv.CurrentRow.Cells[0].Value, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                filltable();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form add = new add();
            add.Show();
           // timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!(panel2.Left >= 18))
            {
                panel2.Left = panel2.Left + 15;
                if (panel2.Left >= 18)
                {
                    timer2.Enabled = false;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.Left = panel2.Left - 15;
            if (panel2.Left <= -350)
            {
                timer2.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (!(panel3.Top <= 70))
            {
                panel3.Top = panel3.Top - 50;
                if (panel3.Top <= 70)
                {
                    timer4.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form dis = new display();
            dis.Show();
           /* timer4.Enabled = true;
            SqlDataAdapter d2 = new SqlDataAdapter("select * from " + TableName + " where student_id= " +dgv.CurrentRow.Cells[0].Value, con);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);
            tt1.Text = dt2.Rows[0]["sudent_name"].ToString();
            tt2.Text = dt2.Rows[0]["father_name"].ToString();
            tt3.Text = dt2.Rows[0]["address"].ToString();
            tt4.Text = dt2.Rows[0]["number_phone"].ToString();
            byte[] b = (byte[])(dt2.Rows[0]["photo"]);
            MemoryStream m = new MemoryStream(b);
            pictureBox2.Image = Image.FromStream(m);*/

        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
             panel3.Top = panel3.Top + 50;
            if (panel3.Top >= 850)
            {
                timer5.Enabled = false;
            }
        }

        private void countStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //////// edit buttom


            /*-----------------------------------------*/

            if (!(text1.Text == "" && text2.Text == "" && text3.Text == "" && text4.Text == "" && picture1.Image == null))
            {
                byte[] b0 = null;
                FileStream fs1 = new FileStream(openFileDialog2.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br1 = new BinaryReader(fs1);
                b0 = br1.ReadBytes((int)fs1.Length);
                con.Open();
                cmd = new SqlCommand("UPDATE Class1_s1 set sudent_name = '" + text1.Text + "' , father_name = '" + text2.Text + "', address ='" + text3.Text + "' , number_phone ='" + Convert.ToInt32(text4.Text) + "' where student_id= " + dgv.CurrentRow.Cells[0].Value, con);
                cmd.Parameters.Add(new SqlParameter("@img", b0));
                cmd.ExecuteNonQuery();
                con.Close();
                txt1.Clear(); txt2.Clear(); txt3.Clear(); txt4.Clear();
                picture1.Image = null;

            }
            filltable();
            MessageBox.Show("تم التعديل", "", MessageBoxButtons.OK);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture1.Image = null;
            if (openFileDialog2.ShowDialog() == DialogResult.OK) {
                picture1.Image = Image.FromFile(openFileDialog2.FileName);
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (panel4.Top <= 70)
            {
                panel4.Top = panel4.Top + 50;
                if (panel4.Top >= 70)
                {
                    timer6.Enabled = false;
                }
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            panel4.Top = panel4.Top - 50;
            if (panel4.Top <= -500)
            {
                timer7.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer7.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        }

     
    }

