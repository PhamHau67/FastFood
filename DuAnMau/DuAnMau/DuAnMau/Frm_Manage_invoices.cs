using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Collections.Generic;

namespace DuAnMau
{
    public partial class Frm_Manage_invoices : Form
    {
        private string selectedInvoiceID;
        private string selectedEmployeeName;
        private DateTime selectedCreationDate;
        private decimal selectedTotalAmount;
        private List<Tuple<string, int, decimal>> selectedInvoiceDetails;
        private Cl_conn clConn = new Cl_conn();

        public Frm_Manage_invoices()
        {
            InitializeComponent();
            LoadataHoaDon();
            timer1.Start();
            Row_lstv();

            // Add event handlers for DateTimePickers
            dt_start.ValueChanged += DateTimePickers_ValueChanged;
            dt_end.ValueChanged += DateTimePickers_ValueChanged;
        }

        private void LoadataHoaDon()
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var query = from hoadon in db.HOADONs
                            join nhanvien in db.NHAN_VIENs on hoadon.MaNhanVien equals nhanvien.MaNhanVien
                            select new
                            {
                                hoadon.MaHoaDon,
                                nhanvien.TenNhanVien,
                                hoadon.NgayTao,
                                hoadon.TongTien,
                                Status = hoadon.TrangThai.HasValue ? (hoadon.TrangThai.Value ? "Đã thanh toán" : "Chưa thanh toán") : "Chưa thanh toán"
                            };

                DataTable dt = new DataTable();
                dt.Columns.Add("Invoice ID");
                dt.Columns.Add("Employee Name");
                dt.Columns.Add("Creation Date");
                dt.Columns.Add("Total Amount");
                dt.Columns.Add("Status");

                decimal totalAmount = 0;

                foreach (var item in query)
                {
                    DataRow row = dt.NewRow();
                    row["Invoice ID"] = item.MaHoaDon;
                    row["Employee Name"] = item.TenNhanVien;
                    row["Creation Date"] = item.NgayTao.ToString("dd/MM/yyyy");
                    row["Total Amount"] = item.TongTien.ToString("N0");
                    row["Status"] = item.Status;
                    dt.Rows.Add(row);
                }

                dgv_HoaDon.DataSource = dt;
                txt_Summ.Text = totalAmount.ToString("N0");
            }
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (ListViewItem item in lstv_ChiTietHoaDon.Items)
            {
                string priceString = item.SubItems[2].Text;
                if (decimal.TryParse(priceString, out decimal price))
                {
                    totalAmount += price;
                }
            }

