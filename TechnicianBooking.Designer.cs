
namespace Kids_play_store_management_syste_
{
    partial class TechnicianBooking
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btntoyprts = new System.Windows.Forms.Button();
            this.btntc = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 136);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "KIDS PLAY TOY LANKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TIME PERIOD CHECKING";
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(352, 77);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(111, 23);
            this.btncheck.TabIndex = 11;
            this.btncheck.Text = "CHECK";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(126, 271);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(107, 39);
            this.btnprevious.TabIndex = 12;
            this.btnprevious.Text = "CLOSE";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btntoyprts
            // 
            this.btntoyprts.Location = new System.Drawing.Point(239, 271);
            this.btntoyprts.Name = "btntoyprts";
            this.btntoyprts.Size = new System.Drawing.Size(107, 39);
            this.btntoyprts.TabIndex = 13;
            this.btntoyprts.Text = "TOY PARTS DETAILS";
            this.btntoyprts.UseVisualStyleBackColor = true;
            this.btntoyprts.Click += new System.EventHandler(this.btntoyprts_Click);
            // 
            // btntc
            // 
            this.btntc.Location = new System.Drawing.Point(352, 271);
            this.btntc.Name = "btntc";
            this.btntc.Size = new System.Drawing.Size(107, 39);
            this.btntc.TabIndex = 14;
            this.btntc.Text = "BOOKING TECHNICIAN";
            this.btntc.UseVisualStyleBackColor = true;
            this.btntc.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // TechnicianBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 336);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btntc);
            this.Controls.Add(this.btntoyprts);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TechnicianBooking";
            this.Text = "TechnicianBooking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btntoyprts;
        private System.Windows.Forms.Button btntc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}