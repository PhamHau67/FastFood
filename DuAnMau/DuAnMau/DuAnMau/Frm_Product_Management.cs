using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DuAnMau
{
    public partial class Frm_Product_Management : Form
    {
        private Cl_conn clConn = new Cl_conn();
        public Frm_Product_Management()
        {

            InitializeComponent();
            LoadData_Dgv();
            Load_cbxData();
            cbx_Supplier_ID.SelectedIndex = -1;
            // Ẩn cột trống ở phía bên trái của DataGridView
            dgv_Product.RowHeadersVisible = false;

            dtp_pr_DateOfManufacture.Format = DateTimePickerFormat.Custom;
            dtp_pr_DateOfManufacture.CustomFormat = "dd/MM/yyyy";
            dtp_Expiration_Date.Format = DateTimePickerFormat.Custom;
            dtp_Expiration_Date.CustomFormat = "dd/MM/yyyy";


        }
        public void LoadData_Dgv()
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                //Viết câu lệnh truy vấn và join bảng
                var ListPr = from sp in db.SANPHAMs
                             join ncc in db.NHACUNGCAPs on sp.MaNhaCungCap equals ncc.MaNhaCungCap



                             select new
                             {
                                 sp.MaSanPham,
                                 sp.TenSanPham,
                                 sp.LoaiSanPham,
                                 sp.DonVi,
                                 sp.MoTaSanPham,
                                 sp.Tien,
                                 sp.SoLuong,
                                 sp.SoLuongConLai,
                                 sp.NSX,
                                 sp.HSD,
                                 TrangThai = sp.TrangThai ? "Đang còn" : "Đã hết",
                                 ncc.MaNhaCungCap,
                                 ncc.TenNhaCungCap
                             };

                dgv_Product.DataSource = ListPr.ToList();
                dgv_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgv_Product.Columns["MaSanPham"].HeaderText = "Product Code"; // Mã Sản Phẩm
                dgv_Product.Columns["TenSanPham"].HeaderText = "Product Name"; // Tên Sản Phẩm
                dgv_Product.Columns["LoaiSanPham"].HeaderText = "Product Category"; // Loại Sản Phẩm
                dgv_Product.Columns["DonVi"].HeaderText = "Unit"; // Đơn Vị
                dgv_Product.Columns["MoTaSanPham"].HeaderText = "Product Description"; // Mô Tả Sản Phẩm
                dgv_Product.Columns["Tien"].HeaderText = "Price"; // Tiền
                dgv_Product.Columns["SoLuong"].HeaderText = "Quantity"; // Số Lượng
                dgv_Product.Columns["SoLuongConLai"].HeaderText = "Remaining Quantity"; // Số Lượng Còn Lại
                dgv_Product.Columns["NSX"].HeaderText = "Manufacture Date"; // Ngày Sản Xuất
                dgv_Product.Columns["HSD"].HeaderText = "Expiry Date"; // Hạn Sử Dụng
                dgv_Product.Columns["TrangThai"].HeaderText = "Status"; // Trạng Thái
                dgv_Product.Columns["MaNhaCungCap"].HeaderText = "Supplier Code"; // Mã Nhà Cung Cấp
                dgv_Product.Columns["TenNhaCungCap"].HeaderText = "Supplier Name"; // Tên Nhà Cung Cấp

            }
        }
            //Sự kiện để cho thay đổi cbx thì 

            private void cbx_Supplier_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Supplier_ID.SelectedValue != null)
            {
                using (var db = new DataClasses1DataContext(clConn.conn))
                {
                    var supplier = (from ncc in db.NHACUNGCAPs
                                    where ncc.MaNhaCungCap == cbx_Supplier_ID.SelectedValue.ToString()
                                    select ncc).FirstOrDefault();

                    if (supplier != null)
                    {
                        txt_Supplier_Name.Text = supplier.TenNhaCungCap;
                    }
                }
            }
        }
        public void Load_cbxData()
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var suppliers = from ncc in db.NHACUNGCAPs
                                select new
                                {
                                    ncc.MaNhaCungCap,
                                    ncc.TenNhaCungCap
                                };

                cbx_Supplier_ID.DataSource = suppliers.ToList();
                cbx_Supplier_ID.ValueMember = "MaNhaCungCap";
                cbx_Supplier_ID.DisplayMember = "MaNhaCungCap";
            }
        }



        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Product_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ click vào các biến
                DataGridViewRow row = dgv_Product.Rows[e.RowIndex];


                txt_pr_Name.Text = row.Cells["TenSanPham"].Value.ToString();
                txt_pr_Type.Text = row.Cells["LoaiSanPham"].Value.ToString();
                txt_pr_Unit.Text = row.Cells["DonVi"].Value.ToString();
                txt_pr_Description.Text = row.Cells["MoTaSanPham"].Value.ToString();
                // Định dạng số tiền
                if (row.Cells["Tien"].Value != null && decimal.TryParse(row.Cells["Tien"].Value.ToString(), out decimal money))
                {
                    txt_pr_Money.Text = money.ToString("N0"); // Định dạng tiền tệ với dấu phân cách hàng nghìn
                }
                txt_pr_Quantity.Text = row.Cells["SoLuong"].Value.ToString();
                txt_pr_Quantity_Remaining.Text = row.Cells["SoLuongConLai"].Value.ToString();
                dtp_pr_DateOfManufacture.Value = Convert.ToDateTime(row.Cells["NSX"].Value);
                dtp_Expiration_Date.Value = Convert.ToDateTime(row.Cells["HSD"].Value);
                txt_Supplier_Name.Text = row.Cells["TenNhaCungCap"].Value.ToString();
                cbx_Supplier_ID.SelectedValue = row.Cells["MaNhaCungCap"].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add data? ", "Confirm AddData", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var db = new DataClasses1DataContext(clConn.conn))
                    {

                        Random random = new Random();
                        string newID;

                        do
                        {
                            newID = "SP" + random.Next(100, 990).ToString();
                        } while (db.SANPHAMs.Any(sp => sp.MaSanPham == newID));


                        string TenSP = txt_pr_Name.Text.Trim();
                        string LoaiSP = txt_pr_Type.Text.Trim();
                        string DonViSP = txt_pr_Unit.Text.Trim();
                        string MoTaSP = txt_pr_Description.Text.Trim();
                        string Tien = txt_pr_Money.Text.Trim();
                        string SL_SP = txt_pr_Quantity.Text.Trim();
                        string SLConLaiSP = txt_pr_Quantity_Remaining.Text.Trim();
                        DateTime NSX = dtp_pr_DateOfManufacture.Value;
                        DateTime HSD = dtp_Expiration_Date.Value;
                        string MaNhaCC = cbx_Supplier_ID.SelectedValue?.ToString();
                        // Kiểm tra xem có trống thông tin không
                        if (string.IsNullOrEmpty(TenSP) || string.IsNullOrEmpty(LoaiSP) ||
                            string.IsNullOrEmpty(DonViSP) || string.IsNullOrEmpty(MoTaSP) ||
                            string.IsNullOrEmpty(Tien) || string.IsNullOrEmpty(SL_SP) ||
                            string.IsNullOrEmpty(SLConLaiSP) || NSX == DateTime.MinValue ||
                            HSD == DateTime.MinValue || string.IsNullOrEmpty(MaNhaCC))
                        {
                            MessageBox.Show("Please complete all information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // kiểu tra ngày ngày sản xuất lúc thêm vào sẽ ko bị lớn hơn hạn sửa dụng
                        if (NSX > HSD)
                        {
                            MessageBox.Show("Manufacture Date cannot be later than Expiry Date!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // kiểm tra định dạng của tiền, sl, sl còn lại
                        decimal dt_tien;
                        int dt_sl, dt_slConLai;
                        if (!decimal.TryParse(Tien, out dt_tien) || dt_tien < 0 ||
                            !int.TryParse(SL_SP, out dt_sl) || dt_sl < 0 ||
                            !int.TryParse(SLConLaiSP, out dt_slConLai) || dt_slConLai < 0)
                        {
                            MessageBox.Show("Please enter the correct number format for Amount, Amount and Remaining Amount! They must be positive numbers.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        //Thực thi werry thêm dữ liệu
                        var newProduct = new SANPHAM
                        {
                            MaSanPham = newID,
                            TenSanPham = TenSP,
                            LoaiSanPham = LoaiSP,
                            DonVi = DonViSP,
                            MoTaSanPham = MoTaSP,
                            Tien = dt_tien,
                            SoLuong = dt_sl.ToString(),
                            SoLuongConLai = dt_slConLai.ToString(),
                            NSX = NSX,
                            HSD = HSD,
                            TrangThai = true,
                            MaNhaCungCap = MaNhaCC
                        };



                        db.SANPHAMs.InsertOnSubmit(newProduct);
                        db.SubmitChanges();

                        LoadData_Dgv();
                        MessageBox.Show("Add Product Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_refesh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to refresh??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                txt_pr_Name.Text = string.Empty;
                txt_pr_Type.Text = string.Empty;
                txt_pr_Unit.Text = string.Empty;
                txt_pr_Description.Text = string.Empty;
                txt_pr_Money.Text = string.Empty;
                txt_pr_Quantity.Text = string.Empty;
                txt_pr_Quantity_Remaining.Text = string.Empty;
                dtp_pr_DateOfManufacture.Value = DateTime.Now;
                dtp_Expiration_Date.Value = DateTime.Now;
                txt_Supplier_Name.Text = string.Empty;
                cbx_Supplier_ID.SelectedIndex = -1;


                LoadData_Dgv();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var db = new DataClasses1DataContext(clConn.conn))
                    {
                        string maSanPham = dgv_Product.CurrentRow.Cells["MaSanPham"].Value.ToString();
                        var product = db.SANPHAMs.FirstOrDefault(sp => sp.MaSanPham == maSanPham);

                        if (product != null)
                        {

                            var relatedDetails = db.CHITIET_HOADONs.Where(ct => ct.MaSanPham == maSanPham).ToList();
                            db.CHITIET_HOADONs.DeleteAllOnSubmit(relatedDetails);
                            db.SANPHAMs.DeleteOnSubmit(product);
                            db.SubmitChanges();

                            MessageBox.Show("Delete product and related order details successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData_Dgv();
                        }
                        else
                        {
                            MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_repair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update this product?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var db = new DataClasses1DataContext(clConn.conn))
                    {
                        string maSanPham = dgv_Product.CurrentRow.Cells["MaSanPham"].Value.ToString();
                        var pr = db.SANPHAMs.FirstOrDefault(sp => sp.MaSanPham == maSanPham);


                            string TenSP = txt_pr_Name.Text.Trim();
                            string LoaiSP = txt_pr_Type.Text.Trim();
                            string DonViSP = txt_pr_Unit.Text.Trim();
                            string MoTaSP = txt_pr_Description.Text.Trim();
                            string Tien = txt_pr_Money.Text.Trim();
                            string SL_SP = txt_pr_Quantity.Text.Trim();
                            string SLConLaiSP = txt_pr_Quantity_Remaining.Text.Trim();
                            DateTime NSX = dtp_pr_DateOfManufacture.Value;
                            DateTime HSD = dtp_Expiration_Date.Value;
                            string MaNhaCC = cbx_Supplier_ID.SelectedValue?.ToString();

                            // Kiểm tra xem có trống thông tin không
                            if (string.IsNullOrEmpty(TenSP) || string.IsNullOrEmpty(LoaiSP) ||
                                string.IsNullOrEmpty(DonViSP) || string.IsNullOrEmpty(MoTaSP) ||
                                string.IsNullOrEmpty(Tien) || string.IsNullOrEmpty(SL_SP) ||
                                string.IsNullOrEmpty(SLConLaiSP) || NSX == DateTime.MinValue ||
                                HSD == DateTime.MinValue || string.IsNullOrEmpty(MaNhaCC))
                            {
                                MessageBox.Show("Please complete all information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        // kiểu tra ngày ngày sản xuất lúc thêm vào sẽ ko bị lớn hơn hạn sửa dụng
                        if (NSX > HSD)
                        {
                            MessageBox.Show("Manufacture Date cannot be later than Expiry Date!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // kiểm tra định dạng của tiền, sl, sl còn lại
                        decimal dt_tien;
                        int dt_sl, dt_slConLai;
                        if (!decimal.TryParse(Tien, out dt_tien) || dt_tien < 0 ||
                            !int.TryParse(SL_SP, out dt_sl) || dt_sl < 0 ||
                            !int.TryParse(SLConLaiSP, out dt_slConLai) || dt_slConLai < 0)
                        {
                            MessageBox.Show("Please enter the correct number format for Amount, Amount and Remaining Amount! They must be positive numbers.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Cập nhật thông tin sản phẩm
                        pr.TenSanPham = TenSP;
                            pr.LoaiSanPham = LoaiSP;
                            pr.DonVi = DonViSP;
                            pr.MoTaSanPham = MoTaSP;
                            pr.Tien = dt_tien;
                            pr.SoLuong = dt_sl.ToString();
                            pr.SoLuongConLai = dt_slConLai.ToString();
                            pr.NSX = NSX;
                            pr.HSD = HSD;
                            pr.MaNhaCungCap = MaNhaCC;

                            db.SubmitChanges();

                            LoadData_Dgv();
                            MessageBox.Show("Update product successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var keyword = txt_Search.Text.Trim();

                var TimFr = from sp in db.SANPHAMs
                            where sp.TenSanPham.Contains(keyword) || sp.MaSanPham.Contains(keyword) || sp.MoTaSanPham.Contains(keyword)
                            join ncc in db.NHACUNGCAPs on sp.MaNhaCungCap equals ncc.MaNhaCungCap

                            select new
                            {
                                sp.MaSanPham,
                                sp.TenSanPham,
                                sp.LoaiSanPham,
                                sp.DonVi,
                                sp.MoTaSanPham,
                                sp.Tien,
                                sp.SoLuong,
                                sp.SoLuongConLai,
                                sp.NSX,
                                sp.HSD,
                                TrangThai = sp.TrangThai ? "Đang còn" : "Đã hết",
                                ncc.MaNhaCungCap,
                                ncc.TenNhaCungCap
                            };

                dgv_Product.DataSource = TimFr.ToList();
            }
        }

        private void dgv_Product_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // đổi định dạng tiền
            if (dgv_Product.Columns[e.ColumnIndex].Name == "Tien" && e.Value != null)
            {
                if (e.Value is decimal)
                {
                    decimal price = (decimal)e.Value;
                    e.Value = price.ToString("N0"); // Định dạng tiền tệ với dấu phân cách hàng nghìn
                    e.FormattingApplied = true;
                }
            }
            // đổi dindhj dạng d/m/y
            if ((dgv_Product.Columns[e.ColumnIndex].Name == "NSX" || dgv_Product.Columns[e.ColumnIndex].Name == "HSD") && e.Value != null)
            {
                if (e.Value is DateTime date)
                {
                    e.Value = date.ToString("dd/MM/yyyy"); 
                    e.FormattingApplied = true;
                }
            }

        }
    }
}
