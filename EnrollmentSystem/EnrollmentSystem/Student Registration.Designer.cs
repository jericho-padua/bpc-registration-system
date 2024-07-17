
namespace EnrollmentSystem
{
    partial class Student_Registration
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.cbStrand = new System.Windows.Forms.ComboBox();
            this.cbGradeLevel = new System.Windows.Forms.ComboBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.lblEmailAdd = new System.Windows.Forms.Label();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.txtPreviousSchool = new System.Windows.Forms.TextBox();
            this.lblPreviousSchool = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStrand = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblNonTransferee = new System.Windows.Forms.Label();
            this.cbTransferee = new System.Windows.Forms.ComboBox();
            this.lblTransferee = new System.Windows.Forms.Label();
            this.linkBrowseImage = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblGuardian = new System.Windows.Forms.Label();
            this.txtGuardian = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(278, 722);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 53);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(218, 637);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(217, 31);
            this.dtpDOB.TabIndex = 14;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFemale.Location = new System.Drawing.Point(322, 279);
            this.rdbtnFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(87, 27);
            this.rdbtnFemale.TabIndex = 6;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMale.Location = new System.Drawing.Point(218, 279);
            this.rdbtnMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(68, 27);
            this.rdbtnMale.TabIndex = 5;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // cbStrand
            // 
            this.cbStrand.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStrand.FormattingEnabled = true;
            this.cbStrand.Items.AddRange(new object[] {
            "STEM",
            "ABM",
            "HUMSS",
            "GAS",
            "ICT"});
            this.cbStrand.Location = new System.Drawing.Point(218, 314);
            this.cbStrand.Margin = new System.Windows.Forms.Padding(4);
            this.cbStrand.Name = "cbStrand";
            this.cbStrand.Size = new System.Drawing.Size(180, 31);
            this.cbStrand.TabIndex = 7;
            // 
            // cbGradeLevel
            // 
            this.cbGradeLevel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGradeLevel.FormattingEnabled = true;
            this.cbGradeLevel.Items.AddRange(new object[] {
            "11",
            "12"});
            this.cbGradeLevel.Location = new System.Drawing.Point(218, 240);
            this.cbGradeLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbGradeLevel.Name = "cbGradeLevel";
            this.cbGradeLevel.Size = new System.Drawing.Size(180, 31);
            this.cbGradeLevel.TabIndex = 4;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(48, 637);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(51, 23);
            this.lblDOB.TabIndex = 79;
            this.lblDOB.Text = "DOB:";
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAdd.Location = new System.Drawing.Point(218, 598);
            this.txtEmailAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(336, 31);
            this.txtEmailAdd.TabIndex = 13;
            // 
            // lblEmailAdd
            // 
            this.lblEmailAdd.AutoSize = true;
            this.lblEmailAdd.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAdd.Location = new System.Drawing.Point(45, 598);
            this.lblEmailAdd.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEmailAdd.Name = "lblEmailAdd";
            this.lblEmailAdd.Size = new System.Drawing.Size(129, 23);
            this.lblEmailAdd.TabIndex = 77;
            this.lblEmailAdd.Text = "Email Address:";
            // 
            // txtContactNum
            // 
            this.txtContactNum.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNum.Location = new System.Drawing.Point(278, 559);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(276, 31);
            this.txtContactNum.TabIndex = 12;
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNum.Location = new System.Drawing.Point(45, 559);
            this.lblContactNum.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(215, 23);
            this.lblContactNum.TabIndex = 75;
            this.lblContactNum.Text = "Parents Contact Number:";
            // 
            // txtPreviousSchool
            // 
            this.txtPreviousSchool.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousSchool.Location = new System.Drawing.Point(218, 481);
            this.txtPreviousSchool.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreviousSchool.Name = "txtPreviousSchool";
            this.txtPreviousSchool.Size = new System.Drawing.Size(336, 31);
            this.txtPreviousSchool.TabIndex = 10;
            // 
            // lblPreviousSchool
            // 
            this.lblPreviousSchool.AutoSize = true;
            this.lblPreviousSchool.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousSchool.Location = new System.Drawing.Point(45, 481);
            this.lblPreviousSchool.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPreviousSchool.Name = "lblPreviousSchool";
            this.lblPreviousSchool.Size = new System.Drawing.Size(145, 23);
            this.lblPreviousSchool.TabIndex = 80;
            this.lblPreviousSchool.Text = "Previous School:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(218, 413);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(336, 60);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(45, 413);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 23);
            this.lblAddress.TabIndex = 85;
            this.lblAddress.Text = "Address:";
            // 
            // lblStrand
            // 
            this.lblStrand.AutoSize = true;
            this.lblStrand.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrand.Location = new System.Drawing.Point(45, 314);
            this.lblStrand.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStrand.Name = "lblStrand";
            this.lblStrand.Size = new System.Drawing.Size(68, 23);
            this.lblStrand.TabIndex = 76;
            this.lblStrand.Text = "Strand:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(48, 279);
            this.lblSex.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(45, 23);
            this.lblSex.TabIndex = 78;
            this.lblSex.Text = "Sex:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(218, 201);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(336, 31);
            this.txtLastName.TabIndex = 3;
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevel.Location = new System.Drawing.Point(45, 243);
            this.lblGradeLevel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(110, 23);
            this.lblGradeLevel.TabIndex = 81;
            this.lblGradeLevel.Text = "Grade Level:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(218, 123);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(336, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(218, 162);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(336, 31);
            this.txtMiddleName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(45, 204);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 82;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(45, 126);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 23);
            this.lblFirstName.TabIndex = 83;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(218, 84);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(336, 31);
            this.txtStudentID.TabIndex = 0;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(45, 165);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(123, 23);
            this.lblMiddleName.TabIndex = 84;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(48, 84);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(100, 23);
            this.lblStudentID.TabIndex = 74;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(569, 752);
            this.lblExit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(42, 23);
            this.lblExit.TabIndex = 59;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblNonTransferee
            // 
            this.lblNonTransferee.AutoSize = true;
            this.lblNonTransferee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNonTransferee.Font = new System.Drawing.Font("Century", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonTransferee.Location = new System.Drawing.Point(133, 21);
            this.lblNonTransferee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNonTransferee.Name = "lblNonTransferee";
            this.lblNonTransferee.Size = new System.Drawing.Size(382, 43);
            this.lblNonTransferee.TabIndex = 86;
            this.lblNonTransferee.Text = "Student Registration";
            // 
            // cbTransferee
            // 
            this.cbTransferee.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransferee.FormattingEnabled = true;
            this.cbTransferee.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbTransferee.Location = new System.Drawing.Point(218, 362);
            this.cbTransferee.Margin = new System.Windows.Forms.Padding(4);
            this.cbTransferee.Name = "cbTransferee";
            this.cbTransferee.Size = new System.Drawing.Size(180, 31);
            this.cbTransferee.TabIndex = 8;
            // 
            // lblTransferee
            // 
            this.lblTransferee.AutoSize = true;
            this.lblTransferee.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferee.Location = new System.Drawing.Point(45, 362);
            this.lblTransferee.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTransferee.Name = "lblTransferee";
            this.lblTransferee.Size = new System.Drawing.Size(171, 23);
            this.lblTransferee.TabIndex = 88;
            this.lblTransferee.Text = "Are you Transferee?";
            // 
            // linkBrowseImage
            // 
            this.linkBrowseImage.AutoSize = true;
            this.linkBrowseImage.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBrowseImage.Location = new System.Drawing.Point(214, 675);
            this.linkBrowseImage.Name = "linkBrowseImage";
            this.linkBrowseImage.Size = new System.Drawing.Size(145, 23);
            this.linkBrowseImage.TabIndex = 15;
            this.linkBrowseImage.TabStop = true;
            this.linkBrowseImage.Text = "Upload an Image";
            this.linkBrowseImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBrowseImage_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 675);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 79;
            this.label1.Text = "Your 2x2 Picture:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblGuardian
            // 
            this.lblGuardian.AutoSize = true;
            this.lblGuardian.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardian.Location = new System.Drawing.Point(45, 520);
            this.lblGuardian.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGuardian.Name = "lblGuardian";
            this.lblGuardian.Size = new System.Drawing.Size(139, 23);
            this.lblGuardian.TabIndex = 80;
            this.lblGuardian.Text = "Guardian Name:";
            // 
            // txtGuardian
            // 
            this.txtGuardian.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardian.Location = new System.Drawing.Point(218, 520);
            this.txtGuardian.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuardian.Name = "txtGuardian";
            this.txtGuardian.Size = new System.Drawing.Size(336, 31);
            this.txtGuardian.TabIndex = 11;
            // 
            // Student_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 824);
            this.Controls.Add(this.linkBrowseImage);
            this.Controls.Add(this.cbTransferee);
            this.Controls.Add(this.lblTransferee);
            this.Controls.Add(this.lblNonTransferee);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.cbStrand);
            this.Controls.Add(this.cbGradeLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtEmailAdd);
            this.Controls.Add(this.lblEmailAdd);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.txtGuardian);
            this.Controls.Add(this.lblGuardian);
            this.Controls.Add(this.txtPreviousSchool);
            this.Controls.Add(this.lblPreviousSchool);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStrand);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblGradeLevel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblExit);
            this.Name = "Student_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.ComboBox cbStrand;
        private System.Windows.Forms.ComboBox cbGradeLevel;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.Label lblEmailAdd;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.TextBox txtPreviousSchool;
        private System.Windows.Forms.Label lblPreviousSchool;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStrand;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblNonTransferee;
        private System.Windows.Forms.ComboBox cbTransferee;
        private System.Windows.Forms.Label lblTransferee;
        private System.Windows.Forms.LinkLabel linkBrowseImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblGuardian;
        private System.Windows.Forms.TextBox txtGuardian;
    }
}