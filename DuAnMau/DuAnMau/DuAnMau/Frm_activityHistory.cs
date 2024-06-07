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
            dtp_start.Value = DateTime.Now;
            dtp_end.Value = DateTime.Now;

            // Đăng ký sự kiện
            cbo_shift.SelectedIndexChanged += FilterChanged;
            cbo_counter.SelectedIndexChanged += FilterChanged;
            cbo_status.SelectedIndexChanged += FilterChanged;
            dtp_start.ValueChanged += FilterChanged;
            dtp_end.ValueChanged += FilterChanged;

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

        private void FilterChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            string selectedShift = cbo_shift.SelectedItem?.ToString();
            string selectedCounter = cbo_counter.SelectedItem?.ToString();
            string selectedStatus = cbo_status.SelectedItem?.ToString();
            DateTime startDate = dtp_start.Value.Date;
            DateTime endDate = dtp_end.Value.Date.AddDays(1).AddSeconds(-1); // Get data until the end of endDate

            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var query = from nv in db.NHAN_VIENs
                            join nvc in db.NHANVIEN_CAKIPs on nv.MaNhanVien equals nvc.MaNhanVien
                            join ck in db.CAKIPs on nvc.MaCaKip equals ck.MaCaKip
                            where (string.IsNullOrEmpty(selectedShift) || ck.MaCaKip == selectedShift)
                               && (string.IsNullOrEmpty(selectedCounter) || nvc.Quay == selectedCounter)
                               && (string.IsNullOrEmpty(selectedStatus) ||
                                   (selectedStatus == "Present" && nvc.TrangThai.HasValue && nvc.TrangThai.Value) ||
                                   (selectedStatus == "Absent" && nvc.TrangThai.HasValue && !nvc.TrangThai.Value))
                               && (nvc.NgayLam >= startDate && nvc.NgayLam <= endDate)
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
                    string status = item.TrangThai.HasValue && item.TrangThai.Value ? "Present" : "Absent";
                    dt.Rows.Add(item.MaCaKip, item.GioBatDau, item.GioKetThuc, item.MaNhanVien, item.TenNhanVien, item.Quay, item.NgayLam, status);
                }

                dgv_LichSu.DataSource = dt;
                
            }
        }




    }
}
