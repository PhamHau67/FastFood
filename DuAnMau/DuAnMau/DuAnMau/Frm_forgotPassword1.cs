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
    public partial class Frm_forgotPassword1 : Form
    {
        public Frm_forgotPassword1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {






            this.Close();
            Frm_forgotPassword2 frm_ForgotPassword2 = new Frm_forgotPassword2();
            frm_ForgotPassword2.TopLevel = false;
            frm_ForgotPassword2.FormBorderStyle = FormBorderStyle.None;
            frm_ForgotPassword2.Dock = DockStyle.Fill;
            frm_ForgotPassword2.BringToFront();
            frm_ForgotPassword2.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_login frm_Login = new Frm_login();
            frm_Login.Show();
        }
    }
}
