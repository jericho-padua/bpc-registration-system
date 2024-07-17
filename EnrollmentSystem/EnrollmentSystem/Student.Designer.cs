
namespace EnrollmentSystem
{
    partial class Student
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStudentData = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
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
            this.txtGuardian = new System.Windows.Forms.TextBox();
            this.lblGuardian = new System.Windows.Forms.Label();
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.linkBrowseImage = new System.Windows.Forms.LinkLabel();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new EnrollmentSystem.AppData();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.studentTableAdapter = new EnrollmentSystem.AppDataTableAdapters.StudentTableAdapter();
            this.lblExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTransferee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreviousSchool = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentData
            // 
            this.lblStudentData.AutoSize = true;
            this.lblStudentData.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentData.Location = new System.Drawing.Point(557, 16);
            this.lblStudentData.Name = "lblStudentData";
            this.lblStudentData.Size = new System.Drawing.Size(317, 44);
            this.lblStudentData.TabIndex = 40;
            this.lblStudentData.Text = "Student Records";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1208, 697);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 36);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnClickDelete);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(847, 685);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 61);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnClickUpdate);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(177, 679);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(146, 31);
            this.dtpDOB.TabIndex = 13;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFemale.Location = new System.Drawing.Point(305, 381);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(87, 27);
            this.rdbtnFemale.TabIndex = 7;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMale.Location = new System.Drawing.Point(177, 381);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(68, 27);
            this.rdbtnMale.TabIndex = 6;
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
            this.cbStrand.Location = new System.Drawing.Point(177, 414);
            this.cbStrand.Name = "cbStrand";
            this.cbStrand.Size = new System.Drawing.Size(121, 31);
            this.cbStrand.TabIndex = 8;
            // 
            // cbGradeLevel
            // 
            this.cbGradeLevel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGradeLevel.FormattingEnabled = true;
            this.cbGradeLevel.Items.AddRange(new object[] {
            "11",
            "12"});
            this.cbGradeLevel.Location = new System.Drawing.Point(177, 343);
            this.cbGradeLevel.Name = "cbGradeLevel";
            this.cbGradeLevel.Size = new System.Drawing.Size(121, 31);
            this.cbGradeLevel.TabIndex = 5;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(22, 685);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(51, 23);
            this.lblDOB.TabIndex = 15;
            this.lblDOB.Text = "DOB:";
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAdd.Location = new System.Drawing.Point(177, 642);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(225, 31);
            this.txtEmailAdd.TabIndex = 12;
            // 
            // lblEmailAdd
            // 
            this.lblEmailAdd.AutoSize = true;
            this.lblEmailAdd.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAdd.Location = new System.Drawing.Point(22, 642);
            this.lblEmailAdd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmailAdd.Name = "lblEmailAdd";
            this.lblEmailAdd.Size = new System.Drawing.Size(129, 23);
            this.lblEmailAdd.TabIndex = 13;
            this.lblEmailAdd.Text = "Email Address:";
            // 
            // txtContactNum
            // 
            this.txtContactNum.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNum.Location = new System.Drawing.Point(217, 605);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(185, 31);
            this.txtContactNum.TabIndex = 11;
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNum.Location = new System.Drawing.Point(22, 605);
            this.lblContactNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(187, 23);
            this.lblContactNum.TabIndex = 11;
            this.lblContactNum.Text = "Parents Contact Num:";
            // 
            // txtGuardian
            // 
            this.txtGuardian.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardian.Location = new System.Drawing.Point(177, 568);
            this.txtGuardian.Name = "txtGuardian";
            this.txtGuardian.Size = new System.Drawing.Size(225, 31);
            this.txtGuardian.TabIndex = 10;
            // 
            // lblGuardian
            // 
            this.lblGuardian.AutoSize = true;
            this.lblGuardian.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardian.Location = new System.Drawing.Point(22, 568);
            this.lblGuardian.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGuardian.Name = "lblGuardian";
            this.lblGuardian.Size = new System.Drawing.Size(139, 23);
            this.lblGuardian.TabIndex = 18;
            this.lblGuardian.Text = "Guardian Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(177, 494);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(225, 31);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(22, 494);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 23);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address:";
            // 
            // lblStrand
            // 
            this.lblStrand.AutoSize = true;
            this.lblStrand.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrand.Location = new System.Drawing.Point(22, 417);
            this.lblStrand.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStrand.Name = "lblStrand";
            this.lblStrand.Size = new System.Drawing.Size(68, 23);
            this.lblStrand.TabIndex = 14;
            this.lblStrand.Text = "Strand:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(22, 380);
            this.lblSex.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(45, 23);
            this.lblSex.TabIndex = 16;
            this.lblSex.Text = "Sex:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(177, 306);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 31);
            this.txtLastName.TabIndex = 4;
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevel.Location = new System.Drawing.Point(22, 343);
            this.lblGradeLevel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(110, 23);
            this.lblGradeLevel.TabIndex = 22;
            this.lblGradeLevel.Text = "Grade Level:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(177, 231);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(225, 31);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(177, 269);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(225, 31);
            this.txtMiddleName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(22, 306);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(22, 231);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 23);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(146, 178);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(225, 31);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(22, 269);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(123, 23);
            this.lblMiddleName.TabIndex = 21;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(18, 181);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(100, 23);
            this.lblStudentID.TabIndex = 10;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1154, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 31);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column15,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudents.Location = new System.Drawing.Point(426, 96);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 25;
            this.dgvStudents.Size = new System.Drawing.Size(962, 577);
            this.dgvStudents.TabIndex = 42;
            this.dgvStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoubleClick);
            this.dgvStudents.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudents_ColumnHeaderMouseClick);
            // 
            // linkBrowseImage
            // 
            this.linkBrowseImage.AutoSize = true;
            this.linkBrowseImage.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBrowseImage.Location = new System.Drawing.Point(18, 130);
            this.linkBrowseImage.Name = "linkBrowseImage";
            this.linkBrowseImage.Size = new System.Drawing.Size(126, 23);
            this.linkBrowseImage.TabIndex = 0;
            this.linkBrowseImage.TabStop = true;
            this.linkBrowseImage.Text = "Browse Image";
            this.linkBrowseImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClickBrowseImage);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(184, 37);
            this.lblPath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 23);
            this.lblPath.TabIndex = 10;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExit.Location = new System.Drawing.Point(1337, 722);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(42, 23);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExit.Click += new System.EventHandler(this.lblClickExit);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studentBindingSource, "Image", true));
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Are you Transferee?";
            // 
            // cbTransferee
            // 
            this.cbTransferee.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransferee.FormattingEnabled = true;
            this.cbTransferee.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbTransferee.Location = new System.Drawing.Point(201, 457);
            this.cbTransferee.Name = "cbTransferee";
            this.cbTransferee.Size = new System.Drawing.Size(121, 31);
            this.cbTransferee.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 531);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Previous School:";
            // 
            // txtPreviousSchool
            // 
            this.txtPreviousSchool.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousSchool.Location = new System.Drawing.Point(177, 531);
            this.txtPreviousSchool.Name = "txtPreviousSchool";
            this.txtPreviousSchool.Size = new System.Drawing.Size(225, 31);
            this.txtPreviousSchool.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FIRST NAME";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MIDDLE NAME";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "LAST NAME";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "GRADE LEVEL";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SEX";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "STRAND";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "TRANSFEREE?";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 90;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ADDRESS";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "PREVIOUS SCHOOL";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 90;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "GUARDIAN NAME:";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 110;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "CONTACT NUM";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 90;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "EMAIL ADD";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 150;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "DOB";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Image";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column14.Visible = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 770);
            this.Controls.Add(this.linkBrowseImage);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStudentData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.cbTransferee);
            this.Controls.Add(this.cbStrand);
            this.Controls.Add(this.cbGradeLevel);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtEmailAdd);
            this.Controls.Add(this.lblEmailAdd);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.txtPreviousSchool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuardian);
            this.Controls.Add(this.lblGuardian);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStrand);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblGradeLevel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblExit);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblStudentData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
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
        private System.Windows.Forms.TextBox txtGuardian;
        private System.Windows.Forms.Label lblGuardian;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.LinkLabel linkBrowseImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPath;
        private AppData appData;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private AppDataTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTransferee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreviousSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}