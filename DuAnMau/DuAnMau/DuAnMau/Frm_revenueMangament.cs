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
    public partial class Frm__revenueMangament : Form
    {
        public Frm__revenueMangament()
        {
            InitializeComponent();
            Loadatadgv();
        }
        string conn = @"Data Source=LOVELYPOPPY\THUNHAT;Initial Catalog=FastFoodDB;Integrated Security=True;";
        public void Loadatadgv()
        {
            using (var db = new DataClasses1DataContext(conn))
            {
                //viết câu query và join bảng sản phẩm
                var query = from chitiet in db.CHITIET_HOADONs
                            join sanpham in db.SANPHAMs on chitiet.MaSanPham equals sanpham.MaSanPham
                            select new
                            {
                                sanpham.TenSanPham,
                                chitiet.MaSanPham,
                                chitiet.SoLuong,
                                chitiet.TongGiaTriSanPham,
                                chitiet.DonGia
                            };

                DataTable dt = new DataTable();

                dt.Columns.Add("Name Product");
                dt.Columns.Add("ID Product");
                dt.Columns.Add("Amount");
                dt.Columns.Add("Total product value");
                dt.Columns.Add("Price");

                // Đổ dữ liệu vào DataTable từ truy vấn
                foreach (var item in query)
                {
                    DataRow row = dt.NewRow();
                    row["Name Product"] = item.TenSanPham;
                    row["ID Product"] = item.MaSanPham;
                    row["Amount"] = item.SoLuong;
                    row["Total product value"] = item.TongGiaTriSanPham;
                    row["Price"] = item.DonGia.ToString();
                    dt.Rows.Add(row);
                }

                dgv_revenue.DataSource = dt;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_revenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_revenue.Rows[e.RowIndex];
                txt_nameProduct.Text = row.Cells["Name Product"].Value.ToString();
                txt_idProduct.Text = row.Cells["ID Product"].Value.ToString();
                txt_amount.Text = row.Cells["Amount"].Value.ToString();
                txt_total.Text = row.Cells["Total product value"].Value.ToString();
                txt_price.Text = Convert.ToInt32(row.Cells["Price"].Value).ToString("N0");
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem DataGridView có dòng dữ liệu nào không
            if (dgv_revenue.RowCount <= 0)
            {
                MessageBox.Show("There is no search information");
            }
            else
            {
                // Lấy chuỗi tìm kiếm từ TextBox
                string tim = txt_search.Text.Trim();

                // Kết nối đến cơ sở dữ liệu
                using (var db = new DataClasses1DataContext(conn))
                {
                    // Thực hiện tìm kiếm trong cơ sở dữ liệu
                    var timKiem = from chitiet in db.CHITIET_HOADONs
                                  join sanpham in db.SANPHAMs on chitiet.MaSanPham equals sanpham.MaSanPham
                                  where chitiet.MaSanPham.Contains(tim) ||
                                        sanpham.TenSanPham.Contains(tim)
                                  select new
                                  {
                                      sanpham.TenSanPham,
                                      chitiet.MaSanPham,
                                      chitiet.SoLuong,
                                      chitiet.TongGiaTriSanPham,
                                      chitiet.DonGia
                                  };
                    // Hiển thị kết quả tìm kiếm trong DataGridView
                    dgv_revenue.DataSource = timKiem;

                    // Cập nhật các thay đổi vào cơ sở dữ liệu
                    db.SubmitChanges();
                }
            }
        }
    }
}
