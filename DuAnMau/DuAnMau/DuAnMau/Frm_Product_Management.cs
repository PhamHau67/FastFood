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

namespace DuAnMau
{
    public partial class Frm_Product_Management : Form
    {
        string strConn = "Data Source=RUDEUS\\VVH;Initial Catalog=FastFoodDB;Integrated Security=True;";
        public Frm_Product_Management()
        {
            SqlDataAdapter _adt = null;
            InitializeComponent();
            LoadData_Dgv();
            SqlConnection _conn = null;
        }
        public void LoadData_Dgv()
        {
            using (var db = new DataClasses1DataContext(strConn))
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
                                 ncc.TenNhaCungCap
                             };

                dgv_Product.DataSource = ListPr.ToList();

                // Đổi tiếng viêt cột
                dgv_Product.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
                dgv_Product.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
                dgv_Product.Columns["LoaiSanPham"].HeaderText = "Loại Sản Phẩm";
                dgv_Product.Columns["DonVi"].HeaderText = "Đơn Vị";
                dgv_Product.Columns["MoTaSanPham"].HeaderText = "Mô Tả Sản Phẩm";
                dgv_Product.Columns["Tien"].HeaderText = "Tiền";
                dgv_Product.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgv_Product.Columns["SoLuongConLai"].HeaderText = "Số Lượng Còn Lại";
                dgv_Product.Columns["NSX"].HeaderText = "Ngày Sản Xuất";
                dgv_Product.Columns["HSD"].HeaderText = "Hạn Sử Dụng";
                dgv_Product.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgv_Product.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
            }
        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
