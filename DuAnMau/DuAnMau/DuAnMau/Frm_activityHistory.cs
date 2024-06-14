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
            dgv_LichSu.RowHeadersVisible = false;
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.CustomFormat = "dd/MM/yyyy";
            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.CustomFormat = "dd/MM/yyyy";

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
            dtp_start.Value = DateTime.Now;
            dtp_end.Value = DateTime.Now;
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

        

        

        
    }
}
