using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace EnrollmentSystem
{
    public partial class Non_Transferee : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\audap\Documents\Project\EnrollmentSystem_DB.accdb");
        OleDbCommand cmd;
        public Non_Transferee()
        {
            InitializeComponent();
        }
        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            cbGradeLevel.Text = "";
            if (rdbtnMale.Checked == true)
                cmd.Parameters.AddWithValue("@Sex", "Male");
            else if (rdbtnFemale.Checked == true)
                cmd.Parameters.AddWithValue("@Sex", "Female");
            else
                cbStrand.Text = "";
            txtAddress.Text = "";
            txtContactNum.Text = "";
            txtEmailAdd.Text = "";
            dtpDOB.Text = DateTime.Now.ToString();
        }
        private void lblClickExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("YOU WANT TO EXIT?", "Non-Transferee Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Dashboard().Show();
                this.Hide();
            }
        }

        private void btnClickSave(object sender, EventArgs e)
        {
            cmd = new OleDbCommand(@"INSERT INTO Student (StudentID, FirstName, MiddleName, LastName, GradeLevel, Sex, Strand, Address,
            ContactNum, EmailAdd, DOB) VALUES (@StudentID, @FirstName, @MiddleName, @LastName, @GradeLevel, @Sex, @Strand, @Address, 
            @ContactNum, @EmailAdd, @DOB)", con);
            cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@GradeLevel", cbGradeLevel.Text);
            if (rdbtnMale.Checked == true)
                cmd.Parameters.AddWithValue("@Sex", "Male");
            else if (rdbtnFemale.Checked == true)
                cmd.Parameters.AddWithValue("@Sex", "Female");
            else
            cmd.Parameters.AddWithValue("@Sex", "");
            cmd.Parameters.AddWithValue("@Strand", cbStrand.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@ContactNum", txtContactNum.Text);
            cmd.Parameters.AddWithValue("@EmailAdd", txtEmailAdd.Text);
            cmd.Parameters.AddWithValue("@DOB", dtpDOB.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You have saved a record.");

            ClearFields();
        }
    }
}

