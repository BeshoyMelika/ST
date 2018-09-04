namespace students_management
{
    partial class changesetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newpass1 = new System.Windows.Forms.TextBox();
            this.newpass2 = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.usern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.erorr2 = new System.Windows.Forms.Label();
            this.erorr1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(252, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "تم";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(63, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "اغلاق";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newpass1
            // 
            this.newpass1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass1.Location = new System.Drawing.Point(24, 151);
            this.newpass1.Name = "newpass1";
            this.newpass1.Size = new System.Drawing.Size(139, 27);
            this.newpass1.TabIndex = 2;
            this.newpass1.UseSystemPasswordChar = true;
            this.newpass1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newpass1_KeyPress);
            // 
            // newpass2
            // 
            this.newpass2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass2.Location = new System.Drawing.Point(24, 186);
            this.newpass2.Name = "newpass2";
            this.newpass2.Size = new System.Drawing.Size(139, 27);
            this.newpass2.TabIndex = 3;
            this.newpass2.UseSystemPasswordChar = true;
            this.newpass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newpass2_KeyPress);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(24, 88);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(139, 27);
            this.pass.TabIndex = 4;
            this.pass.UseSystemPasswordChar = true;
            this.pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_KeyPress);
            // 
            // usern
            // 
            this.usern.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usern.Location = new System.Drawing.Point(24, 53);
            this.usern.Name = "usern";
            this.usern.Size = new System.Drawing.Size(139, 27);
            this.usern.TabIndex = 5;
            this.usern.TextChanged += new System.EventHandler(this.usern_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(263, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(238, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "كلمة المرور الجديدة ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(212, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "اعادة كلمة المرور الجديدة ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(248, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "كلمة المرور القديمة";
            // 
            // erorr2
            // 
            this.erorr2.AutoSize = true;
            this.erorr2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erorr2.ForeColor = System.Drawing.Color.Red;
            this.erorr2.Location = new System.Drawing.Point(105, 226);
            this.erorr2.Name = "erorr2";
            this.erorr2.Size = new System.Drawing.Size(194, 19);
            this.erorr2.TabIndex = 11;
            this.erorr2.Text = "كلمة المرور غير متطابقة ";
            this.erorr2.Visible = false;
            this.erorr2.Click += new System.EventHandler(this.label5_Click);
            // 
            // erorr1
            // 
            this.erorr1.AutoSize = true;
            this.erorr1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erorr1.ForeColor = System.Drawing.Color.Red;
            this.erorr1.Location = new System.Drawing.Point(116, 118);
            this.erorr1.Name = "erorr1";
            this.erorr1.Size = new System.Drawing.Size(190, 19);
            this.erorr1.TabIndex = 12;
            this.erorr1.Text = "كلمة المرور غير صحيحة ";
            this.erorr1.Visible = false;
            // 
            // changesetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(451, 349);
            this.Controls.Add(this.erorr1);
            this.Controls.Add(this.erorr2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usern);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.newpass2);
            this.Controls.Add(this.newpass1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "changesetting";
            this.Text = "change setting";
            this.Load += new System.EventHandler(this.changesetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox newpass1;
        private System.Windows.Forms.TextBox newpass2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox usern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label erorr2;
        private System.Windows.Forms.Label erorr1;
    }
}