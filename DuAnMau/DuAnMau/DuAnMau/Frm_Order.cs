using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuAnMau
{
    public partial class Frm_Order : Form
    {
        private string conn = "Data Source=DESKTOP-F5INLQE\\HAU;Initial Catalog=FastFoodDB;Integrated Security=True;";

        public Frm_Order()
        {
            InitializeComponent();           
        }
        private void Frm_Order_Load(object sender, EventArgs e)
        {
            cbo_type();
            cbo_dish();
            LoadData_lstv();
            lstv_HoaDon.MultiSelect = true;
            timer1.Start();
        }

        public void LoadData_lstv()
        {
            
            lstv_HoaDon.Columns.Add("Số bàn"); // Cột cho số bàn
            lstv_HoaDon.Columns.Add("Số bàn", 70); // Cột cho số bàn
            lstv_HoaDon.Columns.Add("Tên món", 150); // Cột cho tên món ăn
            lstv_HoaDon.Columns.Add("Số lượng", 70); // Cột cho số lượng
            lstv_HoaDon.Columns.Add("Giá", 100); // Cột cho giá
            //lstv_HoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);                       
            lstv_HoaDon.Columns[0].Width = (int)(lstv_HoaDon.Width * 0.25); ; // Tự động điều chỉnh kích thước cột số bàn
            lstv_HoaDon.Columns[1].Width = (int)(lstv_HoaDon.Width * 0.25); ; // Tự động điều chỉnh kích thước cột tên món
            lstv_HoaDon.Columns[2].Width = (int)(lstv_HoaDon.Width * 0.25); ; // Tự động điều chỉnh kích thước cột số lượng
            lstv_HoaDon.Columns[3].Width = (int)(lstv_HoaDon.Width * 0.25); ; // Tự động điều chỉnh kích thước cột giá
            lstv_HoaDon.View = View.Details;
            lstv_HoaDon.GridLines = true;
            //click vào lisview 
            lstv_HoaDon.FullRowSelect = true;
        }

        public void cbo_type()
        {
            try
            {
                using (var db = new DataClasses1DataContext(conn))
                {
                    var loaiSp = (from sp in db.SANPHAMs
                                  select sp.LoaiSanPham).Distinct().ToList();

                    Cbo_Type.Items.Clear();
                    Cbo_Type.Items.AddRange(loaiSp.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        public void cbo_dish()
        {
            try
            {
                using (var db = new DataClasses1DataContext(conn))
                {
                    var loaiSp = (from sp in db.SANPHAMs
                                  select sp.TenSanPham).Distinct().ToList();
                    Cbo_dish.Items.Clear();
                    Cbo_dish.Items.AddRange(loaiSp.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu đã chọn từ ComboBox và Guna2NumericUpDown
                string selectedDish = Cbo_dish.SelectedItem?.ToString();
                int quantity = (int)Nud_quantity.Value;
                int tableNumber = int.Parse(txt_TableNumber.Text); // Lấy số bàn từ TextBox hoặc một nguồn khác

                if (string.IsNullOrEmpty(selectedDish) || quantity <= 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng trước khi thêm vào đơn hàng.");
                    return;
                }

                // Kiểm tra xem sản phẩm đã tồn tại trong đơn hàng chưa
                bool isExisting = false;
                foreach (ListViewItem item in lstv_HoaDon.Items)
                {
                    if (item.SubItems[1].Text == selectedDish)
                    {
                        // Nếu sản phẩm đã tồn tại, cập nhật số lượng và tính lại giá
                        int currentQuantity = int.Parse(item.SubItems[2].Text);
                        int newQuantity = currentQuantity + quantity;
                        item.SubItems[2].Text = newQuantity.ToString();

                        // Tính toán lại giá
                        decimal pricePerItem = decimal.Parse(item.SubItems[3].Text.Replace(".", "")) / currentQuantity;
                        decimal totalPrice = pricePerItem * newQuantity;
                        item.SubItems[3].Text = totalPrice.ToString("N0");
                        CalculateSum(); // cập nhật lại tổng tiền 
                        isExisting = true;
                        break;
                    }
                }

                // Nếu sản phẩm không tồn tại, thêm một mục mới vào ListView
                if (!isExisting)
                {
                    using (var db = new DataClasses1DataContext(conn))
                    {
                        var selectedProduct = db.SANPHAMs.FirstOrDefault(sp => sp.TenSanPham == selectedDish);
                        if (selectedProduct != null)
                        {
                            decimal gia = selectedProduct.Tien;
                            decimal tongGia = gia * quantity; // Tính tổng giá

                            // Thêm dữ liệu vào ListView
                            ListViewItem listViewItem = new ListViewItem(tableNumber.ToString()); // Thêm số bàn
                            listViewItem.SubItems.Add(selectedDish); // Thêm tên món
                            listViewItem.SubItems.Add(quantity.ToString()); // Thêm số lượng
                            listViewItem.SubItems.Add(tongGia.ToString("N0")); // Thêm tổng giá

                            lstv_HoaDon.Items.Add(listViewItem);
                            CalculateSum(); // Tính tổng sau khi thêm món
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy giá của món được chọn.");
                        }
                    }
                }

                // Clear các ComboBox sau khi đã thêm dữ liệu vào ListView
                Cbo_dish.SelectedIndex = -1;
                Nud_quantity.Value = 1; // Reset số lượng về 1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu vào đơn hàng: " + ex.Message);
            }
        }
        // Tính tổng cần thanh toán
        private void CalculateSum()
        {
            decimal sum = 0;
            foreach (ListViewItem item in lstv_HoaDon.Items)
            {
                decimal itemPrice = decimal.Parse(item.SubItems[3].Text);
                sum += itemPrice;
            }
            txt_Summ.Text = sum.ToString("N0"); 
        }
        
        // lọc tên sản phẩm theo loại sản phảm
        private void Cbo_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = Cbo_Type.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedType))
            {
                try
                {
                    using (var db = new DataClasses1DataContext(conn))
                    {
                        var dishes = (from sp in db.SANPHAMs
                                      where sp.LoaiSanPham == selectedType
                                      select sp.TenSanPham).Distinct().ToList();

                        Cbo_dish.Items.Clear();
                        Cbo_dish.Items.AddRange(dishes.ToArray());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (lstv_HoaDon.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa mục đã chọn khỏi ListView
                    lstv_HoaDon.Items.Remove(lstv_HoaDon.SelectedItems[0]);
                    CalculateSum(); // Tính lại tổng sau khi xóa
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lstv_HoaDon.Items.Clear(); // Xóa tất cả các mục trong ListView
            CalculateSum(); // Tính lại tổng sau khi xóa
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ListView có mục hàng nào không
            if (lstv_HoaDon.Items.Count == 0)
            {
                MessageBox.Show("Không có mục hàng nào để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Hiển thị hộp thoại Yes/No để xác nhận việc thanh toán
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Thực hiện quy trình thanh toán
                try
                {
                    using (var db = new DataClasses1DataContext(conn))
                    {
                        // Bắt đầu một giao dịch
                        db.Connection.Open();
                        var transaction = db.Connection.BeginTransaction();
                        db.Transaction = transaction;

                        // Tạo một ID mới cho đơn hàng
                        string newOrderId = GenerateNewId("HOADON", "MaHoaDon", "HD");

                        // Thêm đơn hàng vào bảng HOADON
                        HOADON newOrder = new HOADON
                        {
                            MaHoaDon = newOrderId,
                            MaNhanVien = "NV001", 
                            NgayTao = DateTime.Now,
                            TongTien = decimal.Parse(txt_Summ.Text),
                            TrangThai = true
                        };
                        db.HOADONs.InsertOnSubmit(newOrder);
                        db.SubmitChanges();

                        // Thêm chi tiết đơn hàng vào bảng CHITIET_HOADON
                        foreach (ListViewItem item in lstv_HoaDon.Items)
                        {
                            string dishName = item.SubItems[1].Text;
                            int quantity = int.Parse(item.SubItems[2].Text);

                            // Lấy thông tin sản phẩm
                            var product = db.SANPHAMs.FirstOrDefault(sp => sp.TenSanPham == dishName);
                            if (product != null)
                            {
                                string newOrderDetailId = GenerateNewId("CHITIET_HOADON", "MaChiTietHoaDon", "CT");

                                CHITIET_HOADON orderDetail = new CHITIET_HOADON
                                {
                                    MaChiTietHoaDon = newOrderDetailId,
                                    MaHoaDon = newOrderId,
                                    MaSanPham = product.MaSanPham,
                                    SoLuong = quantity.ToString(),
                                    DonGia = product.Tien,
                                    TongGiaTriSanPham = product.Tien * quantity
                                };

                                db.CHITIET_HOADONs.InsertOnSubmit(orderDetail);

                                // Cập nhật số lượng sản phẩm trong bảng SANPHAM
                                product.SoLuongConLai = (int.Parse(product.SoLuongConLai) - quantity).ToString();
                            }
                        }

                        // Xác nhận giao dịch
                        db.SubmitChanges();
                        transaction.Commit();

                        // Xóa ListView và thiết lập lại form
                        lstv_HoaDon.Items.Clear();
                        txt_Summ.Text = "0";
                        MessageBox.Show("Thanh toán thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thanh toán: " + ex.Message);
                }
            }
        }

        private string GenerateNewId(string tableName, string columnName, string prefix)
        {
            using (var db = new DataClasses1DataContext(conn))
            {
                // lấy ra id lớn nhất trong columname, trả về danh sách dạng chuỗi
                // Nó chọn ra giá trị lớn nhất trong cột columnName của bảng tableName mà bắt đầu bằng prefix
                var maxId = db.ExecuteQuery<string>($"SELECT MAX({columnName}) FROM {tableName} WHERE {columnName} LIKE '{prefix}%'").FirstOrDefault();
                if (maxId != null)
                {
                    int newIdNum = int.Parse(maxId.Substring(prefix.Length)) + 1;
                    return prefix + newIdNum.ToString("D3");
                }
                else
                {
                    return prefix + "001"; // Nếu không có mã nào tồn tại, trả về mã đầu tiên trong chuỗi
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }        
    }
}

