
namespace Kids_play_store_management_syste_
{
    partial class Registration
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.chpass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncreatnewacount = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "CREATE  NEW ACCOUNT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtadd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txttp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnic);
            this.panel1.Controls.Add(this.chpass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcpass);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 230);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ADDRESS";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(174, 204);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(100, 20);
            this.txtadd.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "TELEPHONE NUMBER";
            // 
            // txttp
            // 
            this.txttp.Location = new System.Drawing.Point(174, 178);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(100, 20);
            this.txttp.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "NIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "USER NAME";
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(174, 145);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(100, 20);
            this.txtnic.TabIndex = 7;
            // 
            // chpass
            // 
            this.chpass.AutoSize = true;
            this.chpass.Location = new System.Drawing.Point(174, 111);
            this.chpass.Name = "chpass";
            this.chpass.Size = new System.Drawing.Size(126, 17);
            this.chpass.TabIndex = 6;
            this.chpass.Text = "SHOW PASSWORD";
            this.chpass.UseVisualStyleBackColor = true;
            this.chpass.CheckedChanged += new System.EventHandler(this.hidepass);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CONFIRM PASSWORD";
            // 
            // txtcpass
            // 
            this.txtcpass.Location = new System.Drawing.Point(174, 85);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.PasswordChar = '*';
            this.txtcpass.Size = new System.Drawing.Size(100, 20);
            this.txtcpass.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(174, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(174, 51);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // btncreatnewacount
            // 
            this.btncreatnewacount.Location = new System.Drawing.Point(12, 336);
            this.btncreatnewacount.Name = "btncreatnewacount";
            this.btncreatnewacount.Size = new System.Drawing.Size(187, 40);
            this.btncreatnewacount.TabIndex = 15;
            this.btncreatnewacount.Text = "CREATE NEW ACCOUNT";
            this.btncreatnewacount.UseVisualStyleBackColor = true;
            this.btncreatnewacount.Click += new System.EventHandler(this.btncreatnewacount_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(57, 382);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(274, 52);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(205, 336);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(174, 40);
            this.btnlogin.TabIndex = 16;
            this.btnlogin.Text = "BACK TO LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 446);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btncreatnewacount);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.Button btncreatnewacount;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}