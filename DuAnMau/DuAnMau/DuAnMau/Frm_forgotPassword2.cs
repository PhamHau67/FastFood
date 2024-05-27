using Guna.UI2.WinForms;
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
    public partial class Frm_forgotPassword2 : Form
    {
        public Frm_forgotPassword2()
        {
            InitializeComponent();
        }
        private void TogglePasswordVisibility(Guna2TextBox textBox, Guna2Button btnOpenEye, Guna2Button btnCloseEye)
        {
            if (textBox.PasswordChar == '*')
            {
                btnCloseEye.BringToFront();
                textBox.PasswordChar = '\0';
            }
            else
            {
                btnOpenEye.BringToFront();
                textBox.PasswordChar = '*';
            }
        }
        private void btn_openEye_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txt_newPass, btn_openEye, btn_closeEye);
        }

        private void btn_closeEye_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txt_newPass, btn_openEye, btn_closeEye);
        }

        private void btn_openEye1_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txt_rePass, btn_openEye1, btn_closeEye2);
        }

        private void btn_closeEye2_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txt_rePass, btn_openEye1, btn_closeEye2);
        }

        private void btn_recover_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_login frm_Login = new Frm_login();
            frm_Login.Show();
        }
    }
}