            txt_Summ.Text = totalAmount.ToString("N0");
        }

        private void FilterDataByDate()
        {
            DateTime startDate = dt_start.Value.Date;
            DateTime endDate = dt_end.Value.Date.AddDays(1).AddTicks(-1);

            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var query = from hoadon in db.HOADONs
                            join nhanvien in db.NHAN_VIENs on hoadon.MaNhanVien equals nhanvien.MaNhanVien
                            where hoadon.NgayTao >= startDate && hoadon.NgayTao <= endDate
                            select new
                            {
                                hoadon.MaHoaDon,
                                nhanvien.TenNhanVien,
                                hoadon.NgayTao,
                                hoadon.TongTien,
                                Status = hoadon.TrangThai.HasValue ? (hoadon.TrangThai.Value ? "Đã thanh toán" : "Chưa thanh toán") : "Chưa thanh toán"
                            };

                DataTable dt = new DataTable();
                dt.Columns.Add("Invoice ID");
                dt.Columns.Add("Employee Name");
                dt.Columns.Add("Creation Date");
                dt.Columns.Add("Total Amount");
                dt.Columns.Add("Status");

                foreach (var item in query)
                {
                    DataRow row = dt.NewRow();
                    row["Invoice ID"] = item.MaHoaDon;
                    row["Employee Name"] = item.TenNhanVien;
                    row["Creation Date"] = item.NgayTao.ToString("dd/MM/yyyy");
                    row["Total Amount"] = item.TongTien.ToString("N0");
                    row["Status"] = item.Status;
                    dt.Rows.Add(row);
                }

                dgv_HoaDon.DataSource = dt;
            }
        }

        private void DateTimePickers_ValueChanged(object sender, EventArgs e)
        {
            FilterDataByDate();
        }

        public void Row_lstv()
        {
            lstv_ChiTietHoaDon.Columns.Add("Product", 200);
            lstv_ChiTietHoaDon.Columns.Add("Quantity", 90);
            lstv_ChiTietHoaDon.Columns.Add("Price", 90);
            lstv_ChiTietHoaDon.Columns[0].Width = (int)(lstv_ChiTietHoaDon.Width * 0.40);
            lstv_ChiTietHoaDon.Columns[1].Width = (int)(lstv_ChiTietHoaDon.Width * 0.25);
            lstv_ChiTietHoaDon.Columns[2].Width = (int)(lstv_ChiTietHoaDon.Width * 0.25);
            lstv_ChiTietHoaDon.View = View.Details;
            lstv_ChiTietHoaDon.GridLines = true;
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_HoaDon.Rows[e.RowIndex];
                selectedInvoiceID = selectedRow.Cells["Invoice ID"].Value.ToString();
                selectedEmployeeName = selectedRow.Cells["Employee Name"].Value.ToString();
                string status = selectedRow.Cells["Status"].Value.ToString();
                txt_status.Text = status;
                if (!DateTime.TryParseExact(selectedRow.Cells["Creation Date"].Value.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out selectedCreationDate))
                {
                    MessageBox.Show("Invalid date format in Creation Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedInvoiceDetails = new List<Tuple<string, int, decimal>>();

                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var query = from chitiet in db.CHITIET_HOADONs
                                join sanpham in db.SANPHAMs on chitiet.MaSanPham equals sanpham.MaSanPham
                                where chitiet.MaHoaDon == selectedInvoiceID
                                select new
                                {
                                    sanpham.TenSanPham,
                                    chitiet.SoLuong,
                                    chitiet.DonGia
                                };

                    foreach (var item in query)
                    {
                        int soLuong;
                        if (int.TryParse(item.SoLuong.ToString(), out soLuong))
                        {
                            selectedInvoiceDetails.Add(new Tuple<string, int, decimal>(item.TenSanPham, soLuong, item.DonGia));
                        }
                        else
                        {
                            MessageBox.Show("Cannot convert SoLuong to int: " + item.SoLuong);
                        }
                    }
                }

                lstv_ChiTietHoaDon.Items.Clear();
                foreach (var detail in selectedInvoiceDetails)
                {
                    ListViewItem item = new ListViewItem(detail.Item1);
                    item.SubItems.Add(detail.Item2.ToString());
                    item.SubItems.Add((detail.Item2 * detail.Item3).ToString("N0"));
                    lstv_ChiTietHoaDon.Items.Add(item);
                }

                decimal totalAmount = 0;
                foreach (var detail in selectedInvoiceDetails)
                {
                    totalAmount += detail.Item2 * detail.Item3;
                }

                txt_Summ.Text = totalAmount.ToString("N0");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var keyword = txt_Search.Text.Trim();

                    var TimFr = from hoadon in db.HOADONs
                                join nhanvien in db.NHAN_VIENs on hoadon.MaNhanVien equals nhanvien.MaNhanVien
                                where hoadon.MaHoaDon.Contains(keyword) || nhanvien.TenNhanVien.Contains(keyword)
                                select new
                                {
                                    hoadon.MaHoaDon,
                                    nhanvien.TenNhanVien,
                                    hoadon.NgayTao,
                                    hoadon.TongTien,
                                    Status = hoadon.TrangThai.HasValue ? (hoadon.TrangThai.Value ? "Đã thanh toán" : "Chưa thanh toán") : "Chưa thanh toán"
                                };

                    dgv_HoaDon.DataSource = TimFr.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra trạng thái của hóa đơn
                if (txt_status.Text == "Chưa thanh toán")
                {
                    MessageBox.Show("This invoice has not been completed yet. You cannot print it.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Ngăn chặn việc in nếu hóa đơn chưa hoàn thành
                }

                // Nếu hóa đơn đã hoàn thành, tiến hành in
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(PrintPage);
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
            Brush brush = Brushes.Black;
            float y = 20;
            float lineHeight = font.GetHeight(e.Graphics) + 5;

            e.Graphics.DrawString("Employee Name: " + selectedEmployeeName, font, brush, 20, y);
            y += lineHeight;
            e.Graphics.DrawString("Creation Date: " + selectedCreationDate.ToString("dd/MM/yyyy HH:mm:ss"), font, brush, 20, y);
            y += lineHeight;

            e.Graphics.DrawString("Invoice Details", new System.Drawing.Font("Arial", 14, FontStyle.Bold), brush, 20, y);
            y += lineHeight;

            e.Graphics.DrawString("Product", font, brush, 20, y);
            e.Graphics.DrawString("Quantity", font, brush, 200, y);
            e.Graphics.DrawString("Price", font, brush, 300, y);
            y += lineHeight;

            foreach (var detail in selectedInvoiceDetails)
            {
                e.Graphics.DrawString(detail.Item1, font, brush, 20, y);
                e.Graphics.DrawString(detail.Item2.ToString(), font, brush, 200, y);
                e.Graphics.DrawString(detail.Item3.ToString("N0"), font, brush, 300, y);
                y += lineHeight;
            }

            y += lineHeight;
            e.Graphics.DrawString("Total Amount: " + selectedTotalAmount.ToString("N0"), font, brush, 20, y);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedInvoiceID))
                {
                    MessageBox.Show("Please select an invoice to change the status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var invoice = db.HOADONs.SingleOrDefault(hd => hd.MaHoaDon == selectedInvoiceID);
                    if (invoice == null)
                    {
                        MessageBox.Show("Invoice not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra nếu hóa đơn đã thanh toán thì không cho xóa
                    if (invoice.TrangThai.HasValue && invoice.TrangThai.Value)
                    {
                        DialogResult result = MessageBox.Show("This invoice has already been paid. Do you still want to change its status?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("This invoice is not paid yet. You cannot change its status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Cập nhật trạng thái hóa đơn
                    invoice.TrangThai = false;

                    // Lặp qua từng mặt hàng trong hóa đơn và cập nhật lại số lượng sản phẩm
                    foreach (var detail in selectedInvoiceDetails)
                    {
                        var product = db.SANPHAMs.SingleOrDefault(sp => sp.TenSanPham == detail.Item1);
                        if (product != null)
                        {
                            // Cộng lại số lượng của sản phẩm trong bảng SANPHAMs
                            product.SoLuongConLai += detail.Item2;
                        }
                    }

                    db.SubmitChanges();

                    LoadataHoaDon();
                    lstv_ChiTietHoaDon.Items.Clear();
                    UpdateTotalAmount();

                    MessageBox.Show("Invoice status changed successfully and product quantities updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
