namespace OrtizSql
{
    partial class FrmUpdateMember
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
            this.tbMname = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStudentNum = new System.Windows.Forms.ComboBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMname
            // 
            this.tbMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbMname.Location = new System.Drawing.Point(30, 234);
            this.tbMname.Name = "tbMname";
            this.tbMname.Size = new System.Drawing.Size(171, 30);
            this.tbMname.TabIndex = 20;
            // 
            // tbFname
            // 
            this.tbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbFname.Location = new System.Drawing.Point(30, 170);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(171, 30);
            this.tbFname.TabIndex = 19;
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbAge.Location = new System.Drawing.Point(30, 293);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(171, 30);
            this.tbAge.TabIndex = 18;
            // 
            // tbLname
            // 
            this.tbLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbLname.Location = new System.Drawing.Point(30, 104);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(171, 30);
            this.tbLname.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Student Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(25, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(25, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(25, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(25, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(25, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Program";
            // 
            // cbStudentNum
            // 
            this.cbStudentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbStudentNum.FormattingEnabled = true;
            this.cbStudentNum.Location = new System.Drawing.Point(30, 43);
            this.cbStudentNum.Name = "cbStudentNum";
            this.cbStudentNum.Size = new System.Drawing.Size(171, 33);
            this.cbStudentNum.TabIndex = 30;
            this.cbStudentNum.SelectedIndexChanged += new System.EventHandler(this.cbStudentNum_SelectedIndexChanged);
            // 
            // cbProgram
            // 
            this.cbProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(30, 426);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(171, 33);
            this.cbProgram.TabIndex = 21;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(30, 361);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(171, 33);
            this.cbGender.TabIndex = 22;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(30, 479);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(171, 31);
            this.btnConfirm.TabIndex = 31;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 522);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbStudentNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.tbMname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbLname);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUpdateMember_FormClosing);
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStudentNum;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnConfirm;
    }
}