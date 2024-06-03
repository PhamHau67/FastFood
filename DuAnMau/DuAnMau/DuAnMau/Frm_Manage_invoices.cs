
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
        private string selectedEmployeeName;
        private DateTime selectedCreationDate;
        private decimal selectedTotalAmount;
        private List<Tuple<string, int, decimal>> selectedInvoiceDetails;
        private string conn = "Data Source=RUDEUS\\VVH;Initial Catalog=FastFoodDB;Integrated Security=True;";
        public Frm_Manage_invoices()
        {
            InitializeComponent();
            LoadataHoaDon(); 
            timer1.Start();
            Row_lstv();

            // Thêm trình xử lý sự kiện cho DateTimePickers
            dt_start.ValueChanged += DateTimePickers_ValueChanged;
            dt_end.ValueChanged += DateTimePickers_ValueChanged;

        }

        private void LoadataHoaDon()
        {
            using (var db = new DataClasses1DataContext(conn))
            {
                var query = from hoadon in db.HOADONs
                            join nhanvien in db.NHAN_VIENs on hoadon.MaNhanVien equals nhanvien.MaNhanVien
                            select new
                            {
                                hoadon.MaHoaDon,
                                nhanvien.TenNhanVien,
                                hoadon.NgayTao,
                                hoadon.TongTien,
                                Status = hoadon.TrangThai.HasValue ? (hoadon.TrangThai.Value ? "Đã thanh toán" : "Chưa thanh toán") : "Chưa thanh toán" // Thay đổi trạng thái
                            };

                // Tạo DataTable từ kết quả truy vấn
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
                    row["Status"] = item.Status; // Gán giá trị trạng thái mới
                    dt.Rows.Add(row);
                }

                // Gắn kết DataTable với DataGridView
                dgv_HoaDon.DataSource = dt;

                // Hiển thị tổng số tiền của các hóa đơn trên TextBox
                txt_Summ.Text = totalAmount.ToString("N0");
            }
        }
        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (ListViewItem item in lstv_ChiTietHoaDon.Items)
            {
                // Lấy giá trị số tiền từ cột thứ 3 (index là 2)
                string priceString = item.SubItems[2].Text;

                // Chuyển đổi giá trị số tiền từ chuỗi về decimal
                if (decimal.TryParse(priceString, out decimal price))
                {
                    // Cộng dồn vào tổng số tiền
                    totalAmount += price;
                }
            }

            // Hiển thị tổng số tiền lên TextBox
            txt_Summ.Text = totalAmount.ToString("N0");
        }


        private void FilterDataByDate()
        {
            DateTime startDate = dt_start.Value.Date;
            DateTime endDate = dt_end.Value.Date.AddDays(1).AddTicks(-1);

            using (var db = new DataClasses1DataContext(conn))
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
                                Status = hoadon.TrangThai.HasValue ? (hoadon.TrangThai.Value ? "Đã thanh toán" : "Chưa thanh toán") : "Chưa thanh toán" // Thay đổi trạng thái
                            };

                // Tạo DataTable từ kết quả truy vấn
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
                    row["Status"] = item.Status; // Gán giá trị trạng thái mới
                    dt.Rows.Add(row);
                }
                // Gắn kết DataTable với DataGridView
                dgv_HoaDon.DataSource = dt;
            }
        }

        // Trình xử lý sự kiện để thay đổi giá trị DateTimePicker
        private void DateTimePickers_ValueChanged(object sender, EventArgs e)
        {
            FilterDataByDate();
        }

        public void Row_lstv()
        {
            lstv_ChiTietHoaDon.Columns.Add("Product", 200); // Cột cho tên món ăn
            lstv_ChiTietHoaDon.Columns.Add("Quantity", 90); // Cột cho số lượng
            lstv_ChiTietHoaDon.Columns.Add("Price", 90); // Cột cho giá
            lstv_ChiTietHoaDon.Columns[0].Width = (int)(lstv_ChiTietHoaDon.Width * 0.40);
            lstv_ChiTietHoaDon.Columns[1].Width = (int)(lstv_ChiTietHoaDon.Width * 0.25);
            lstv_ChiTietHoaDon.Columns[2].Width = (int)(lstv_ChiTietHoaDon.Width * 0.25);
            lstv_ChiTietHoaDon.View = View.Details;
            lstv_ChiTietHoaDon.GridLines = true;
        }
             
        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hay không
            if (e.RowIndex >= 0)
            {
                // Lấy hóa đơn được chọn từ DataGridView
                DataGridViewRow selectedRow = dgv_HoaDon.Rows[e.RowIndex];
                string maHoaDon = selectedRow.Cells["Invoice ID"].Value.ToString();

                // Lưu thông tin hóa đơn được chọn
                selectedEmployeeName = selectedRow.Cells["Employee Name"].Value.ToString();

                // Sử dụng DateTime.ParseExact để xử lý định dạng ngày tháng
                string dateFormat = "dd/MM/yyyy";
                if (!DateTime.TryParseExact(selectedRow.Cells["Creation Date"].Value.ToString(), dateFormat, null, System.Globalization.DateTimeStyles.None, out selectedCreationDate))
                {
                    MessageBox.Show("Invalid date format in Creation Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(selectedRow.Cells["Total Amount"].Value.ToString(), out selectedTotalAmount))
                {
                    MessageBox.Show("Invalid number format in Total Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lưu chi tiết hóa đơn vào danh sách
                selectedInvoiceDetails = new List<Tuple<string, int, decimal>>();

                // Truy vấn chi tiết hóa đơn tương ứng từ cơ sở dữ liệu
                using (var db = new DataClasses1DataContext(conn))
                {
                    var query = from chitiet in db.CHITIET_HOADONs
                                join sanpham in db.SANPHAMs on chitiet.MaSanPham equals sanpham.MaSanPham
                                where chitiet.MaHoaDon == maHoaDon
                                select new
                                {
                                    sanpham.TenSanPham,
                                    chitiet.SoLuong,
                                    chitiet.DonGia
                                };

                    // Thêm chi tiết hóa đơn vào danh sách
                    foreach (var item in query)
                    {
                        int soLuong = 0;
                        if (int.TryParse(item.SoLuong.ToString(), out soLuong))
                        {
                            selectedInvoiceDetails.Add(new Tuple<string, int, decimal>(item.TenSanPham, soLuong, item.DonGia));
                        }
                        else
                        {
                            // Xử lý trường hợp không chuyển đổi được
                            MessageBox.Show("Cannot convert SoLuong to int: " + item.SoLuong);
                        }
                    }
                }

                // Hiển thị chi tiết hóa đơn trong ListView
                lstv_ChiTietHoaDon.Items.Clear();
                foreach (var detail in selectedInvoiceDetails)
                {
                    ListViewItem item = new ListViewItem(detail.Item1);
                    item.SubItems.Add(detail.Item2.ToString()); // Convert int to string
                    item.SubItems.Add(detail.Item3.ToString("N0")); // Convert decimal to string
                    lstv_ChiTietHoaDon.Items.Add(item);
                }
            }
            UpdateTotalAmount();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DataClasses1DataContext(conn))
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
                // Tạo một đối tượng PrintDocument
                PrintDocument pd = new PrintDocument();

                // Đặt sự kiện PrintPage cho việc vẽ nội dung cần in
                pd.PrintPage += new PrintPageEventHandler(PrintPage);

                // In hoá đơn
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

            // In thông tin nhân viên và ngày giờ
            e.Graphics.DrawString("Employee Name: " + selectedEmployeeName, font, brush, 20, y);
            y += lineHeight;
            e.Graphics.DrawString("Creation Date: " + selectedCreationDate.ToString("dd/MM/yyyy HH:mm:ss"), font, brush, 20, y);
            y += lineHeight;

            // In chi tiết hóa đơn
            e.Graphics.DrawString("Invoice Details", new System.Drawing.Font("Arial", 14, FontStyle.Bold), brush, 20, y);
            y += lineHeight;

            e.Graphics.DrawString("Product", font, brush, 20, y);
            e.Graphics.DrawString("Quantity", font, brush, 200, y);
            e.Graphics.DrawString("Price", font, brush, 300, y);
            y += lineHeight;

            foreach (var detail in selectedInvoiceDetails)
            {
                e.Graphics.DrawString(detail.Item1, font, brush, 20, y);
                e.Graphics.DrawString(detail.Item2.ToString(), font, brush, 200, y); // Convert int to string
                e.Graphics.DrawString(detail.Item3.ToString("N0"), font, brush, 300, y); // Convert decimal to string
                y += lineHeight;
            }

            // In tổng tiền
            y += lineHeight;
            e.Graphics.DrawString("Total Amount: " + selectedTotalAmount.ToString("N0"), font, brush, 20, y);
        }
    }
}
