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
//using ClosedXML.Excel;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using DuAnMau;

namespace EmployeeManagement
{
    public partial class Frm_activityHistory : Form
    {
        private Cl_conn clConn = new Cl_conn();
        public Frm_activityHistory()
        {
            InitializeComponent();
            Load_dgv_activity();
            dgv_LichSu.RowHeadersVisible = false;
            cbo_counter.Items.Add("A1");
            cbo_counter.Items.Add("B2");
            cbo_shift.Items.Add("CK001");
            cbo_shift.Items.Add("CK002");
            cbo_shift.Items.Add("CK003");
            cbo_shift.Items.Add("CK004");
            cbo_shift.Items.Add("CK005");
            cbo_status.Items.Add("Present");
            cbo_status.Items.Add("Absent");

            cbo_shift.SelectedIndexChanged += new EventHandler(FilterChanged);
            cbo_counter.SelectedIndexChanged += new EventHandler(FilterChanged);
            cbo_status.SelectedIndexChanged += new EventHandler(FilterChanged);
            dtp_start.ValueChanged += new EventHandler(FilterChanged);
            dtp_end.ValueChanged += new EventHandler(FilterChanged);
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
                    dt.Rows.Add(item.MaCaKip, item.GioBatDau, item.GioKetThuc, item.MaNhanVien, item.TenNhanVien, item.Quay, item.NgayLam, status);
                }

                dgv_LichSu.DataSource = dt;
            }
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            DateTime startDate = dtp_start.Value.Date;
            DateTime endDate = dtp_end.Value.Date.AddDays(1).AddTicks(-1);

            using (var db = new DataClasses1DataContext(_con))
            {
                var keyword = txt_find.Text.Trim();
                var shiftFilter = cbo_shift.SelectedItem?.ToString();
                var counterFilter = cbo_counter.SelectedItem?.ToString();
                var statusFilter = cbo_status.SelectedItem?.ToString();

                var findnv = from nv in db.NHAN_VIENs
                             join nvc in db.NHANVIEN_CAKIPs on nv.MaNhanVien equals nvc.MaNhanVien
                             join ck in db.CAKIPs on nvc.MaCaKip equals ck.MaCaKip
                             where (string.IsNullOrEmpty(keyword) || nv.MaNhanVien.Contains(keyword) || ck.MaCaKip.Contains(keyword) || nv.TenNhanVien.Contains(keyword) || nvc.Quay.Contains(keyword) || nvc.NgayLam.ToString().Contains(keyword))
                                && (string.IsNullOrEmpty(shiftFilter) || nvc.MaCaKip == shiftFilter)
                                && (string.IsNullOrEmpty(counterFilter) || nvc.Quay == counterFilter)
                                && (string.IsNullOrEmpty(statusFilter) || (statusFilter == "Present" && nvc.TrangThai == true) || (statusFilter == "Absent" && nvc.TrangThai == false))
                                && nvc.NgayLam >= startDate && nvc.NgayLam <= endDate
                             select new
                             {
                                 ck.MaCaKip,
                                 ck.GioBatDau,
                                 ck.GioKetThuc,
                                 nv.MaNhanVien,
                                 nv.TenNhanVien,
                                 nvc.Quay,
                                 nvc.NgayLam,
                                 Status = (bool)nvc.TrangThai ? "Present" : "Absent",
                             };

                // Create DataTable from the query result
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
                    DataRow row = dt.NewRow();
                    row["ShiftCode"] = item.MaCaKip;
                    row["StartTime"] = item.GioBatDau;
                    row["EndTime"] = item.GioKetThuc;
                    row["EmployeeID"] = item.MaNhanVien;
                    row["EmployeeName"] = item.TenNhanVien;
                    row["Counter"] = item.Quay;
                    row["WorkDate"] = item.NgayLam.ToString("dd/MM/yyyy");
                    row["Status"] = item.Status;
                    dt.Rows.Add(row);
                }

                // Bind DataTable to DataGridView
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
