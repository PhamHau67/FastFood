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
using ClosedXML.Excel;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace DuAnMau
{
    public partial class Frm_employeeManager : Form
    {
        
        private string _con = "Data Source=DESKTOP-R9SVLJT\\HUNG;Initial Catalog=FastFoodDB;Integrated Security=True;";
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
                string gioiTinh = row.Cells["Giới tính"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rdo_Male.Checked = true;
                }
                else
                {
                    rdo_Female.Checked = true;
                }
                txt_PhoneNumber.Text = row.Cells["Số điện thoại"].Value.ToString();
                dtp_SignUpDay.Value = DateTime.Parse(row.Cells["Ngày đăng kí"].Value.ToString());
                txt_Gmail.Text = row.Cells["Gmail"].Value.ToString();
                string trangThai = row.Cells["Trạng thái"].Value.ToString();
                if (trangThai == "Đang đi làm")
                {
                    rdo_StillWorking.Checked = true;
                }
                else
                {
                    rdo_Leave.Checked = true;
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                
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
                if (string.IsNullOrWhiteSpace(txt_IDStaff.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng việc xóa nếu chưa chọn nhân viên
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_IDStaff.Clear();
            txt_NameStaff.Clear();
            txt_CCCD.Clear();
            txt_IDDepartment.Clear();
            txt_IDRole.Clear();
            dtp_Birthday.Value = DateTime.Now;
            rdo_Male.Checked = false;
            rdo_Female.Checked = false;
            txt_PhoneNumber.Clear();
            dtp_SignUpDay.Value = DateTime.Now;
            txt_Gmail.Clear();
            rdo_StillWorking.Checked = false;
            rdo_Leave.Checked = false;

            Load_dgv_manager();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (dgv_staff.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                    Title = "Save an Excel File"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application excel = null;
                    Excel.Workbook workbook = null;
                    Excel.Worksheet worksheet = null;

                    try
                    {
                        excel = new Excel.Application();
                        workbook = excel.Workbooks.Add(Type.Missing);
                        worksheet = (Excel.Worksheet)workbook.Sheets[1];
                        for (int i = 1; i < dgv_staff.Columns.Count + 1; i++)
                        {
                            worksheet.Cells[1, i] = dgv_staff.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < dgv_staff.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv_staff.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgv_staff.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                            }
                        }
                        worksheet.Columns.AutoFit();
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                        if (workbook != null) Marshal.ReleaseComObject(workbook);
                        if (excel != null) Marshal.ReleaseComObject(excel);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data to export!");
            }
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext(_con))
            {
                var keyword = txt_Find.Text.Trim();
                var findnv = from nv in db.NHAN_VIENs
                            where nv.MaNhanVien.Contains(keyword) || nv.TenNhanVien.Contains(keyword) || nv.MaVaiTro.Contains(keyword) || nv.MaBoPhan.Contains(keyword)
                            select new
                            {
                                nv.MaNhanVien,
                                nv.TenNhanVien,
                                nv.CCCD,
                                nv.MaBoPhan,
                                nv.MaVaiTro,
                                nv.NgaySinh,
                                GioiTinh = (bool)nv.GioiTinh ? "Nam" : "Nữ",
                                nv.SDT,
                                nv.NgayDangKi,
                                nv.Gmail,
                                TrangThai = nv.TrangThai ? "Đang còn" : "Đã hết",
                            };
                dgv_staff.DataSource = findnv.ToList();
            }
        }
    }
}
