using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMau
{
    public partial class Frm_Account : Form
    {
        string strConn = "Data Source=RUDEUS\\VVH;Initial Catalog=FastFoodDB;Integrated Security=True;";
        Dictionary<string, string> roleMapping = new Dictionary<string, string>
        {
            { "Quản lý", "VT001" },
            { "Nhân viên", "VT002" },
            { "ADMIN", "VT003" }
        };
        public Frm_Account()
        {
            
            InitializeComponent();
            LoadData_Dgv();
            // Ẩn cột trống ở phía bên trái của DataGridView
            dgv_Account.RowHeadersVisible = false;
        }
        public void LoadData_Dgv()
        {
            using (var db = new DataClasses1DataContext(strConn))
            {
                //Viết câu lệnh truy vấn và join bảng
                var ListAc = from tk in db.TAI_KHOANs
                             join nv in db.NHAN_VIENs on tk.MaNhanVien equals nv.MaNhanVien

                             join vt in db.VAITROs on nv.MaVaiTro equals vt.MaVaiTro
                             select new
                             {
                                 tk.MaTaiKhoan,
                                 tk.TenTaiKhoan,
                                 tk.MatKhau,
                                 nv.MaNhanVien,
                                 nv.Gmail,
                                 vt.TenVaiTro
                             };

                dgv_Account.DataSource = ListAc.ToList();

                // Đổi Tiếng Việt
                dgv_Account.Columns["MaTaiKhoan"].HeaderText = "Account ID"; // Mã Tài Khoản
                dgv_Account.Columns["TenTaiKhoan"].HeaderText = "Account Name"; // Tên Tài Khoản
                dgv_Account.Columns["MatKhau"].HeaderText = "Password"; // Mật Khẩu
                dgv_Account.Columns["MaNhanVien"].HeaderText = "Employee ID"; // Mã Nhân Viên
                dgv_Account.Columns["Gmail"].HeaderText = "Gmail"; // Gmail
                dgv_Account.Columns["TenVaiTro"].HeaderText = "Role"; // Vai Trò


            }
        }

        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // lấy dữ liệu từ click vào các biến
                DataGridViewRow row = dgv_Account.Rows[e.RowIndex];
                string accountID = row.Cells["MaTaiKhoan"].Value.ToString();
                string username = row.Cells["TenTaiKhoan"].Value.ToString();
                string password = row.Cells["MatKhau"].Value.ToString();
                string employeeID = row.Cells["MaNhanVien"].Value.ToString();
                string email = row.Cells["Gmail"].Value.ToString();
                string role = row.Cells["TenVaiTro"].Value.ToString();

                // đưa dữ liệu vào txt
                txt_AccountID.Text = accountID;
                txt_Username.Text = username;
                txt_Password.Text = password;
                txt_EmployeeID.Text = employeeID;
                txt_Gmail.Text = email;
                cbx_Role.Text = role;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // thêm dữ liệu
            DialogResult result = MessageBox.Show("Are you sure you want to add data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var db = new DataClasses1DataContext(strConn))
                    {
                        Random random = new Random();
                        string newID;

                        do
                        {
                            newID = "TK" + random.Next(100, 999).ToString();
                        } while (db.TAI_KHOANs.Any(sp => sp.MaTaiKhoan == newID));

                        string username = txt_Username.Text.Trim();
                        string password = txt_Password.Text.Trim();
                        string employeeID = txt_EmployeeID.Text.Trim();
                        string gmail = txt_Gmail.Text.Trim();
                        string roleName = cbx_Role.Text.Trim();

                        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                            string.IsNullOrEmpty(employeeID) || string.IsNullOrEmpty(gmail) ||
                            string.IsNullOrEmpty(roleName))
                        {
                            MessageBox.Show("Please complete all information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Check tên tài khoản tồn tại chưa
                        ////cách thông thường
                        //var ck_user = (from tk in db.TAI_KHOANs
                        //                        where tk.TenTaiKhoan == username
                        //                        select tk).FirstOrDefault();

                        //if (ck_user != null)
                        //{
                        //    MessageBox.Show("Tên tài khoản này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    return;
                        //}
                        // Check tên tài khoản tồn tại chưa
                        /// dùng lamda
                        var ck_user = db.TAI_KHOANs.FirstOrDefault(tk => tk.TenTaiKhoan == username);
                        if (ck_user != null)
                        {
                            MessageBox.Show("This username already exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        //check gmail
                        var ck_gmail = db.NHAN_VIENs.FirstOrDefault(nv => nv.Gmail == gmail);
                        if (ck_gmail != null)
                        {
                            MessageBox.Show("This Gmail is already in use!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Check mã nhân viên coi nhân viên tồn tại không
                        var existingEmployee = db.NHAN_VIENs.FirstOrDefault(nv => nv.MaNhanVien == employeeID);
                        if (existingEmployee == null)
                        {
                            MessageBox.Show("Employee ID does not exist in the list!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // ckech nhân viên thêm tài khoản đzx tunwgf có tài khoản chưa
                        var existingAccount = db.TAI_KHOANs.FirstOrDefault(tk => tk.MaNhanVien == employeeID);
                        if (existingAccount != null)
                        {
                            MessageBox.Show("This employee already has an account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Check vai trò có tồn tại không
                        var existingRole = db.VAITROs.FirstOrDefault(vt => vt.TenVaiTro == roleName);
                        if (existingRole == null)
                        {
                            MessageBox.Show("Role does not exist in the list!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // add tài khoản dựa vào mã chạy ramdom
                        var newAccount = new TAI_KHOAN
                        {
                            MaTaiKhoan = newID,
                            TenTaiKhoan = username,
                            MatKhau = password,
                            MaNhanVien = employeeID
                        };

                        db.TAI_KHOANs.InsertOnSubmit(newAccount);

                        if (existingEmployee.Gmail != gmail)
                        {
                            existingEmployee.Gmail = gmail;
                        }

                        db.SubmitChanges();

                        LoadData_Dgv();
                        MessageBox.Show("Account added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btn_repair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update this Account?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // chức năng sửa dữ liệu
                using (var db = new DataClasses1DataContext(strConn))
                {

                    try
                    {
                        string accountID = txt_AccountID.Text.Trim();
                        string username = txt_Username.Text.Trim();
                        string password = txt_Password.Text.Trim();
                        string employeeID = txt_EmployeeID.Text.Trim();
                        string gmail = txt_Gmail.Text.Trim();
                        string roleName = cbx_Role.Text.Trim();

                        // Kiểm tra xem tài khoản có tồn tại trong bảng tài khoản hay không
                        var upDateAC = db.TAI_KHOANs.FirstOrDefault(tk => tk.MaTaiKhoan == accountID);
                        if (upDateAC == null)
                        {
                            MessageBox.Show("Account not found for update!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Cập nhật thông tin tài khoản
                        upDateAC.TenTaiKhoan = username;
                        upDateAC.MatKhau = password;
                        upDateAC.MaNhanVien = employeeID;

                        // Lấy mã vai trò từ dictionary
                        string roleID;
                        if (!roleMapping.TryGetValue(roleName, out roleID))
                        {
                            MessageBox.Show("Role does not exist in the list!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Cập nhật thông tin nhân viên và vai trò
                        var upDateNV = db.NHAN_VIENs.FirstOrDefault(nv => nv.MaNhanVien == employeeID);
                        if (upDateNV != null)
                        {
                            // Chỉ cập nhật mã vai trò nếu vai trò mới khác với vai trò hiện tại
                            if (upDateNV.MaVaiTro != roleID)
                            {
                                upDateNV.MaVaiTro = roleID; // Cập nhật mã vai trò cho nhân viên
                            }
                            upDateNV.Gmail = gmail; // Luôn cập nhật Gmail
                        }

                        db.SubmitChanges();

                        LoadData_Dgv();
                        MessageBox.Show("Update product successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext(strConn))
            {
                try
                {
                    string accountID = txt_AccountID.Text.Trim();

                    // Kiểm tra xem tài khoản có tồn tại trong bảng TAI_KHOAN hay không
                    var accountToDelete = db.TAI_KHOANs.FirstOrDefault(tk => tk.MaTaiKhoan == accountID);
                    if (accountToDelete == null)
                    {
                        MessageBox.Show("Account not found for deletion!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    db.TAI_KHOANs.DeleteOnSubmit(accountToDelete);
                    db.SubmitChanges();

                    LoadData_Dgv();
                    MessageBox.Show("Account deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            // chức năng refresh
            DialogResult result = MessageBox.Show("Are you sure you want to refresh?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txt_AccountID.Text = string.Empty;
                txt_Username.Text = string.Empty;
                cbx_Role.Text = string.Empty;
                txt_Password.Text = string.Empty;
                txt_EmployeeID.Text = string.Empty;
                txt_Gmail.Text = string.Empty;
                LoadData_Dgv();
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext(strConn))
            {
                var keyword = txt_Search.Text.Trim();

                var TimAc = from tk in db.TAI_KHOANs
                            
                            join nv in db.NHAN_VIENs on tk.MaNhanVien equals nv.MaNhanVien
                            join vt in db.VAITROs on nv.MaVaiTro equals vt.MaVaiTro
                            where tk.TenTaiKhoan.Contains(keyword) || tk.MatKhau.Contains(keyword) || nv.Gmail.Contains(keyword) || vt.TenVaiTro.Contains(keyword)
                            select new
                            {
                                tk.MaTaiKhoan,
                                tk.TenTaiKhoan,
                                tk.MatKhau,
                                nv.MaNhanVien,
                                nv.Gmail,
                                vt.TenVaiTro
                            };
                dgv_Account.DataSource = TimAc.ToList();
            }
        }
    }
}
