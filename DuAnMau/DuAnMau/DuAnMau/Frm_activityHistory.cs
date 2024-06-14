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
using System.Windows.Controls;

namespace DuAnMau
{
    public partial class Frm_activityHistory : Form
    {
        private Cl_conn clConn = new Cl_conn();
        public Frm_activityHistory()
        {
            InitializeComponent();
            Load_dgv_activity();
            InitializeComboBoxes();
            InitializeEditComboBoxes();
            dgv_LichSu.RowHeadersVisible = false;
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.CustomFormat = "dd/MM/yyyy";
            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.CustomFormat = "dd/MM/yyyy";
            dtp_dateWork.Format = DateTimePickerFormat.Custom;
            dtp_dateWork.CustomFormat = "dd/MM/yyyy";

        }

        private void InitializeComboBoxes()
        {
            cbo_shift.SelectedIndexChanged += new EventHandler(FilterChanged);
            cbo_counter.SelectedIndexChanged += new EventHandler(FilterChanged);
            cbo_status.SelectedIndexChanged += new EventHandler(FilterChanged);
            load_cbo_counter();
            load_cbo_shift();
            load_cbo_status();
            //Refesh
            txt_find.Clear();
            cbo_shift.SelectedIndex = -1;
            cbo_counter.SelectedIndex = -1;
            cbo_status.SelectedIndex = -1;
            dtp_start.Value = DateTime.Now;
            dtp_end.Value = DateTime.Now;
            FilterData();
            Load_dgv_activity();
        }

        private void InitializeEditComboBoxes()
        {
            load_cbo_IDShift_edit();
            //load_cbo_counter_edit();
            load_cbo_IDStaff_edit();
        }

        public void load_cbo_counter()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var quay = (from nvc in db.NHANVIEN_CAKIPs
                                select nvc.Quay).Distinct().ToList();

                    cbo_counter.Items.Clear();
                    cbo_counter.Items.AddRange(quay.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }

        public void load_cbo_shift()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var ck = (from nvc in db.NHANVIEN_CAKIPs
                              select nvc.MaCaKip).Distinct().ToList();

                    cbo_shift.Items.Clear();
                    cbo_shift.Items.AddRange(ck.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }

        public void load_cbo_status()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var trangThai = (from nvc in db.NHANVIEN_CAKIPs
                                     select nvc.TrangThai).Distinct().ToList();

                    cbo_status.Items.Clear();
                    foreach (var status in trangThai)
                    {
                        if ((bool)status)
                        {
                            cbo_status.Items.Add("Present");
                        }
                        else
                        {
                            cbo_status.Items.Add("Absent");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }

        public void load_cbo_IDShift_edit()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var shifts = (from ck in db.CAKIPs
                                  select ck.MaCaKip).Distinct().ToList();

                    cbo_IDShift_edit.Items.Clear();
                    cbo_IDShift_edit.Items.AddRange(shifts.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }

        public void load_cbo_counter_edit()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var counters = (from nvc in db.NHANVIEN_CAKIPs
                                    select nvc.Quay).Distinct().ToList();

                    cbo_counter.Items.Clear();
                    cbo_counter.Items.AddRange(counters.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }

        public void load_cbo_IDStaff_edit()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var staff = (from nv in db.NHAN_VIENs
                                 select nv.MaNhanVien).Distinct().ToList();

                    cbo_IDStaff_edit.Items.Clear();
                    cbo_IDStaff_edit.Items.AddRange(staff.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }


        public void Load_dgv_activity()
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var query = from nv in db.NHAN_VIENs
                            join nvc in db.NHANVIEN_CAKIPs on nv.MaNhanVien equals nvc.MaNhanVien
                            join ck in db.CAKIPs on nvc.MaCaKip equals ck.MaCaKip
                            select new
                            {
                                nvc.MaCaKip,
                                ck.GioBatDau,
                                ck.GioKetThuc,
                                nvc.MaNhanVien,
                                nv.TenNhanVien,
                                nvc.Quay,
                                nvc.NgayLam,
                                nvc.TrangThai
                            };

                DataTable dt = new DataTable();
                dt.Columns.Add("ShiftCode");
                dt.Columns.Add("StartTime");
                dt.Columns.Add("EndTime");
                dt.Columns.Add("EmployeeID");
                dt.Columns.Add("EmployeeName");
                dt.Columns.Add("Counter");
                dt.Columns.Add("WorkDate");
                dt.Columns.Add("Status");

                foreach (var item in query)
                {
                    string status = (bool)item.TrangThai ? "Present" : "Absent";
                    string workDate = item.NgayLam.ToString("dd/MM/yyyy");
                    dt.Rows.Add(item.MaCaKip, item.GioBatDau, item.GioKetThuc, item.MaNhanVien, item.TenNhanVien, item.Quay, workDate, status);
                }

                dgv_LichSu.DataSource = dt;
            }
        }
        private void FilterChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var keyword = txt_find.Text.Trim();
                var shiftFilter = cbo_shift.SelectedItem?.ToString();
                var counterFilter = cbo_counter.SelectedItem?.ToString();
                var statusFilter = cbo_status.SelectedItem?.ToString();

