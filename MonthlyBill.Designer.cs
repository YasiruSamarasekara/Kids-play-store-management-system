
namespace Kids_play_store_management_syste_
{
    partial class MonthlyBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.lbltsum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtoystoke = new System.Windows.Forms.DataGridView();
            this.BDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToyCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncheck = new System.Windows.Forms.Button();
            this.datetimetoystoke = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbcata = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvprtstoke = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quintity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dtetimeprtstoke = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.datetimetechnician = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvtoysale = new System.Windows.Forms.DataGridView();
            this.sldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoytype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.dtetimesales = new System.Windows.Forms.DateTimePicker();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoystoke)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprtstoke)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoysale)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.lbltsum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvtoystoke);
            this.groupBox1.Controls.Add(this.btncheck);
            this.groupBox1.Controls.Add(this.datetimetoystoke);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOY STOKE COST";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(316, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "CLEAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbltsum
            // 
            this.lbltsum.AutoSize = true;
            this.lbltsum.Location = new System.Drawing.Point(82, 189);
            this.lbltsum.Name = "lbltsum";
            this.lbltsum.Size = new System.Drawing.Size(13, 13);
            this.lbltsum.TabIndex = 6;
            this.lbltsum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DAILY COST";
            // 
            // dgvtoystoke
            // 
            this.dgvtoystoke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtoystoke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BDate,
            this.ToyCategory,
            this.toyname,
            this.cost});
            this.dgvtoystoke.Location = new System.Drawing.Point(7, 47);
            this.dgvtoystoke.Name = "dgvtoystoke";
            this.dgvtoystoke.Size = new System.Drawing.Size(419, 121);
            this.dgvtoystoke.TabIndex = 2;
            // 
            // BDate
            // 
            this.BDate.HeaderText = "Date";
            this.BDate.Name = "BDate";
            // 
            // ToyCategory
            // 
            this.ToyCategory.HeaderText = "TOY CATEGORY";
            this.ToyCategory.Name = "ToyCategory";
            // 
            // toyname
            // 
            this.toyname.HeaderText = "TOY NAME";
            this.toyname.Name = "toyname";
            // 
            // cost
            // 
            this.cost.HeaderText = "COST";
            this.cost.Name = "cost";
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(225, 20);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(201, 23);
            this.btncheck.TabIndex = 1;
            this.btncheck.Text = "CHECK";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // datetimetoystoke
            // 
            this.datetimetoystoke.Location = new System.Drawing.Point(7, 20);
            this.datetimetoystoke.Name = "datetimetoystoke";
            this.datetimetoystoke.Size = new System.Drawing.Size(212, 20);
            this.datetimetoystoke.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmbcata);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvprtstoke);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dtetimeprtstoke);
            this.groupBox2.Location = new System.Drawing.Point(463, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 209);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOY PART STOKE COST";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbcata
            // 
            this.cmbcata.FormattingEnabled = true;
            this.cmbcata.Items.AddRange(new object[] {
            "ALL ACCESSORIES",
            "RC TOYS",
            "HOBBY TOYS"});
            this.cmbcata.Location = new System.Drawing.Point(188, 19);
            this.cmbcata.Name = "cmbcata";
            this.cmbcata.Size = new System.Drawing.Size(121, 21);
            this.cmbcata.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DAILY COST";
            // 
            // dgvprtstoke
            // 
            this.dgvprtstoke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprtstoke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.quintity,
            this.dataGridViewTextBoxColumn3});
            this.dgvprtstoke.Location = new System.Drawing.Point(7, 46);
            this.dgvprtstoke.Name = "dgvprtstoke";
            this.dgvprtstoke.Size = new System.Drawing.Size(439, 121);
            this.dgvprtstoke.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TOY CATEGORY";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TOY NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // quintity
            // 
            this.quintity.HeaderText = "QUINTITY";
            this.quintity.Name = "quintity";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "COST";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "CHECK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtetimeprtstoke
            // 
            this.dtetimeprtstoke.Location = new System.Drawing.Point(7, 20);
            this.dtetimeprtstoke.Name = "dtetimeprtstoke";
            this.dtetimeprtstoke.Size = new System.Drawing.Size(149, 20);
            this.dtetimeprtstoke.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.datetimetechnician);
            this.groupBox3.Location = new System.Drawing.Point(12, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 197);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TECHNICIAN BOOKING ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(316, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "DAILY COST";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.Location = new System.Drawing.Point(7, 47);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(419, 121);
            this.dataGridView3.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DATE";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "TECHNICIAN NUMBER";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "TOY DETAILS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "CHARGE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "CHECK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // datetimetechnician
            // 
            this.datetimetechnician.Location = new System.Drawing.Point(7, 20);
            this.datetimetechnician.Name = "datetimetechnician";
            this.datetimetechnician.Size = new System.Drawing.Size(212, 20);
            this.datetimetechnician.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(452, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "CHART VIEW";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvtoysale);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.dtetimesales);
            this.groupBox4.Location = new System.Drawing.Point(463, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 197);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TOY SALES";
            // 
            // dgvtoysale
            // 
            this.dgvtoysale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtoysale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sldate,
            this.stoytype,
            this.cusname,
            this.price});
            this.dgvtoysale.Location = new System.Drawing.Point(0, 49);
            this.dgvtoysale.Name = "dgvtoysale";
            this.dgvtoysale.Size = new System.Drawing.Size(439, 121);
            this.dgvtoysale.TabIndex = 8;
            // 
            // sldate
            // 
            this.sldate.HeaderText = "Date";
            this.sldate.Name = "sldate";
            // 
            // stoytype
            // 
            this.stoytype.HeaderText = "TOY TYPE";
            this.stoytype.Name = "stoytype";
            // 
            // cusname
            // 
            this.cusname.HeaderText = "COUSTOMER NAME";
            this.cusname.Name = "cusname";
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.Name = "price";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(336, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "CLEAR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "DAILY COST";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(225, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(221, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "CHECK";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dtetimesales
            // 
            this.dtetimesales.Location = new System.Drawing.Point(7, 20);
            this.dtetimesales.Name = "dtetimesales";
            this.dtetimesales.Size = new System.Drawing.Size(212, 20);
            this.dtetimesales.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(689, 430);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(230, 51);
            this.button9.TabIndex = 9;
            this.button9.Text = "CLOSE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // MonthlyBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 483);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MonthlyBill";
            this.Text = "MonthlyBill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoystoke)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprtstoke)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoysale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvtoystoke;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.DateTimePicker datetimetoystoke;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvprtstoke;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtetimeprtstoke;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker datetimetechnician;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbltsum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToyCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn toyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quintity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox cmbcata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DateTimePicker dtetimesales;
        private System.Windows.Forms.DataGridView dgvtoysale;
        private System.Windows.Forms.DataGridViewTextBoxColumn sldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoytype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button button9;
    }
}