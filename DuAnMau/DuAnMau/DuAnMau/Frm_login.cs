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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }
        string conn = "Data Source=RUDEUS\\VVH;Initial Catalog=FastFoodDB;Integrated Security=True;";
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool ShowPassword
        {
            get { return txt_pass.PasswordChar == '\0'; } //Trả về true nếu mật khẩu đang hiển thị
            set { txt_pass.PasswordChar = value ? '\0' : '*'; } //Thiết lập PasswordChar tùy thuộc vào giá trị của thuộc tính
        } 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Khi Checkbox được nhấp, cập nhật thuộc tính ShowPassword
            ShowPassword = checkBox1.Checked;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_pass.Text;
            using (var db = new DataClasses1DataContext(conn))
            {
                var user = db.TAI_KHOANs.SingleOrDefault(u => u.TenTaiKhoan == username && u.MatKhau == password);
                if (user != null)
                {
                    lbl_error.Text = "Password or username error!";
                    if (username == "admin")
                    {
                        Frm_home frm_Home = new Frm_home(); 
                        frm_Home.Show();
                    }
                    else if (username == "ql")
                    {
                        Frm_leader frm_Leader = new Frm_leader();
                        frm_Leader.Show();
                    }
                    else
                    {
                        Frm_homeOrders frm_HomeOrders = new Frm_homeOrders();
                        frm_HomeOrders.Show();
                    }
                    this.Hide();
                }
                else
                {
                    lbl_error.Text = "Invalid username or password!";
                }
            }
        }
        public string Username
        {
            get { return txt_user.Text; }
            set { txt_user.Text = value; }
        }

        public string Password
        {
            get { return txt_pass.Text; }
            set { txt_pass.Text = value; }
        }

        public void ClearCredentials()
        {
            txt_user.Text = "";
            txt_pass.Text = "";
        }
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Frm_forgotPassword1 frm_ForgotPassword1 = new Frm_forgotPassword1();
            frm_ForgotPassword1.TopLevel = false;
            frm_ForgotPassword1.FormBorderStyle = FormBorderStyle.None;
            frm_ForgotPassword1.Dock = DockStyle.Fill;
            frm_ForgotPassword1.BringToFront();
            frm_ForgotPassword1.Show();
        }
    }
}
