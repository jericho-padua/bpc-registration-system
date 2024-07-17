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

namespace EnrollmentSystem
{
    public partial class Login : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\audap\Documents\Project\EnrollmentSystem_DB.accdb");
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClickLogin(object sender, EventArgs e)
        {
           // OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\audap\Documents\Project\EnrollmentSystem_DB.accdb");
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect, try again");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus(); 

            } 
        }

        private void lblClickClearFields(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
    }


