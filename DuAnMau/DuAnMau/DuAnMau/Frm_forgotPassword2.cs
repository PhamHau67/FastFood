using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        string strConn = "Data Source=RUDEUS\\VVH;Initial Catalog=FastFoodDB;Integrated Security=True;";
        public string ReceivedOtp { get; set; }
        public string ReceivedGmail { get; set; }
        Random rand = new Random();
        int otp;
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

            using (var db = new DataClasses1DataContext(strConn))
            {
                // Tìm tài khoản với Gmail tương ứng
                var taikhoan = (from tk in db.TAI_KHOANs
                                join nv in db.NHAN_VIENs on tk.MaNhanVien equals nv.MaNhanVien
                                where nv.Gmail == ReceivedGmail
                                select tk).FirstOrDefault();

                if (taikhoan != null)
                {

                    // Kiểm tra xem có trống thông tin không
                    if (string.IsNullOrEmpty(txt_enter.Text) || string.IsNullOrEmpty(txt_newPass.Text) || string.IsNullOrEmpty(txt_rePass.Text))
                    {
                        MessageBox.Show("Please complete all information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // So sánh OTP
                    if (txt_enter.Text == ReceivedOtp)
                    {
                        // Kiểm tra mật khẩu mới và nhập lại mật khẩu
                        if (txt_newPass.Text == txt_rePass.Text)
                        {
                            // Cập nhật mật khẩu mới
                            taikhoan.MatKhau = txt_newPass.Text;
                            db.SubmitChanges();

                            MessageBox.Show("Password changed successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Đóng form hiện tại và mở lại form đăng nhập
                            this.Close();
                            Frm_login frm_Login = new Frm_login();
                            frm_Login.Show();
                        }
                        else
                        {
                            MessageBox.Show("The re-entered password does not match. Please check again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_newPass.Text = string.Empty;
                            txt_rePass.Text = string.Empty;
                        }
                    }
                    else
                    {

                        MessageBox.Show("OTP does not match. Please check again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_enter.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("No account found with this Gmail.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_login frm_Login = new Frm_login();
            frm_Login.Show();
        }

        private void btn_resend_Click(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext(strConn))
            {
                // Kiểm tra sự tồn tại của Gmail
                var user = (from nv in db.NHAN_VIENs
                            where nv.Gmail == ReceivedGmail
                            select new
                            {
                                nv.Gmail
                            }).FirstOrDefault();

                if (user != null)
                {
                    try
                    {
                        // Tạo OTP
                        otp = rand.Next(100000, 1000000);
                        var fromAddress = new MailAddress("vovanhung1313@gmail.com", "Fast food");
                        var toAddress = new MailAddress(ReceivedGmail); // Lấy email từ TextBox
                        const string fromPass = "efsk bupf npzf kcxm"; // Mật khẩu ứng dụng
                        const string subject = "OTP Code"; // Tiêu đề email

                        // Nội dung email tùy chỉnh
                        string body = $"Chào bạn,\n\nĐây là hệ thống xác minh Fast Food.\n\nMã OTP của bạn là: {otp}\n\nVui lòng sử dụng mã này để xác minh. Lưu ý không cung cấp OTP cho người khác.\n\nCảm ơn,\nCửa hàng Fast Food";

                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                            Timeout = 200000
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body,
                        })
                        {
                            smtp.Send(message);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No account found with this Gmail.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

    }
}
