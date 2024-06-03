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
    public partial class Frm_home : Form
    {
        public Frm_home()
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_revenueMangament());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Frm_login loginForm = new Frm_login();
            loginForm.ClearCredentials();
            loginForm.Show();
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Order());
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Account());
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

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Manage_invoices());
        }
    }
}
