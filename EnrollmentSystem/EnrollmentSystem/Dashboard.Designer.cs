
namespace EnrollmentSystem
{
    partial class Dashboard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAboutSchool = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(107, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guiguinto National Vocational High School";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnrollmentSystem.Properties.Resources.the_new;
            this.pictureBox1.Location = new System.Drawing.Point(12, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::EnrollmentSystem.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(822, 146);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 58);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "         Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnClickLogout);
            // 
            // btnAboutSchool
            // 
            this.btnAboutSchool.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutSchool.Image = global::EnrollmentSystem.Properties.Resources.school;
            this.btnAboutSchool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutSchool.Location = new System.Drawing.Point(550, 146);
            this.btnAboutSchool.Name = "btnAboutSchool";
            this.btnAboutSchool.Size = new System.Drawing.Size(194, 58);
            this.btnAboutSchool.TabIndex = 3;
            this.btnAboutSchool.Text = "About             School";
            this.btnAboutSchool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAboutSchool.UseVisualStyleBackColor = true;
            this.btnAboutSchool.Click += new System.EventHandler(this.btnAboutSchool_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::EnrollmentSystem.Properties.Resources.student_registration;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(266, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Student       Registration";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClickStudentRegistration);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Image = global::EnrollmentSystem.Properties.Resources.student_records;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(12, 146);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(198, 58);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student     Records";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnClickStudent);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1031, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAboutSchool);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStudent);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnAboutSchool;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}