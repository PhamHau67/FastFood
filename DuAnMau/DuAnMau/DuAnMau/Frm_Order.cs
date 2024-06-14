using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DuAnMau
{
    public partial class Frm_Order : Form
    {
        private Cl_conn clConn = new Cl_conn();
        private string employeeName;

        public Frm_Order(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
        }
        private void Frm_Order_Load(object sender, EventArgs e)
        {
            cbo_type();
            cbo_dish();
            LoadData_lstv();
            timer1.Start();
            // Hiển thị tên nhân viên
            lbl_EmployeeName.Text = "Nhân viên: " + employeeName;

        }

        public void LoadData_lstv()
        {
            lstv_HoaDon.Columns.Add("Number", 70); // Cột cho số bàn
            lstv_HoaDon.Columns.Add("Product", 120); // Cột cho tên món ăn
            lstv_HoaDon.Columns.Add("Quantity", 90); // Cột cho số lượng
            lstv_HoaDon.Columns.Add("Price", 90); // Cột cho giá

            //lstv_HoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);                       
            lstv_HoaDon.Columns[0].Width = (int)(lstv_HoaDon.Width * 0.25); ; // Tự động điều chỉnh kích thước cột số bàn
            lstv_HoaDon.Columns[1].Width = (int)(lstv_HoaDon.Width * 0.25); ; // Tự động điều chỉnh kích thước cột tên món
            lstv_HoaDon.Columns[2].Width = (int)(lstv_HoaDon.Width * 0.25); ; // Tự động điều chỉnh kích thước cột số lượng
            lstv_HoaDon.Columns[3].Width = (int)(lstv_HoaDon.Width * 0.25); ; // Tự động điều chỉnh kích thước cột giá
            lstv_HoaDon.View = View.Details;
            lstv_HoaDon.GridLines = true;
        }

        public void cbo_type()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var loaiSp = (from sp in db.SANPHAMs
                                  select sp.LoaiSanPham).Distinct().ToList();

                    Cbo_Type.Items.Clear();
                    Cbo_Type.Items.AddRange(loaiSp.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }

        public void cbo_dish()
        {
            try
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var loaiSp = (from sp in db.SANPHAMs
                                  select sp.TenSanPham).Distinct().ToList();
                    Cbo_dish.Items.Clear();
                    Cbo_dish.Items.AddRange(loaiSp.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from database: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu đã chọn từ ComboBox và Guna2NumericUpDown
                string selectedDish = Cbo_dish.SelectedItem?.ToString();
                int quantity = (int)Nud_quantity.Value;
                int tableNumber = int.Parse(cbo_Number.Text);

                if (string.IsNullOrEmpty(selectedDish) || quantity == 0)
                {
                    MessageBox.Show("Please select the product and enter the quantity before adding to the order.");
                    return;
                }

                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var selectedProduct = db.SANPHAMs.FirstOrDefault(sp => sp.TenSanPham == selectedDish);

                    if (selectedProduct != null)
                    {
                        if (selectedProduct.SoLuongConLai < quantity)
                        {
                            MessageBox.Show($"Not enough stock for {selectedDish}. Available stock: {selectedProduct.SoLuongConLai}");
                            return; // Không thực hiện thêm vào đơn hàng nếu số lượng không đủ
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

                                // Nếu số lượng mới <= 0, xóa mục đó khỏi ListView
                                if (newQuantity <= 0)
                                {
                                    lstv_HoaDon.Items.Remove(item);
                                }
                                else
                                {
                                    item.SubItems[2].Text = newQuantity.ToString();

                                    // Tính toán lại giá
                                    decimal pricePerItem = decimal.Parse(item.SubItems[3].Text.Replace(",", "")) / currentQuantity;
                                    decimal totalPrice = pricePerItem * newQuantity;
                                    item.SubItems[3].Text = totalPrice.ToString("N0");
                                }
                                CalculateSum(); // cập nhật lại tổng tiền 
                                isExisting = true;
                                break;
                            }
                        }

                        // Nếu sản phẩm không tồn tại và quantity > 0, thêm một mục mới vào ListView
                        if (!isExisting && quantity > 0)
                        {
                            decimal gia = selectedProduct.Tien;
                            decimal tongGia = gia * quantity; // Tính tổng giá

                            // Thêm dữ liệu vào ListView
                            ListViewItem listViewItem = new ListViewItem(tableNumber.ToString()); // Thêm số bàn
                            listViewItem.SubItems.Add(selectedDish); // Thêm tên món
                            listViewItem.SubItems.Add(quantity.ToString()); // Thêm số lượng
                            listViewItem.SubItems.Add(tongGia.ToString("N0")); // Thêm tổng giá.
                            lstv_HoaDon.Items.Add(listViewItem);
                            CalculateSum(); // Tính tổng sau khi thêm món

                            // Giảm số lượng tồn kho của sản phẩm
                            selectedProduct.SoLuongConLai -= quantity;
                            db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giá của món được chọn.");
                    }
                }

                // Clear các ComboBox sau khi đã thêm dữ liệu vào ListView
                Cbo_dish.SelectedIndex = -1;
                Nud_quantity.Value = 1; // Reset số lượng về 1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when adding data to order: " + ex.Message);
            }
        }

        public static class InputBox
        {
            public static string Show(string prompt, string title, string defaultValue = "")
            {
                // Hiển thị hộp thoại nhập thông qua MessageBox
                string input = defaultValue;
                input = Microsoft.VisualBasic.Interaction.InputBox(prompt, title, defaultValue);
                return input;
            }
        }
        private void lstv_HoaDon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstv_HoaDon.SelectedItems.Count > 0)
            {
                // Lấy mục hàng được chọn trong ListView
                ListViewItem selectedItem = lstv_HoaDon.SelectedItems[0];
                string selectedDish = selectedItem.SubItems[1].Text;

                // Hiển thị hộp thoại để nhập số lượng mới
                string input = InputBox.Show("Enter the new quantity:", "Edit Quantity", selectedItem.SubItems[2].Text);

                // Kiểm tra xem người dùng đã nhập số lượng mới hay không
                if (!string.IsNullOrEmpty(input))
                {
                    // Cập nhật số lượng trong ListView
                    int newQuantity;
                    if (int.TryParse(input, out newQuantity))
                    {
                        // Chuyển đổi newQuantity thành giá trị tuyệt đối nếu là số âm
                        newQuantity = Math.Abs(newQuantity);

                        // Lấy giá trị của món ăn và số lượng hiện tại
                        decimal oldPrice = decimal.Parse(selectedItem.SubItems[3].Text.Replace(",", ""));
                        int oldQuantity = int.Parse(selectedItem.SubItems[2].Text);

                        // Cập nhật số lượng mới (đã chuyển thành giá trị tuyệt đối nếu là số âm)
                        selectedItem.SubItems[2].Text = newQuantity.ToString();

                        // Tính lại giá dựa trên số lượng mới và cập nhật lại giá trong ListView
                        decimal newPrice = (oldPrice / oldQuantity) * newQuantity;
                        selectedItem.SubItems[3].Text = newPrice.ToString("N0");

                        // Cập nhật tổng tiền
                        CalculateSum();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid quantity.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Tính tổng cần thanh toán
        private void CalculateSum()
        {
            decimal sum = 0;
            foreach (ListViewItem item in lstv_HoaDon.Items)
            {
                decimal itemPrice = decimal.Parse(item.SubItems[3].Text.Replace(",", ""));
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
                    using (var db = new DataClasses1DataContext(clConn.conn))
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
                    MessageBox.Show("Error reading data from database: " + ex.Message);
                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (lstv_HoaDon.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa mục đã chọn khỏi ListView
                    lstv_HoaDon.Items.Remove(lstv_HoaDon.SelectedItems[0]);
                    CalculateSum(); // Tính lại tổng sau khi xóa
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lstv_HoaDon.Items.Clear(); // Xóa tất cả các mục trong ListView
            CalculateSum(); // Tính lại tổng sau khi xóa
            txt_Summ.Text = "";
            txt_price.Text = "";
            txt_change.Text = "";
        }

        string maNhanVienDangNhap = Globals.username;

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ListView có mục hàng nào không
            if (lstv_HoaDon.Items.Count == 0)
            {
                MessageBox.Show("There are no line items available for payment.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to pay?", "Confirm payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Thực hiện quy trình thanh toán
                try
                {
                    using (var db = new DataClasses1DataContext(clConn.conn))
                    {
                        // Tìm mã nhân viên dựa trên tên nhân viên
                        var nhanVien = db.NHAN_VIENs.FirstOrDefault(nv => nv.TenNhanVien == maNhanVienDangNhap);

                        if (nhanVien != null)
                        {
                            // Bắt đầu một giao dịch
                            db.Connection.Open();
                            var transaction = db.Connection.BeginTransaction();
                            db.Transaction = transaction;

                            // Tạo một ID mới cho đơn hàng
                            string newOrderId = GenerateNewId("HOADON", "MaHoaDon", "HD");

                            // Kiểm tra mã đơn hàng đã tồn tại hay chưa
                            if (db.HOADONs.Any(hd => hd.MaHoaDon == newOrderId))
                            {
                                throw new Exception("The generated order ID already exists.");
                            }

                            // Thêm đơn hàng vào bảng HOADON
                            HOADON newOrder = new HOADON
                            {
                                MaHoaDon = newOrderId,
                                MaNhanVien = nhanVien.MaNhanVien,
                                NgayTao = DateTime.Now,
                                TongTien = decimal.Parse(txt_Summ.Text.Replace(",", "")), // Thêm phương thức Replace để loại bỏ dấu phẩy
                                TrangThai = true
                            };
                            db.HOADONs.InsertOnSubmit(newOrder);
                            db.SubmitChanges();

                            // Thêm chi tiết đơn hàng vào bảng CHITIET_HOADON
                            foreach (ListViewItem item in lstv_HoaDon.Items)
                            {
                                string dishName = item.SubItems[1].Text;
                                int quantity = int.Parse(item.SubItems[2].Text);

                                var product = db.SANPHAMs.FirstOrDefault(sp => sp.TenSanPham == dishName);
                                if (product != null)
                                {                                    
                                    CHITIET_HOADON orderDetail = new CHITIET_HOADON
                                    {                                       
                                        MaHoaDon = newOrderId,
                                        MaSanPham = product.MaSanPham,
                                        SoLuong = quantity.ToString(),
                                        DonGia = product.Tien,
                                        TongGiaTriSanPham = product.Tien * quantity
                                    };
                                    db.CHITIET_HOADONs.InsertOnSubmit(orderDetail);

                                    // Cập nhật số lượng sản phẩm trong bảng SANPHAM
                                    product.SoLuongConLai -= quantity;
                                    // Xác nhận giao dịch
                                    db.SubmitChanges();                            
                                }
                            }
                            transaction.Commit();

                            // In hóa đơn
                            PrintInvoice(newOrderId);

                            // Xóa ListView và thiết lập lại form
                            lstv_HoaDon.Items.Clear();
                            txt_Summ.Text = "";
                            txt_price.Text = "";
                            txt_change.Text = "";
                            MessageBox.Show("Payment success!");
                        }
                        else
                        {
                            MessageBox.Show("User not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during payment: " + ex.Message);
                }
            }
        }


        // Phương thức in hóa đơn
        private void PrintInvoice(string orderId)
        {
            try
            {
                // Tạo một đối tượng PrintDocument
                PrintDocument pd = new PrintDocument();

                // Đặt sự kiện PrintPage cho việc vẽ nội dung cần in
                pd.PrintPage += (sender, e) => PrintPage(sender, e, orderId);

                // In hoá đơn
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while printing the invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức in nội dung hóa đơn
        private void PrintPage(object sender, PrintPageEventArgs e, string orderId)
        {
            // Lấy thông tin cần thiết cho hóa đơn từ cơ sở dữ liệu
            string storeName = "Fast Food GS";
            string employeeNamee = "Name: " + employeeName;
            string currentTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string numBer = cbo_Number.Text;
            // Vẽ nội dung hóa đơn
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font titleFontS = new Font("Arial", 30, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12);
            Font contentFontB = new Font("Arial", 12,FontStyle.Bold);
            float lineHeight = contentFont.GetHeight() + 2;
            float startX = 10;
            float startY = 10;
            // Tính kích thước của chuỗi văn bản
            //SizeF textSize = e.Graphics.MeasureString(storeName, titleFont);

            // Tính vị trí để căn giữa trên trục x
            float centerX = startX + 300;

            // Vẽ chuỗi văn bản
            e.Graphics.DrawString(storeName, titleFont, Brushes.Black, centerX, startY);
            startY += lineHeight * 3;

            // Vẽ Số 
            e.Graphics.DrawString(numBer,titleFontS, Brushes.Black, startX, startY);
            startY += lineHeight * 3;

            // Vẽ tên nhân viên và thời gian
            e.Graphics.DrawString(employeeNamee, contentFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Time: {currentTime}", contentFont, Brushes.Black, startX, startY);
            startY += lineHeight * 2; // Tăng khoảng cách giữa các dòng

            // In Mã Hóa Đơn
            string orderIdText = "Order ID: " + orderId;
            e.Graphics.DrawString(orderIdText, titleFont, Brushes.Black, startX, startY);
            startY += lineHeight *2;

            // In chi tiết hóa đơn
            float tableX = startX;
            float tableY = startY;
            float columnWidth = e.PageBounds.Width / 3;
            e.Graphics.DrawString("Product", contentFontB, Brushes.Black, tableX , tableY);
            e.Graphics.DrawString("Quantity", contentFontB, Brushes.Black, tableX + columnWidth, tableY);
            e.Graphics.DrawString("Price", contentFontB, Brushes.Black, tableX + 2 * columnWidth, tableY);
            tableY += lineHeight;

            foreach (ListViewItem item in lstv_HoaDon.Items)
            {
                e.Graphics.DrawString(item.SubItems[1].Text, contentFont, Brushes.Black, tableX , tableY);
                e.Graphics.DrawString(item.SubItems[2].Text, contentFont, Brushes.Black, tableX +  columnWidth, tableY);
                e.Graphics.DrawString(item.SubItems[3].Text, contentFont, Brushes.Black, tableX + 2 * columnWidth, tableY);
                tableY += lineHeight ;
            }
            // In tổng tiền
            tableY += lineHeight ; // Dịch chuyển lên trước khi in tổng tiền
            e.Graphics.DrawString("Total Amount: " + txt_Summ.Text, contentFontB, Brushes.Red, tableY,centerX);
        }

        private string GenerateNewId(string tableName, string columnName, string prefix)
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var lastId = db.ExecuteQuery<string>($"SELECT TOP 1 {columnName} FROM {tableName} WHERE {columnName} LIKE '{prefix}%' ORDER BY {columnName} DESC").FirstOrDefault();
                if (lastId != null)
                {
                    int newIdNumber = int.Parse(lastId.Substring(prefix.Length)) + 1;
                    return prefix + newIdNumber.ToString("D3");
                }
                else
                {
                    return prefix + "001";
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        // Sự kiện tính toán tiền thối khi thay đổi giá trị txt_price
        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }
        
        private void CalculateChange()
        {
            // Chuyển đổi số tiền khách đưa thành số nguyên
            if (decimal.TryParse(txt_price.Text, out decimal customerMoney))
            {
                // Tính tổng số tiền cần thanh toán
                if (decimal.TryParse(txt_Summ.Text.Replace(",", ""), out decimal totalAmount))
                {
                    // Tính tiền thối lại
                    decimal changeAmount = customerMoney - totalAmount;

                    // Hiển thị tiền thối lại
                    txt_change.Text = changeAmount.ToString("N0");
                }
                else
                {
                    txt_change.Text = "0";
                }
            }
            else
            {
                txt_change.Text = "0";
            }
        }
    }
}

