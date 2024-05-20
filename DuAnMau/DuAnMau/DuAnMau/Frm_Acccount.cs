using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMau
{
    public partial class Frm_Acccount : Form
    {
        string strConn = "Data Source=RUDEUS\\VVH;Initial Catalog=FastFoodDB;Integrated Security=True;";
        // Phân loại mã vai trò
        Dictionary<string, string> roleMapping = new Dictionary<string, string>
        {
            { "Quản lí", "VT001" },
            { "Nhân viên", "VT002" },
            { "Admin", "VT003" }
        };
        public Frm_Acccount()
        {
            SqlDataAdapter _adt = null;
            InitializeComponent();
            LoadData_Dgv();
            SqlConnection _conn = null;
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

                dgv_Accout.DataSource = ListAc.ToList();

                // Đổi Tiếng Việt
                dgv_Accout.Columns["MaTaiKhoan"].HeaderText = "Mã Tài Khoản";
                dgv_Accout.Columns["TenTaiKhoan"].HeaderText = "Tên Tài Khoản";
                dgv_Accout.Columns["MatKhau"].HeaderText = "Mật Khẩu";
                dgv_Accout.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
                dgv_Accout.Columns["Gmail"].HeaderText = "Gmail";
                dgv_Accout.Columns["TenVaiTro"].HeaderText = "Vai Trò";


            }
        }

        private void dgv_Accout_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // lấy dữ liệu từ click vào các biến
                DataGridViewRow row = dgv_Accout.Rows[e.RowIndex];
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
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
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

                        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                            string.IsNullOrEmpty(employeeID) || string.IsNullOrEmpty(gmail) ||
                            string.IsNullOrEmpty(roleName))
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // check coi nhân viên có nhân viên nào có mã này ko
                        var existingEmployee = db.NHAN_VIENs.FirstOrDefault(nv => nv.MaNhanVien == employeeID);
                        if (existingEmployee == null)
                        {
                            MessageBox.Show("Mã nhân viên không tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Sau đó kiểm tra xem nhân viên đã có tài khoản chưa
                        var existingAccount = db.TAI_KHOANs.FirstOrDefault(tk => tk.MaNhanVien == employeeID);
                        if (existingAccount != null)
                        {
                            MessageBox.Show("Nhân viên này đã có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // kiểm tra xem có vai trò này không
                        var existingRole = db.VAITROs.FirstOrDefault(vt => vt.TenVaiTro == roleName);
                        if (existingRole == null)
                        {
                            MessageBox.Show("Vai trò không tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Thực hiện thêm dữ liệu vào bản tài khoản khi đã check xong các lỗi 
                        var newAccount = new TAI_KHOAN
                        {
                            MaTaiKhoan = accountID,
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
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_repair_Click(object sender, EventArgs e)
        {
            // chức năng sửa dữ liệu
            using (var db = new DataClasses1DataContext(strConn))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sữa dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
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
                        var accountToUpdate = db.TAI_KHOANs.FirstOrDefault(tk => tk.MaTaiKhoan == accountID);
                        if (accountToUpdate == null)
                        {
                            MessageBox.Show("Không tìm thấy tài khoản để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Cập nhật thông tin tài khoản
                        accountToUpdate.TenTaiKhoan = username;
                        accountToUpdate.MatKhau = password;
                        accountToUpdate.MaNhanVien = employeeID;

                        // Lấy mã vai trò từ dictionary
                        string roleCode;
                        if (!roleMapping.TryGetValue(roleName, out roleCode))
                        {
                            MessageBox.Show("Vai trò không tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Cập nhật thông tin nhân viên và vai trò
                        var employeeToUpdate = db.NHAN_VIENs.FirstOrDefault(nv => nv.MaNhanVien == employeeID);
                        if (employeeToUpdate != null)
                        {
                            // Chỉ cập nhật mã vai trò nếu vai trò mới khác với vai trò hiện tại
                            if (employeeToUpdate.MaVaiTro != roleCode)
                            {
                                employeeToUpdate.MaVaiTro = roleCode; // Cập nhật mã vai trò cho nhân viên
                            }
                            employeeToUpdate.Gmail = gmail; // Luôn cập nhật Gmail
                        }

                        db.SubmitChanges();

                        LoadData_Dgv();
                        MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi cập nhật thông tin tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Không tìm thấy tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    db.TAI_KHOANs.DeleteOnSubmit(accountToDelete);
                    db.SubmitChanges();

                    LoadData_Dgv();
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // chức năng refresh
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn làm mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {

                LoadData_Dgv();
                return;
            }

            using (var db = new DataClasses1DataContext(strConn))
            {

                var searchResults = from tk in db.TAI_KHOANs
                                    join nv in db.NHAN_VIENs on tk.MaNhanVien equals nv.MaNhanVien
                                    join vt in db.VAITROs on nv.MaVaiTro equals vt.MaVaiTro
                                    where tk.MaTaiKhoan.ToLower().Contains(searchText) ||
                                          tk.TenTaiKhoan.ToLower().Contains(searchText) ||
                                          tk.MatKhau.ToLower().Contains(searchText) ||
                                          nv.MaNhanVien.ToLower().Contains(searchText) ||
                                          nv.Gmail.ToLower().Contains(searchText) ||
                                          vt.TenVaiTro.ToLower().Contains(searchText)
                                    select new
                                    {
                                        tk.MaTaiKhoan,
                                        tk.TenTaiKhoan,
                                        tk.MatKhau,
                                        nv.MaNhanVien,
                                        nv.Gmail,
                                        vt.TenVaiTro
                                    };

                var resultList = searchResults.ToList();

                if (resultList.Count > 0)
                {

                    dgv_Accout.DataSource = resultList;


                    dgv_Accout.Columns["MaTaiKhoan"].HeaderText = "Mã Tài Khoản";
                    dgv_Accout.Columns["TenTaiKhoan"].HeaderText = "Tên Tài Khoản";
                    dgv_Accout.Columns["MatKhau"].HeaderText = "Mật Khẩu";
                    dgv_Accout.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
                    dgv_Accout.Columns["Gmail"].HeaderText = "Gmail";
                    dgv_Accout.Columns["TenVaiTro"].HeaderText = "Vai Trò";


                    MessageBox.Show($"Tìm thấy {resultList.Count} dữ liệu. \nlưu ý: dữ liệu tài khoản không thể tìm dựa trên mật khẩu. \tNếu bank muốn tiếp tục truy xuất thông tin hãy làm mới trang. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Không tìm thấy dữ liệu nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
