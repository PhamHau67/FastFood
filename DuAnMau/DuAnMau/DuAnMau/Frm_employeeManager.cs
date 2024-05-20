using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace DuAnMau
{
    public partial class Frm_employeeManager : Form
    {
        private string _con = "Data Source=DESKTOP-R9SVLJT\\HUNG;Initial Catalog=FastFoodDB;Integrated Security=True";
        public Frm_employeeManager()
        {
            InitializeComponent();
            Load_dgv_manager();
        }
        public void Load_dgv_manager()
        {
            using (var db = new DataClasses1DataContext(_con))
            {
                var query = from nv in db.NHAN_VIENs
                            select nv;
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã nhân viên");
                dt.Columns.Add("Tên nhân viên");
                dt.Columns.Add("CCCD");
                dt.Columns.Add("Mã bộ phận");
                dt.Columns.Add("Mã vai trò");
                dt.Columns.Add("Ngày sinh");
                dt.Columns.Add("Giới tính");
                dt.Columns.Add("Số điện thoại");
                dt.Columns.Add("Ngày đăng kí");
                dt.Columns.Add("Gmail");
                dt.Columns.Add("Trạng thái");
                foreach (var item in query)
                {
                    string trangThai = (bool)item.TrangThai ? "Đang đi làm" : "Đã nghỉ làm";
                    string gioiTinh = (bool)item.GioiTinh ? "Nam" : "Nữ";
                    dt.Rows.Add(item.MaNhanVien, item.TenNhanVien, item.CCCD, item.MaBoPhan, item.MaVaiTro, item.NgaySinh, gioiTinh, item.SDT, item.NgayDangKi, item.Gmail, trangThai);
                }
                dgv_staff.DataSource = dt;
            }
        }
        
        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_staff.Rows[e.RowIndex];
                txt_IDStaff.Text = row.Cells["Mã nhân viên"].Value.ToString();
                txt_NameStaff.Text = row.Cells["Tên nhân viên"].Value.ToString();
                txt_CCCD.Text = row.Cells["CCCD"].Value.ToString();
                txt_IDDepartment.Text = row.Cells["Mã bộ phận"].Value.ToString();
                txt_IDRole.Text = row.Cells["Mã vai trò"].Value.ToString();
                dtp_Birthday.Value = DateTime.Parse(row.Cells["Ngày sinh"].Value.ToString());
                bool isMale;
                if (bool.TryParse(row.Cells["Giới tính"].Value.ToString(), out isMale))
                {
                    rdo_Male.Checked = isMale;
                    rdo_Female.Checked = !isMale;
                }
                txt_PhoneNumber.Text = row.Cells["Số điện thoại"].Value.ToString();
                dtp_SignUpDay.Value = DateTime.Parse(row.Cells["Ngày đăng kí"].Value.ToString());
                txt_Gmail.Text = row.Cells["Gmail"].Value.ToString();
                bool stillWorking;
                if (bool.TryParse(row.Cells["Trạng thái"].Value.ToString(), out stillWorking))
                {
                    rdo_StillWorking.Checked = stillWorking;
                    rdo_Leave.Checked = !stillWorking;
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DataClasses1DataContext(_con))
                {
                    // Tạo một đối tượng NHAN_VIEN mới và gán các giá trị từ các điều khiển trên form
                    NHAN_VIEN newEmployee = new NHAN_VIEN
                    {
                        MaNhanVien = txt_IDStaff.Text,
                        TenNhanVien = txt_NameStaff.Text,
                        CCCD = txt_CCCD.Text,
                        MaBoPhan = txt_IDDepartment.Text,
                        MaVaiTro = txt_IDRole.Text,
                        NgaySinh = dtp_Birthday.Value,
                        GioiTinh = rdo_Male.Checked, // true nếu rdo_Male được chọn, ngược lại là false
                        SDT = txt_PhoneNumber.Text,
                        NgayDangKi = dtp_SignUpDay.Value,
                        Gmail = txt_Gmail.Text,
                        TrangThai = rdo_StillWorking.Checked // true nếu rdo_StillWorking được chọn, ngược lại là false
                    };

                    // Thêm nhân viên mới vào cơ sở dữ liệu
                    db.NHAN_VIENs.InsertOnSubmit(newEmployee);
                    db.SubmitChanges();

                    // Hiển thị MessageBox thông báo khi thêm thành công
                    MessageBox.Show("Nhân viên đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi thêm vào cơ sở dữ liệu, cập nhật DataGridView
                    Load_dgv_manager(); // Gọi lại phương thức Load_dgv_manager để tải lại dữ liệu
                }
            }
            catch (Exception ex)
            {
                // Hiển thị MessageBox thông báo khi xảy ra lỗi
                MessageBox.Show("Thêm nhân viên thất bại!\nLỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
