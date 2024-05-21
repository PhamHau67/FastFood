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
using System.Data.SqlClient;

namespace DuAnMau
{
    public partial class Frm_employeeManager : Form
    {
        private bool IsValidName(string name)
        {
            return !name.Any(char.IsDigit);
        }
        private bool IsValidCCCD(string cccd)
        {
            int value;
            return !string.IsNullOrWhiteSpace(cccd) && int.TryParse(cccd, out value) && value >= 0;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            int value;
            return !string.IsNullOrWhiteSpace(phoneNumber) && int.TryParse(phoneNumber, out value) && value >= 0;
        }
        private string _con = @"Data Source=LOVELYPOPPY\THUNHAT;Initial Catalog=FastFoodDB;Integrated Security=True;";
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
                if (string.IsNullOrWhiteSpace(txt_NameStaff.Text) || !IsValidName(txt_NameStaff.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_CCCD.Text) || !IsValidCCCD(txt_CCCD.Text))
                {
                    MessageBox.Show("Vui lòng nhập số CCCD hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtp_Birthday.Value >= dtp_SignUpDay.Value)
                {
                    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày đăng kí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!rdo_Male.Checked && !rdo_Female.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!rdo_StillWorking.Checked && !rdo_Leave.Checked)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_Gmail.Text) || !IsValidEmail(txt_Gmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ Gmail hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_PhoneNumber.Text) || !IsValidPhoneNumber(txt_PhoneNumber.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var db = new DataClasses1DataContext(_con))
                {
                    NHAN_VIEN newEmployee = new NHAN_VIEN
                    {
                        MaNhanVien = txt_IDStaff.Text,
                        TenNhanVien = txt_NameStaff.Text,
                        CCCD = txt_CCCD.Text,
                        MaBoPhan = txt_IDDepartment.Text,
                        MaVaiTro = txt_IDRole.Text,
                        NgaySinh = dtp_Birthday.Value,
                        GioiTinh = rdo_Male.Checked,
                        SDT = txt_PhoneNumber.Text,
                        NgayDangKi = dtp_SignUpDay.Value,
                        Gmail = txt_Gmail.Text,
                        TrangThai = rdo_StillWorking.Checked
                    };
                    db.NHAN_VIENs.InsertOnSubmit(newEmployee);
                    db.SubmitChanges();
                    MessageBox.Show("Nhân viên đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_dgv_manager();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhân viên thất bại!Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_NameStaff.Text) || !IsValidName(txt_NameStaff.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_CCCD.Text) || !IsValidCCCD(txt_CCCD.Text))
                {
                    MessageBox.Show("Vui lòng nhập số CCCD hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtp_Birthday.Value >= dtp_SignUpDay.Value)
                {
                    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày đăng kí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!rdo_Male.Checked && !rdo_Female.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!rdo_StillWorking.Checked && !rdo_Leave.Checked)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_Gmail.Text) || !IsValidEmail(txt_Gmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ Gmail hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_PhoneNumber.Text) || !IsValidPhoneNumber(txt_PhoneNumber.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new DataClasses1DataContext(_con))
                {
                    var query = from nv in db.NHAN_VIENs
                                where nv.MaNhanVien == txt_IDStaff.Text
                                select nv;
                    NHAN_VIEN nvToUpdate = query.SingleOrDefault();

                    if (nvToUpdate != null)
                    {
                        nvToUpdate.TenNhanVien = txt_NameStaff.Text;
                        nvToUpdate.CCCD = txt_CCCD.Text;
                        nvToUpdate.MaBoPhan = txt_IDDepartment.Text;
                        nvToUpdate.MaVaiTro = txt_IDRole.Text;
                        nvToUpdate.NgaySinh = dtp_Birthday.Value;
                        nvToUpdate.GioiTinh = rdo_Male.Checked;
                        nvToUpdate.SDT = txt_PhoneNumber.Text;
                        nvToUpdate.NgayDangKi = dtp_SignUpDay.Value;
                        nvToUpdate.Gmail = txt_Gmail.Text;
                        nvToUpdate.TrangThai = rdo_StillWorking.Checked;
                        db.SubmitChanges();
                        Load_dgv_manager();
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_staff.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var db = new DataClasses1DataContext(_con))
                    {
                        var query = from nv in db.NHAN_VIENs
                                    where nv.MaNhanVien == txt_IDStaff.Text
                                    select nv;
                        NHAN_VIEN employeeToDelete = query.SingleOrDefault();
                        if (employeeToDelete != null)
                        {
                            db.NHAN_VIENs.DeleteOnSubmit(employeeToDelete);
                            db.SubmitChanges();
                            Load_dgv_manager();
                            MessageBox.Show("Nhân viên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
