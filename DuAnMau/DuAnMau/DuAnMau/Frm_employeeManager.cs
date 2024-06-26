﻿using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DuAnMau;
using ClosedXML;
using Excel = Microsoft.Office.Interop.Excel;
using Guna.UI2.WinForms;

namespace employeeManagement
{
    public partial class Frm_employeeManager : Form
    {
        private Cl_conn clConn = new Cl_conn();

        public Frm_employeeManager()
        {
            InitializeComponent();
            InitializeComboBoxes();
            LoadDataGridView();
            dgv_staff.RowHeadersVisible = false;

            dtp_Birthday.Format = DateTimePickerFormat.Custom;
            dtp_Birthday.CustomFormat = "dd/MM/yyyy";
            dtp_SignUpDay.Format = DateTimePickerFormat.Custom;
            dtp_SignUpDay.CustomFormat = "dd/MM/yyyy";
        }

        private void InitializeComboBoxes()
        {
            load_cbo_department();
            load_cbo_role();
        }
        public void load_cbo_department()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var tenBoPhan = (from bp in db.BOPHANs
                                  select bp.TenBoPhan).Distinct().ToList();

                    cbo_department.Items.Clear();
                    cbo_department.Items.AddRange(tenBoPhan.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }
        public void load_cbo_role()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var tenVaiTro = (from vt in db.VAITROs
                                     select vt.TenVaiTro).Distinct().ToList();

                    cbo_role.Items.Clear();
                    cbo_role.Items.AddRange(tenVaiTro.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }
        private void LoadDataGridView()
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var query = from nv in db.NHAN_VIENs
                            join bp in db.BOPHANs on nv.MaBoPhan equals bp.MaBoPhan
                            join vt in db.VAITROs on nv.MaVaiTro equals vt.MaVaiTro
                            select new
                            {
                                nv.MaNhanVien,
                                nv.TenNhanVien,
                                nv.CCCD,
                                bp.TenBoPhan,
                                vt.TenVaiTro,
                                nv.NgaySinh,
                                GioiTinh = (bool)nv.GioiTinh ? "Nam" : "Nữ",
                                nv.SDT,
                                nv.NgayDangKi,
                                nv.Gmail,
                                TrangThai = nv.TrangThai ? "Working" : "Stopped"
                            };

                DataTable dt = new DataTable();
                dt.Columns.Add("Employee ID");
                dt.Columns.Add("Employee Name");
                dt.Columns.Add("Identification Number");
                dt.Columns.Add("Department");
                dt.Columns.Add("Role");
                dt.Columns.Add("Date of Birth");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Phone Number");
                dt.Columns.Add("Registration Date");
                dt.Columns.Add("Email");
                dt.Columns.Add("Status");

                foreach (var item in query)
                {
                    dt.Rows.Add(item.MaNhanVien, item.TenNhanVien, item.CCCD, item.TenBoPhan, item.TenVaiTro, item.NgaySinh, item.GioiTinh, item.SDT, item.NgayDangKi, item.Gmail, item.TrangThai);
                }

                dgv_staff.DataSource = dt;
            }
        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_staff.Rows[e.RowIndex];

                txt_IDStaff.Text = row.Cells["Employee ID"].Value.ToString().Trim();
                txt_NameStaff.Text = row.Cells["Employee Name"].Value.ToString().Trim();
                txt_CCCD.Text = row.Cells["Identification Number"].Value.ToString().Trim();
                cbo_department.SelectedItem = row.Cells["Department"].Value.ToString();
                cbo_role.SelectedItem = row.Cells["Role"].Value.ToString();

                dtp_Birthday.Value = Convert.ToDateTime(row.Cells["Date of Birth"].Value);

                string gender = row.Cells["Gender"].Value.ToString();
                if (gender == "Nam")
                {
                    rdo_Male.Checked = true;
                }
                else
                {
                    rdo_Female.Checked = true;
                }

                txt_PhoneNumber.Text = row.Cells["Phone Number"].Value.ToString().Trim();
                dtp_SignUpDay.Value = Convert.ToDateTime(row.Cells["Registration Date"].Value);
                txt_Gmail.Text = row.Cells["Email"].Value.ToString().Trim();

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

