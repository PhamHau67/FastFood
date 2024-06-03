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
    public partial class Frm_homeOrders : Form
    {
        public Frm_homeOrders()
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
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Frm_login loginForm = new Frm_login();
            loginForm.ClearCredentials();
            loginForm.Show();
            this.Close();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Order());
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_activityHistory());
        }
    }
}
