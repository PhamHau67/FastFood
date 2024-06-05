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

using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using DuAnMau;

namespace EmployeeManagement
{
    public partial class Frm_EmployeeManager : Form
    {

        private Cl_conn clConn = new Cl_conn();
        public Frm_employeeManager()
        {
            InitializeComponent();
            Load_dgv_manager();
            dgv_staff.RowHeadersVisible = false;
        }

        public void Load_dgv_manager()
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var query = from nv in db.NHAN_VIENs
                            select nv;
                DataTable dt = new DataTable();
                dt.Columns.Add("Employee ID");
                dt.Columns.Add("Employee Name");
                dt.Columns.Add("Identification Number");
                dt.Columns.Add("Department ID");
                dt.Columns.Add("Role ID");
                dt.Columns.Add("Date of Birth");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Phone Number");
                dt.Columns.Add("Registration Date");
                dt.Columns.Add("Email");
                dt.Columns.Add("Status");
                foreach (var item in query)
                {
                    string status = (bool)item.TrangThai ? "Working" : "Stopped";
                    string gender = (bool)item.GioiTinh ? "Male" : "Female";
                    dt.Rows.Add(item.MaNhanVien, item.TenNhanVien, item.CCCD, item.MaBoPhan, item.MaVaiTro, item.NgaySinh, gender, item.SDT, item.NgayDangKi, item.Gmail, status);
                }
                dgv_staff.DataSource = dt;
            }
        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_staff.Rows[e.RowIndex];
                txt_IDStaff.Text = row.Cells["Employee ID"].Value.ToString();
                txt_NameStaff.Text = row.Cells["Employee Name"].Value.ToString();
                txt_CCCD.Text = row.Cells["Identification Number"].Value.ToString();
                txt_IDDepartment.Text = row.Cells["Department ID"].Value.ToString();
                txt_IDRole.Text = row.Cells["Role ID"].Value.ToString();
                dtp_Birthday.Value = DateTime.Parse(row.Cells["Date of Birth"].Value.ToString());
                string gender = row.Cells["Gender"].Value.ToString();
                if (gender == "Male")
                {
                    rdo_Male.Checked = true;
                }
                else
                {
                    rdo_Female.Checked = true;
                }
                txt_PhoneNumber.Text = row.Cells["Phone Number"].Value.ToString();
                dtp_SignUpDay.Value = DateTime.Parse(row.Cells["Registration Date"].Value.ToString());
                txt_Gmail.Text = row.Cells["Email"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();
                if (status == "Working")
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
                if (!ValidateFields())
                    return;
                using (var db = new DataClasses1DataContext(clConn.conn))
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
                    MessageBox.Show("Employee added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_dgv_manager();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add employee! Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;
                using (var db = new DataClasses1DataContext(clConn.conn))
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
                        MessageBox.Show("Employee updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_IDStaff.Text))
                {
                    MessageBox.Show("Please select an employee to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var db = new DataClasses1DataContext(clConn.conn))
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
                            MessageBox.Show("Employee deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            using (var db = new DataClasses1DataContext(clConn.conn))
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
                                 GioiTinh = (bool)nv.GioiTinh ? "Male" : "Female",
                                 nv.SDT,
                                 nv.NgayDangKi,
                                 nv.Gmail,
                                 TrangThai = nv.TrangThai ? "Working" : "Stopped",
                             };
                dgv_staff.DataSource = findnv.ToList();
            }
        }

        private bool ValidateEmployeeID(string id)
        {
            Regex regex = new Regex(@"^NV\d{3}$");
            return regex.IsMatch(id);
        }

        private bool ValidateDepartmentID(string id)
        {
            Regex regex = new Regex(@"^BP\d{3}$");
            return regex.IsMatch(id);
        }

        private bool ValidateRoleID(string id)
        {
            Regex regex = new Regex(@"^VT\d{3}$");
            return regex.IsMatch(id);
        }

        private bool ValidateCCCD(string cccd)
        {
            if (cccd.Any(char.IsLetter) || Convert.ToInt32(cccd) < 0)
                return false;
            return true;
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Any(char.IsLetter) || Convert.ToInt64(phoneNumber) < 0)
                return false;
            return true;
        }

        private bool ValidateEmail(string email)
        {
            if (!email.EndsWith("@gmail.com"))
                return false;
            return true;
        }

        private bool ValidateGenderAndStatus()
        {
            return (rdo_Male.Checked || rdo_Female.Checked) && (rdo_StillWorking.Checked || rdo_Leave.Checked);
        }

        private bool ValidateDateOfBirthAndSignUpDate(DateTime dateOfBirth, DateTime signUpDate)
        {
            return dateOfBirth <= signUpDate;
        }

        private bool ValidateName(string name)
        {
            Regex regex = new Regex(@"\d");
            return !regex.IsMatch(name);
        }

        private bool ValidateFields()
        {
            if (!ValidateName(txt_NameStaff.Text))
            {
                MessageBox.Show("Employee name cannot contain numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateEmployeeID(txt_IDStaff.Text))
            {
                MessageBox.Show("Invalid employee ID format (NVxxx)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateDepartmentID(txt_IDDepartment.Text))
            {
                MessageBox.Show("Invalid department ID format (BPxxx)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateRoleID(txt_IDRole.Text))
            {
                MessageBox.Show("Invalid role ID format (VTxxx)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateCCCD(txt_CCCD.Text))
            {
                MessageBox.Show("Identification number cannot contain letters or negative numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidatePhoneNumber(txt_PhoneNumber.Text))
            {
                MessageBox.Show("Phone number cannot contain letters or negative numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateEmail(txt_Gmail.Text))
            {
                MessageBox.Show("Invalid email format! Must end with '@gmail.com'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateGenderAndStatus())
            {
                MessageBox.Show("Gender or status cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateDateOfBirthAndSignUpDate(dtp_Birthday.Value, dtp_SignUpDay.Value))
            {
                MessageBox.Show("Date of birth cannot be after the registration date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        
    }
}
