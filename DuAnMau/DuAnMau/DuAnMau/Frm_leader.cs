
using employeeManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMau
{
    public partial class Frm_leader : Form
    {
        public Frm_leader()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            pictureBox1.Controls.Add(childForm);
            pictureBox1.Tag = childForm;
            childForm.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Frm_login loginForm = new Frm_login();
                loginForm.ClearCredentials();
                loginForm.Show();
                this.Close();
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Order());
        }

        private void btn_emplyess_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_employeeManager());
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Product_Management());
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_activityHistory());
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
    }
}