                bool isDateFilterUsed = dtp_start.Value.Date != DateTime.Now.Date || dtp_end.Value.Date != DateTime.Now.Date;

                var startDateFilter = dtp_start.Value.Date;
                var endDateFilter = dtp_end.Value.Date.AddDays(1).AddSeconds(-1);

                var findnv = from nv in db.NHAN_VIENs
                             join nvc in db.NHANVIEN_CAKIPs on nv.MaNhanVien equals nvc.MaNhanVien
                             join ck in db.CAKIPs on nvc.MaCaKip equals ck.MaCaKip
                             where (string.IsNullOrEmpty(keyword) || nv.MaNhanVien.Contains(keyword) || ck.MaCaKip.Contains(keyword) || nv.TenNhanVien.Contains(keyword) || nvc.Quay.Contains(keyword) || nvc.NgayLam.ToString().Contains(keyword))
                                && (string.IsNullOrEmpty(shiftFilter) || nvc.MaCaKip == shiftFilter)
                                && (string.IsNullOrEmpty(counterFilter) || nvc.Quay == counterFilter)
                                && (string.IsNullOrEmpty(statusFilter) || (statusFilter == "Present" && nvc.TrangThai == true) || (statusFilter == "Absent" && nvc.TrangThai == false))
                                && (!isDateFilterUsed || (nvc.NgayLam >= startDateFilter && nvc.NgayLam <= endDateFilter)) // Áp dụng bộ lọc ngày tháng nếu cần
                             select new
                             {
                                 ck.MaCaKip,
                                 ck.GioBatDau,
                                 ck.GioKetThuc,
                                 nv.MaNhanVien,
                                 nv.TenNhanVien,
                                 nvc.Quay,
                                 nvc.NgayLam,
                                 TrangThai = (bool)nvc.TrangThai ? "Present" : "Absent",
                             };

                DataTable dt = new DataTable();
                dt.Columns.Add("ShiftCode");
                dt.Columns.Add("StartTime");
                dt.Columns.Add("EndTime");
                dt.Columns.Add("EmployeeID");
                dt.Columns.Add("EmployeeName");
                dt.Columns.Add("Counter");
                dt.Columns.Add("WorkDate");
                dt.Columns.Add("Status");

                foreach (var item in findnv)
                {
                    string workDate = isDateFilterUsed ? item.NgayLam.ToString("dd/MM/yyyy") : item.NgayLam.ToShortDateString(); // Định dạng ngày nếu sử dụng bộ lọc
                    dt.Rows.Add(item.MaCaKip, item.GioBatDau, item.GioKetThuc, item.MaNhanVien, item.TenNhanVien, item.Quay, workDate, item.TrangThai);
                }

