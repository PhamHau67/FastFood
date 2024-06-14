using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DuAnMau
{
    public partial class Frm_forgotPassword1 : Form
    {
        private Cl_conn clConn = new Cl_conn();
        Random rand = new Random();
        int otp;
        public Frm_forgotPassword1()
        {
            InitializeComponent();
        }


        private void btn_send_Click(object sender, EventArgs e)
        {
            string userEmail = txt_nhap.Text.Trim();
            // Kiểm tra định dạng Gmail bằng Regex
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(userEmail, emailPattern))
            {
                MessageBox.Show("Invalid Gmail format!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DataClasses1DataContext(clConn.conn))
            {

                var user = db.NHAN_VIENs.FirstOrDefault(a => a.Gmail == userEmail);

                if (user != null)
                {
                    var existingAccount = db.TAI_KHOANs.FirstOrDefault(tk => tk.MaNhanVien == user.MaNhanVien);
                    if (existingAccount == null)
                    {

                        MessageBox.Show("User don't have account.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (existingAccount != null)
                    {
                        try
                        {
                            // Tạo OTP
                            otp = rand.Next(100000, 1000000);
                            var fromAddress = new MailAddress("fastfood.hethongxacminh@gmail.com", "Fast food");
                            var toAddress = new MailAddress(userEmail); // Lấy email từ TextBox
                            const string fromPass = "dxve duab mfyd nryc"; // Mật khẩu ứng dụng
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
                            MessageBox.Show("OTP sent successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Frm_forgotPassword2 frm_ForgotPassword2 = new Frm_forgotPassword2(); //mở form khác

                            frm_ForgotPassword2.ReceivedOtp = otp.ToString();
                            frm_ForgotPassword2.ReceivedGmail = userEmail.ToString();
                            frm_ForgotPassword2.Show();
                            this.Hide();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User hasn't been register", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("No account found with this Gmail. Please check again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private bool IsAccountExist(TAI_KHOAN user)
        {
            // Thay đổi logic này để kiểm tra xem tài khoản có tồn tại không
            // Ví dụ:
            return user.MaTaiKhoan != null; // Thay thế bằng logic thực tế của bạn
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_login frm_Login = new Frm_login();
            frm_Login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Frm_login frm_login = new Frm_login();
            frm_login.Show();
            this.Hide();
        }

        private void txt_nhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
