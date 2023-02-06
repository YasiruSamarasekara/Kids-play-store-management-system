
namespace Kids_play_store_management_syste_
{
    partial class EmpInter
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnprevious = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btncata = new System.Windows.Forms.Button();
            this.btnslehis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "KIDS PLAY TOY LANKA";
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(291, 384);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(119, 25);
            this.btnprevious.TabIndex = 9;
            this.btnprevious.Text = "PREVIOUS\r\n";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btncata);
            this.groupBox1.Controls.Add(this.btnslehis);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 322);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT ONE";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(383, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "TOY SALES ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncata
            // 
            this.btncata.Location = new System.Drawing.Point(6, 105);
            this.btncata.Name = "btncata";
            this.btncata.Size = new System.Drawing.Size(383, 43);
            this.btncata.TabIndex = 13;
            this.btncata.Text = "CATEGORY";
            this.btncata.UseVisualStyleBackColor = true;
            this.btncata.Click += new System.EventHandler(this.btncata_Click);
            // 
            // btnslehis
            // 
            this.btnslehis.Location = new System.Drawing.Point(6, 176);
            this.btnslehis.Name = "btnslehis";
            this.btnslehis.Size = new System.Drawing.Size(383, 43);
            this.btnslehis.TabIndex = 12;
            this.btnslehis.Text = "SALES HISTORY";
            this.btnslehis.UseVisualStyleBackColor = true;
            this.btnslehis.Click += new System.EventHandler(this.btnslehis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "TECHNICIAN BOOKING";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpInter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.label1);
            this.Name = "EmpInter";
            this.Text = "EmpInter";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btncata;
        private System.Windows.Forms.Button btnslehis;
        private System.Windows.Forms.Button button1;
    }
}