                if (IsGmailDuplicate(txt_Gmail.Text.Trim()))
                {
                    MessageBox.Show("Gmail already exists! please enter another gmail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsPhoneNumberDuplicate(txt_PhoneNumber.Text.Trim()))
                {
                    MessageBox.Show("Phone number already exists! Please enter another phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    // Retrieve MaBoPhan and MaVaiTro from TenBoPhan and TenVaiTro
                    var selectedDepartment = cbo_department.SelectedItem.ToString();
                    var selectedRole = cbo_role.SelectedItem.ToString();

                    var maBoPhan = db.BOPHANs.Where(bp => bp.TenBoPhan == selectedDepartment)
                                              .Select(bp => bp.MaBoPhan)
                                              .FirstOrDefault();
                    var maVaiTro = db.VAITROs.Where(vt => vt.TenVaiTro == selectedRole)
                                             .Select(vt => vt.MaVaiTro)
                                             .FirstOrDefault();

                    NHAN_VIEN newEmployee = new NHAN_VIEN
                    {
                        MaNhanVien = txt_IDStaff.Text,
                        TenNhanVien = txt_NameStaff.Text,
                        CCCD = txt_CCCD.Text,
                        MaBoPhan = maBoPhan,
                        MaVaiTro = maVaiTro,
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
                    LoadDataGridView();
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
                        var selectedDepartment = cbo_department.SelectedItem.ToString();
                        var selectedRole = cbo_role.SelectedItem.ToString();

                        var maBoPhan = db.BOPHANs.Where(bp => bp.TenBoPhan == selectedDepartment)
                                                  .Select(bp => bp.MaBoPhan)
                                                  .FirstOrDefault();
                        var maVaiTro = db.VAITROs.Where(vt => vt.TenVaiTro == selectedRole)
                                                 .Select(vt => vt.MaVaiTro)
                                                 .FirstOrDefault();

                        nvToUpdate.TenNhanVien = txt_NameStaff.Text;
                        nvToUpdate.CCCD = txt_CCCD.Text;
                        nvToUpdate.MaBoPhan = maBoPhan;
                        nvToUpdate.MaVaiTro = maVaiTro;
                        nvToUpdate.NgaySinh = dtp_Birthday.Value;
                        nvToUpdate.GioiTinh = rdo_Male.Checked;
                        nvToUpdate.SDT = txt_PhoneNumber.Text;
                        nvToUpdate.NgayDangKi = dtp_SignUpDay.Value;
                        nvToUpdate.Gmail = txt_Gmail.Text;
                        nvToUpdate.TrangThai = rdo_StillWorking.Checked;

                        db.SubmitChanges();
                        LoadDataGridView();
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

                if (HasAccount(txt_IDStaff.Text))
                {
                    MessageBox.Show("The employee's account must be deleted before deleting the employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            LoadDataGridView();
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
            ClearFields();
            LoadDataGridView();
        }

        private void ClearFields()
        {
            txt_IDStaff.Clear();
            txt_NameStaff.Clear();
            txt_CCCD.Clear();
            cbo_department.SelectedIndex = -1;
            cbo_role.SelectedIndex = -1;
            dtp_Birthday.Value = DateTime.Now;
            rdo_Male.Checked = false;
            rdo_Female.Checked = false;
            txt_PhoneNumber.Clear();
            dtp_SignUpDay.Value = DateTime.Now;
            txt_Gmail.Clear();
            rdo_StillWorking.Checked = false;
            rdo_Leave.Checked = false;
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
                string keyword = txt_Find.Text.Trim();

                var findnv = from nv in db.NHAN_VIENs
                             where nv.MaNhanVien.Contains(keyword) ||
                                   nv.TenNhanVien.Contains(keyword) ||
                                   nv.MaVaiTro.Contains(keyword) ||
                                   nv.MaBoPhan.Contains(keyword)
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
                                 TrangThai = nv.TrangThai ? "Working" : "Stopped"
                             };

                dgv_staff.DataSource = findnv.ToList();
            }
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

        private bool IsGmailDuplicate(string gmail, string employeeId = null)
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var query = db.NHAN_VIENs.AsQueryable();
                if (!string.IsNullOrEmpty(employeeId))
                {
                    query = query.Where(nv => nv.MaNhanVien != employeeId);
                }

                return query.Any(nv => nv.Gmail == gmail);
            }
        }

        private bool IsPhoneNumberDuplicate(string phoneNumber, string employeeId = null)
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var query = db.NHAN_VIENs.AsQueryable();
                if (!string.IsNullOrEmpty(employeeId))
                {
                    query = query.Where(nv => nv.MaNhanVien != employeeId);
                }
                return query.Any(nv => nv.SDT == phoneNumber);
            }
        }

        private bool ValidateName(string name)
        {
            return !Regex.IsMatch(name, @"\d");
        }

        private bool ValidateEmployeeID(string id)
        {
            return Regex.IsMatch(id, @"^NV\d{3}$");
        }

        private bool ValidateCCCD(string cccd)
        {
            return !cccd.Any(char.IsLetter) &&
           long.TryParse(cccd, out long cccdNumber) &&
           cccdNumber > 0 &&
           cccd.Length <= 12;
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Any(char.IsLetter) || !long.TryParse(phoneNumber, out _))
            {
                return false;
            }

            // Kiểm tra độ dài số điện thoại không quá 11 số và không âm
            if (phoneNumber.Length > 11 || phoneNumber.StartsWith("-"))
            {
                return false;
            }

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

        private bool HasAccount(string employeeId)
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                return db.TAI_KHOANs.Any(acc => acc.MaNhanVien == employeeId);
            }
        }


    }
}