                dgv_LichSu.DataSource = dt;
            }
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            txt_find.Clear();
            cbo_shift.SelectedIndex = -1;
            cbo_counter.SelectedIndex = -1;
            cbo_status.SelectedIndex = -1;
            cbo_IDShift_edit.SelectedIndex = -1;
            cbo_counter_edit.SelectedIndex = -1;
            cbo_IDStaff_edit.SelectedIndex = -1;
            dtp_start.Value = DateTime.Now;
            dtp_end.Value = DateTime.Now;
            dtp_dateWork.Value = DateTime.Now;
            chk_status.Checked = false;
            FilterData();
            Load_dgv_activity();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if (dgv_LichSu.Rows.Count > 0)
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
                        for (int i = 1; i < dgv_LichSu.Columns.Count + 1; i++)
                        {
                            worksheet.Cells[1, i] = dgv_LichSu.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < dgv_LichSu.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv_LichSu.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgv_LichSu.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
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



        private void btn_add_Click(object sender, EventArgs e)
        {
            DateTime ngayLam = dtp_dateWork.Value;
            bool trangThai = chk_status.Checked;

            // Thực hiện thêm dữ liệu vào cơ sở dữ liệu
            try
            {
                // Get selected values from ComboBoxes and DateTimePicker
                string shiftCode = cbo_IDShift_edit.SelectedItem?.ToString();
                string counter = cbo_counter_edit.Text.ToString();
                string employeeID = cbo_IDStaff_edit.SelectedItem?.ToString();
                DateTime workDate = dtp_dateWork.Value;
                bool status = chk_status.Checked;

                // Validate inputs (ensure required fields are filled)

                if (string.IsNullOrEmpty(shiftCode) || string.IsNullOrEmpty(counter) || string.IsNullOrEmpty(employeeID))
                {
                    MessageBox.Show("Please fill in all required fields (Shift, Counter, Employee ID).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert into database using LINQ to SQL
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    // Create a new NHANVIEN_CAKIP object and assign values
                    NHANVIEN_CAKIP newRecord = new NHANVIEN_CAKIP
                    {
                        MaCaKip = shiftCode,
                        Quay = counter,
                        MaNhanVien = employeeID,
                        NgayLam = workDate,
                        TrangThai = status
                    };

                    // Add to DataContext and submit changes to database
                    db.NHANVIEN_CAKIPs.InsertOnSubmit(newRecord);
                    db.SubmitChanges();

                    MessageBox.Show("New record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView and clear input fields
                    Load_dgv_activity(); // Assuming this method reloads the DataGridView
                    ClearAddFields(); // Custom method to clear input fields
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAddFields()
        {
            cbo_IDShift_edit.SelectedIndex = -1;
            cbo_counter_edit.Text = "";
            cbo_IDStaff_edit.SelectedIndex = -1;
            dtp_dateWork.Value = DateTime.Now;
            chk_status.Checked = false;
        }


        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void dgv_LichSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_LichSu.Rows[e.RowIndex];

                // Lấy giá trị của từng ô trong hàng được chọn
                string shiftCode = row.Cells["ShiftCode"].Value?.ToString();
                string counter = row.Cells["Counter"].Value?.ToString();
                string employeeID = row.Cells["EmployeeID"].Value?.ToString();
                DateTime workDate = Convert.ToDateTime(row.Cells["WorkDate"].Value);

                // Xử lý giá trị của cột Status và checkbox chk_status tương ứng
                string status = row.Cells["Status"].Value?.ToString();
                if (status != null)
                {
                    if (status.Equals("Present", StringComparison.OrdinalIgnoreCase))
                    {
                        chk_status.Checked = true;
                    }
                    else if (status.Equals("Absent", StringComparison.OrdinalIgnoreCase))
                    {
                        chk_status.Checked = false;
                    }
                }
                else
                {
                    chk_status.Checked = false; // Xử lý trường hợp giá trị null nếu cần
                }

                // Đặt các giá trị lấy được vào các ComboBox và DateTimePicker
                cbo_IDShift_edit.SelectedItem = shiftCode;
                cbo_counter_edit.Text = counter;
                cbo_IDStaff_edit.SelectedItem = employeeID;
                dtp_dateWork.Value = workDate;
            }
        }
    }
}
