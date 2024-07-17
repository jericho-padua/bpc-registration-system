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
    public partial class About_School : Form
    {
        public About_School()
        {
            InitializeComponent();
        }

        private void lblClickExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("YOU WANT TO EXIT?", "About School", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Dashboard().Show();
                this.Hide();
            }
        }
    }
}
