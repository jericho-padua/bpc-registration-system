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
    public partial class Student : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\audap\Documents\Project\EnrollmentSystem_DB.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        string img = "";
        public Student()
        {
            InitializeComponent();
            LoadStudents();
        }
          /*  private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.ImageLocation = value; }
        } */
        private void ClearFields()
        {
            pictureBox1.Image = null;
            txtStudentID.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            cbGradeLevel.Text = "";
            if (rdbtnMale.Checked == true)
                cmd.Parameters.AddWithValue("@Sex", "Male");
            else if (rdbtnFemale.Checked == true)
                cmd.Parameters.AddWithValue("@Sex", "Female");
            else
                cmd.Parameters.AddWithValue("@Sex", "");
            cbStrand.Text = "";
            cbTransferee.Text = "";
            txtAddress.Text = "";
            txtPreviousSchool.Text = "";
            txtGuardian.Text = "";
            txtContactNum.Text = "";
            txtEmailAdd.Text = "";
            dtpDOB.Text = DateTime.Now.ToString();
        }
        private void LoadStudents()
        {
            dgvStudents.Rows.Clear();
            con.Open();
            cmd = new OleDbCommand(@"SELECT * FROM Student
             WHERE FirstName LIKE '%" + txtSearch.Text + "%' " +
             "OR LastName LIKE '%" + txtSearch.Text + "%' OR Sex = '" + txtSearch.Text + "' " +
             "ORDER BY LastName ASC", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvStudents.Rows.Add(dr["StudentID"].ToString(), dr["FirstName"].ToString(), dr["MiddleName"].ToString(), dr["LastName"].ToString(),
                dr["GradeLevel"].ToString(), dr["Sex"].ToString(), dr["Strand"].ToString(), dr["Transferee"].ToString(), dr["Address"].ToString(),
                dr["PrevSchool"].ToString(), dr["GuardianName"].ToString(), dr["ContactNum"].ToString(), dr["EmailAdd"].ToString(), dr["DOB"].ToString()
               , dr["Image"].ToString());
                
            }
            //, File.ReadAllBytes(dr["Image"].ToString())
            dr.Close();
            con.Close();
        }
        private void lblClickExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("YOU WANT TO EXIT?", "Student Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Dashboard().Show();
                this.Hide();
            }
        }
       /* private void btnClickSave(object sender, EventArgs e)
        {
            cmd = new OleDbCommand(@"INSERT INTO Student ([StudentID], [FirstName], [MiddleName], [LastName], [GradeLevel], [Sex], [Strand], [Address],
            [PrevSchool], [ContactNum], [EmailAdd], [DOB], [Image]) VALUES (@StudentID, @FirstName, @MiddleName, @LastName, @GradeLevel, @Sex, @Strand, @Address, 
            @PrevSchool, @ContactNum, @EmailAdd, @DOB, @Image)", con);
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
            cmd.Parameters.AddWithValue("@PrevSchool", txtPreviousSchool.Text);
            cmd.Parameters.AddWithValue("@ContactNum", txtContactNum.Text);
            cmd.Parameters.AddWithValue("@EmailAdd", txtEmailAdd.Text);
            cmd.Parameters.AddWithValue("@DOB", dtpDOB.Text);
            cmd.Parameters.AddWithValue("@Image", img);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You have saved a record.");

            ClearFields();
            LoadStudents();
        } */
        private void btnClickUpdate(object sender, EventArgs e)
        {
                cmd = new OleDbCommand(@"UPDATE Student SET [FirstName] = @FirstName, [MiddleName] = @MiddleName, [LastName] = @LastName, 
            [GradeLevel] = @GradeLevel, [Sex] = @Sex, [Strand] = @Strand , [Transferee] = @Transferee, [Address] = @Address, [PrevSchool] = @PrevSchool, 
            [GuardianName] = @GuardianName, [ContactNum] = @ContactNum, [EmailAdd] = @EmailAdd, [DOB] = @DOB, [Image] = @Image  WHERE STUDENTID = @StudentID", con);
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
                cmd.Parameters.AddWithValue("@Transferee", cbTransferee.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@PrevSchool", txtPreviousSchool.Text);
                cmd.Parameters.AddWithValue("@GuardianName", txtGuardian.Text);
                cmd.Parameters.AddWithValue("@ContactNum", txtContactNum.Text);
                cmd.Parameters.AddWithValue("@EmailAdd", txtEmailAdd.Text);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Text);
                cmd.Parameters.AddWithValue("@Image", img);
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You have update a record.");

                ClearFields();
                LoadStudents();
              //  btnSave.Enabled = true;
            
        } 
        private void btnClickDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("YOU WANT TO DELETE THIS RECORD?", "RESERVATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new OleDbCommand(@"DELETE FROM Student WHERE StudentID = @StudentID", con);
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You have deleted a record.");

                ClearFields();
                LoadStudents();
               // btnSave.Enabled = true;
            }

        }
        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void dgvDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                //btnSave.Enabled = false;
                txtStudentID.Text = dgvStudents.CurrentRow.Cells[0].Value.ToString();
                txtFirstName.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString();
                txtMiddleName.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString();
                txtLastName.Text = dgvStudents.CurrentRow.Cells[3].Value.ToString();
                cbGradeLevel.Text = dgvStudents.CurrentRow.Cells[4].Value.ToString();
                if (rdbtnMale.Checked == true)
                    dgvStudents.CurrentRow.Cells[5].Value.ToString();
                else if (rdbtnFemale.Checked == true)
                    dgvStudents.CurrentRow.Cells[5].Value.ToString();
                else
                    dgvStudents.CurrentRow.Cells[5].Value.ToString();
                cbStrand.Text = dgvStudents.CurrentRow.Cells[6].Value.ToString();
                cbTransferee.Text = dgvStudents.CurrentRow.Cells[7].Value.ToString();
                txtAddress.Text = dgvStudents.CurrentRow.Cells[8].Value.ToString();
                txtPreviousSchool.Text = dgvStudents.CurrentRow.Cells[9].Value.ToString();
                txtGuardian.Text = dgvStudents.CurrentRow.Cells[10].Value.ToString();
                txtContactNum.Text = dgvStudents.CurrentRow.Cells[11].Value.ToString();
                txtEmailAdd.Text = dgvStudents.CurrentRow.Cells[12].Value.ToString();
                dtpDOB.Text = dgvStudents.CurrentRow.Cells[13].Value.ToString();
                img = dgvStudents.CurrentRow.Cells[14].Value.ToString();
                pictureBox1.ImageLocation = img;
                

            }
        }
        private void LinkClickBrowseImage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image(*.jpg;*.png) | *.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                img = openFileDialog1.FileName;
            } 
        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.appData.Student);
            studentBindingSource.DataSource = this.appData.Student;

        }

        private void dgvStudents_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvStudents.Sort(dgvStudents.Columns[dgvStudents.SortedColumn.Name], ListSortDirection.Ascending);
        }
    }
}

