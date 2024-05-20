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
                            select nv;
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã nhân viên");
                dt.Columns.Add("Tên nhân viên");
                dt.Columns.Add("CCCD");
                dt.Columns.Add("Mã bộ phận");
                dt.Columns.Add("Mã vai trò");
                dt.Columns.Add("Ngày sinh");
                dt.Columns.Add("Giới tính");
                dt.Columns.Add("Số điện thoại");
                dt.Columns.Add("Ngày đăng kí");
                dt.Columns.Add("Gmail");
                dt.Columns.Add("Trạng thái");
                foreach (var item in query)
                {
                    dt.Rows.Add(item.MaNhanVien, item.TenNhanVien, item.CCCD, item.MaBoPhan, item.MaVaiTro, item.NgaySinh, item.GioiTinh, item.SDT, item.NgayDangKi, item.Gmail, item.TrangThai); ;
                }
                dgv_staff.DataSource = dt;
            }
        }
        
        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_staff.Rows[e.RowIndex];
                txt_IDStaff.Text = row.Cells["Mã nhân viên"].Value.ToString();
                txt_NameStaff.Text = row.Cells["Tên nhân viên"].Value.ToString();
                txt_CCCD.Text = row.Cells["CCCD"].Value.ToString();
                txt_IDDepartment.Text = row.Cells["Mã bộ phận"].Value.ToString();
                txt_IDRole.Text = row.Cells["Mã vai trò"].Value.ToString();
                dtp_Birthday.Value = DateTime.Parse(row.Cells["Ngày sinh"].Value.ToString());
                bool isMale;
                if (bool.TryParse(row.Cells["Giới tính"].Value.ToString(), out isMale))
                {
                    rdo_Male.Checked = isMale;
                    rdo_Female.Checked = !isMale;
                }
                txt_PhoneNumber.Text = row.Cells["Số điện thoại"].Value.ToString();
                dtp_SignUpDay.Value = DateTime.Parse(row.Cells["Ngày đăng kí"].Value.ToString());
                txt_Gmail.Text = row.Cells["Gmail"].Value.ToString();
                bool stillWorking;
                if (bool.TryParse(row.Cells["Trạng thái"].Value.ToString(), out stillWorking))
                {
                    rdo_StillWorking.Checked = stillWorking;
                    rdo_Leave.Checked = !stillWorking;
                }
            }
        }
    }
}
