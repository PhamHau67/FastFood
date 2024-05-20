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

namespace DuAnMau
{
    public partial class Frm_employeeManager : Form
    {
        private string _con = "Data Source=DESKTOP-R9SVLJT\\HUNG;Initial Catalog=FastFoodDB;Integrated Security=True";
        public Frm_employeeManager()
        {
            InitializeComponent();
            Load_dgv_manager();
        }
        public void Load_dgv_manager()
        {
            using (var db = new DataClasses1DataContext(_con))
            {
                var query = from nv in db.NHAN_VIENs
                                   select new
                                   {
                                       nv.MaNhanVien,
                                       nv.TenNhanVien,
                                       nv.CCCD,
                                       nv.MaBoPhan,
                                       nv.MaVaiTro,
                                       nv.NgaySinh,
                                       nv.GioiTinh,
                                       nv.SDT,
                                       nv.NgayDangKi,
                                       nv.Gmail,
                                       nv.TrangThai
                                   };

                dgv_staff.DataSource = query.ToList();
            }
        }
    }
}
