using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DuAnMau
{
    public partial class Frm_revenueMangament : Form
    {
        public Frm_revenueMangament()
        {
            InitializeComponent();
            Loadatadgv();
            // Ẩn cột trống ở phía bên trái của DataGridView
            dgv_revenue.RowHeadersVisible = false;
        }
        private Cl_conn clConn = new Cl_conn();
        public void Loadatadgv()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var query = from hoadon in db.HOADONs
                                join nhanvien in db.NHAN_VIENs on hoadon.MaNhanVien equals nhanvien.MaNhanVien
                                select new
                                {
                                    hoadon.MaHoaDon,
                                    hoadon.MaNhanVien,
                                    nhanvien.TenNhanVien,
                                    hoadon.NgayTao,
                                    hoadon.TongTien,
                                    hoadon.TrangThai
                                };

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID Bill");
                    dt.Columns.Add("ID Employee");
                    dt.Columns.Add("Name Employee");
                    dt.Columns.Add("Date Created");
                    dt.Columns.Add("Total");
                    dt.Columns.Add("State");

                    foreach (var item in query)
                    {
                        dt.Rows.Add(item.MaHoaDon, item.MaNhanVien, item.TenNhanVien, item.NgayTao, item.TongTien, item.TrangThai);
                    }

                    // Thiết lập DataSource của DataGridView là DataTable
                    dgv_revenue.DataSource = dt;

                    // Thiết lập AutoSizeMode cho mỗi cột
                    dgv_revenue.Columns["ID Bill"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgv_revenue.Columns["ID Employee"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgv_revenue.Columns["Name Employee"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgv_revenue.Columns["Date Created"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgv_revenue.Columns["Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgv_revenue.Columns["State"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    // Cập nhật lại DataGridView
                    dgv_revenue.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dgv_revenue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_revenue.Rows[e.RowIndex];
                txt_idBill.Text = row.Cells["ID Bill"].Value?.ToString();
                txt_idProduct.Text = row.Cells["ID Employee"].Value?.ToString();
                txt_name.Text = row.Cells["Name Employee"].Value?.ToString();
                txt_day.Text = row.Cells["Date Created"].Value?.ToString();

                // Kiểm tra nếu ô "Total" không rỗng
                if (row.Cells["Total"].Value != null)
                {
                    string totalValueString = row.Cells["Total"].Value.ToString();

                    try
                    {
                        // Chuyển đổi giá trị thành decimal và định dạng
                        decimal totalValue = Convert.ToDecimal(totalValueString);
                        txt_money.Text = totalValue.ToString("N0");
                    }
                    catch (FormatException)
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành số
                        txt_money.Text = "Invalid format";
                    }
                    catch (InvalidCastException)
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành số
                        txt_money.Text = "Invalid cast";
                    }
                }
                else
                {
                    txt_money.Text = string.Empty;
                }

                txt_total.Text = row.Cells["State"].Value?.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu DataGridView có hàng nào không
            if (dgv_revenue.Rows.Count > 0)
            {
                // Tạo và cấu hình SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                    Title = "Save an Excel File"
                };

                // Hiển thị hộp thoại lưu tệp và kiểm tra nếu người dùng nhấn "OK"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application excel = null;
                    Excel.Workbook workbook = null;
                    Excel.Worksheet worksheet = null;

                    try
                    {
                        // Tạo đối tượng ứng dụng Excel mới
                        excel = new Excel.Application();

                        // Thêm một workbook mới vào ứng dụng Excel
                        workbook = excel.Workbooks.Add(Type.Missing);
                        worksheet = (Excel.Worksheet)workbook.Sheets[1];

                        // Vòng lặp qua các cột của DataGridView để đặt tên cột vào hàng đầu tiên của bảng tính Excel
                        for (int i = 1; i < dgv_revenue.Columns.Count + 1; i++)
                        {
                            worksheet.Cells[1, i] = dgv_revenue.Columns[i - 1].HeaderText;
                        }

                        // Vòng lặp qua từng hàng của DataGridView để đặt giá trị của mỗi ô vào bảng tính Excel
                        for (int i = 0; i < dgv_revenue.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv_revenue.Columns.Count; j++)
                            {
                                // Đặt giá trị của ô tại hàng i và cột j vào bảng tính Excel, bắt đầu từ hàng thứ 2
                                worksheet.Cells[i + 2, j + 1] = dgv_revenue.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                            }
                        }

                        // Tự động điều chỉnh độ rộng của các cột trong bảng tính Excel để vừa với nội dung
                        worksheet.Columns.AutoFit();

                        // Lưu workbook vào vị trí và tên tệp mà người dùng đã chọn
                        workbook.SaveAs(saveFileDialog.FileName);

                        // Hiển thị thông báo xuất thành công
                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Bắt các ngoại lệ có thể xảy ra và hiển thị thông báo lỗi
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        // Giải phóng các đối tượng COM để ngăn ngừa rò rỉ bộ nhớ
                        if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                        if (workbook != null) Marshal.ReleaseComObject(workbook);
                        if (excel != null) Marshal.ReleaseComObject(excel);
                    }
                }
            }
            else
            {
                // Nếu không có hàng nào trong DataGridView, hiển thị thông báo rằng không có dữ liệu để xuất
                MessageBox.Show("No data to export!");
            }
        }


        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    string key = txt_search.Text.Trim();
                    var searchResult = from hoadon in db.HOADONs
                                       join nhanvien in db.NHAN_VIENs on hoadon.MaNhanVien equals nhanvien.MaNhanVien
                                       where hoadon.MaHoaDon.Contains(key) || nhanvien.TenNhanVien.Contains(key)
                                       select new
                                       {
                                           hoadon.MaHoaDon,
                                           hoadon.MaNhanVien,
                                           nhanvien.TenNhanVien,
                                           hoadon.NgayTao,
                                           hoadon.TongTien,
                                           hoadon.TrangThai
                                       };

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID Bill");
                    dt.Columns.Add("ID Employee");
                    dt.Columns.Add("Name Employee");
                    dt.Columns.Add("Date Created");
                    dt.Columns.Add("Total");
                    dt.Columns.Add("State");

                    foreach (var item in searchResult)
                    {
                        dt.Rows.Add(item.MaHoaDon, item.MaNhanVien, item.TenNhanVien, item.NgayTao, item.TrangThai);
                    }

                    dgv_revenue.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
            
        }
        private void CalculateTotalRevenue()
        {
            try
            {
                // Trích xuất giá trị từ DateTimePicker cho ngày bắt đầu và kết thúc
                DateTime startDate = dateTimePickerStartDate.Value.Date;
                DateTime endDate = dateTimePickerEndDate.Value.Date.AddDays(1); // Bổ sung 1 ngày để bao gồm cả ngày kết thúc

                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    // Truy vấn cơ sở dữ liệu để tính tổng tiền của các hóa đơn trong khoảng thời gian đã chọn
                    var totalRevenue = (from hoadon in db.HOADONs
                                        where hoadon.NgayTao >= startDate && hoadon.NgayTao < endDate
                                        select hoadon.TongTien).Sum();

                    // Hiển thị tổng tiền tính được lên TextBox
                    txt_totalAmount.Text = totalRevenue.ToString("N0"); // Format số với dấu phân cách ngàn
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total revenue: " + ex.Message);
            }
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            // Khi người dùng thay đổi ngày bắt đầu, tính tổng tiền lại
            CalculateTotalRevenue();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            // Khi người dùng thay đổi ngày kết thúc, tính tổng tiền lại
            CalculateTotalRevenue();
        }
    }
}
