using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAboutSchool_Click(object sender, EventArgs e)
        {
            new About_School().Show();
            this.Hide();
        }

        private void btnClickStudent(object sender, EventArgs e)
        {
            new Student().Show();
            this.Hide();
        }

        private void btnClickTransferee(object sender, EventArgs e)
        {
            new Transferee().Show();
            this.Hide();
        }

        private void btnClickNonTransferee(object sender, EventArgs e)
        {
            new Non_Transferee().Show();
            this.Hide();
        }

        private void btnClickLogout(object sender, EventArgs e)
        {
            if (MessageBox.Show("YOU WANT TO EXIT?", "Registration System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void btnClickStudentRegistration(object sender, EventArgs e)
        {
            new Student_Registration().Show();
            this.Hide();
        }
    }
}
