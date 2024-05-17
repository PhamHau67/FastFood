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
        string conn = @"Data Source=LOVELYPOPPY\THUNHAT;Initial Catalog=FastFoodDB;Integrated Security=True;";
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool ShowPassword
        {
            get { return btn_pass.PasswordChar == '\0'; } //Trả về true nếu mật khẩu đang hiển thị
            set { btn_pass.PasswordChar = value ? '\0' : '*'; } //Thiết lập PasswordChar tùy thuộc vào giá trị của thuộc tính
        } 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Khi Checkbox được nhấp, cập nhật thuộc tính ShowPassword
            ShowPassword = checkBox1.Checked;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = btn_pass.Text;
            using (var db = new DataClasses1DataContext(conn))
            {
                var user = db.TAI_KHOANs.SingleOrDefault(u => u.TenTaiKhoan == username && u.MatKhau == password);
                if (user != null)
                {
                    lbl_error.Text = "";
                    this.Hide();
                }
                else
                {
                    lbl_error.Text = "Invalid username or password!";
                }
            }
        }
    }
}
