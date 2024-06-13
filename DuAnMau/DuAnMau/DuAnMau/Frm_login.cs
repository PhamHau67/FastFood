using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DuAnMau
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private Cl_conn clConn = new Cl_conn();


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool ShowPassword
        {
            get { return txt_pass.PasswordChar == '\0'; } // Trả về true nếu mật khẩu hiển thị
            set { txt_pass.PasswordChar = value ? '\0' : '*'; } // Thiết lập PasswordChar dựa trên giá trị thuộc tính
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            // Khi Checkbox được nhấp, cập nhật thuộc tính ShowPassword
            ShowPassword = checkBox1.Checked;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_pass.Text;

            // Kiểm tra mật khẩu có chứa khoảng trống hay không
            if (password.Contains(' '))
            {
                lbl_error.Text = "Password cannot contain spaces!";
                return;
            }

            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var user = (from tk in db.TAI_KHOANs
                            join nv in db.NHAN_VIENs on tk.MaNhanVien equals nv.MaNhanVien
                            join vt in db.VAITROs on nv.MaVaiTro equals vt.MaVaiTro
                            where tk.TenTaiKhoan == username && tk.MatKhau == password
                            select new { tk, nv, vt }).SingleOrDefault();

                if (user != null)
                {
                    Globals.username = user.nv.TenNhanVien; // Lưu tên nhân viên vào biến toàn cục
                    Globals.loginTime = DateTime.Now;// Lưu thời gian

                    // Truyền tên nhân viên sang form gọi món
                    Frm_Order orderForm = new Frm_Order(user.nv.TenNhanVien);

                    // Kiểm tra vai trò của người dùng và hiển thị form tương ứng
                    if (user.vt.TenVaiTro.ToLower() == "admin")
                    {
                        Frm_home frm_Admin = new Frm_home();
                        frm_Admin.Show();
                    }
                    else if (user.vt.TenVaiTro.ToLower() == "quản lý")
                    {
                        Frm_leader frm_Leader = new Frm_leader();
                        frm_Leader.Show();
                    }
                    else if (user.vt.TenVaiTro.ToLower() == "nhân viên")
                    {
                        Frm_homeOrders frm_HomeOrders = new Frm_homeOrders();
                        frm_HomeOrders.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this.Hide();
                }
                else
                {
                    lbl_error.Text = "Invalid username or password!";
                }
            }
        }




        public void ClearCredentials()
        {
            txt_user.Text = "";
            txt_pass.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();  // Đóng biểu mẫu hiện tại
            using (Frm_forgotPassword1 frm_ForgotPassword1 = new Frm_forgotPassword1())
            {
                frm_ForgotPassword1.TopLevel = true;  // Đảm bảo rằng đó là một mẫu trình độ lớn
                frm_ForgotPassword1.FormBorderStyle = FormBorderStyle.None;
                frm_ForgotPassword1.Dock = DockStyle.Fill;
                frm_ForgotPassword1.BringToFront();
                frm_ForgotPassword1.ShowDialog(); 
            }
            this.Show();
        }
    }
}
