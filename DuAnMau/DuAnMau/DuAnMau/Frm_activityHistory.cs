using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMau
{
    public partial class Frm_activityHistory : Form
    {
        private Cl_conn clConn = new Cl_conn();
        public Frm_activityHistory()
        {
            InitializeComponent();
            Load_dgv_activity();
            cbo_counter.Items.Add("A1");
            cbo_counter.Items.Add("B2");
            cbo_shift.Items.Add("CK001");
            cbo_shift.Items.Add("CK002");
            cbo_shift.Items.Add("CK003");
            cbo_shift.Items.Add("CK004");
            cbo_shift.Items.Add("CK005");
            cbo_status.Items.Add("Có mặt");
            cbo_status.Items.Add("Vắng");

            // Add event handlers
            cbo_shift.SelectedIndexChanged += new EventHandler(FilterChanged);
            cbo_counter.SelectedIndexChanged += new EventHandler(FilterChanged);
            cbo_status.SelectedIndexChanged += new EventHandler(FilterChanged);
        }

        public void Load_dgv_activity()
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var query = from nv in db.NHAN_VIENs
                            join nvc in db.NHANVIEN_CAKIPs on nv.MaNhanVien equals nvc.MaNhanVien
                            join ck in db.CAKIPs on nvc.MaCaKip equals ck.MaCaKip
                            select new
                            {
                                nvc.MaCaKip,
                                ck.GioBatDau,
                                ck.GioKetThuc,
                                nvc.MaNhanVien,
                                nv.TenNhanVien,
                                nvc.Quay,
                                nvc.NgayLam,
                                nvc.TrangThai
                            };
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã ca kíp");
                dt.Columns.Add("Giờ bắt đầu");
                dt.Columns.Add("Giờ kết thúc");
                dt.Columns.Add("Mã nhân viên");
                dt.Columns.Add("Tên nhân viên");
                dt.Columns.Add("Quầy");
                dt.Columns.Add("Ngày làm");
                dt.Columns.Add("Trạng thái");
                foreach (var item in query)
                {
                    string trangThai = (bool)item.TrangThai ? "Có mặt" : "Vắng";
                    dt.Rows.Add(item.MaCaKip, item.GioBatDau, item.GioKetThuc, item.MaNhanVien, item.TenNhanVien, item.Quay, item.NgayLam, trangThai);
                }

                dgv_LichSu.DataSource = dt;
            }
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            using (var db = new DataClasses1DataContext(clConn.conn))
            {
                var keyword = txt_find.Text.Trim();
                var shiftFilter = cbo_shift.SelectedItem?.ToString();
                var counterFilter = cbo_counter.SelectedItem?.ToString();
                var statusFilter = cbo_status.SelectedItem?.ToString();

                var findnv = from nv in db.NHAN_VIENs
                             join nvc in db.NHANVIEN_CAKIPs on nv.MaNhanVien equals nvc.MaNhanVien
                             join ck in db.CAKIPs on nvc.MaCaKip equals ck.MaCaKip
                             where (string.IsNullOrEmpty(keyword) || nv.MaNhanVien.Contains(keyword) || ck.MaCaKip.Contains(keyword) || nv.TenNhanVien.Contains(keyword) || nvc.Quay.Contains(keyword) || nvc.NgayLam.ToString().Contains(keyword))
                                && (string.IsNullOrEmpty(shiftFilter) || nvc.MaCaKip == shiftFilter)
                                && (string.IsNullOrEmpty(counterFilter) || nvc.Quay == counterFilter)
                                && (string.IsNullOrEmpty(statusFilter) || (statusFilter == "Có mặt" && nvc.TrangThai == true) || (statusFilter == "Vắng" && nvc.TrangThai == false))
                             select new
                             {
                                 ck.MaCaKip,
                                 ck.GioBatDau,
                                 ck.GioKetThuc,
                                 nv.MaNhanVien,
                                 nv.TenNhanVien,
                                 nvc.Quay,
                                 nvc.NgayLam,
                                 TrangThai = (bool)nvc.TrangThai ? "Có mặt" : "Vắng",
                             };

                dgv_LichSu.DataSource = findnv.ToList();
            }
        }

       

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            txt_find.Clear();
            cbo_shift.SelectedIndex = -1;
            cbo_counter.SelectedIndex = -1;
            cbo_status.SelectedIndex = -1;


            Load_dgv_activity();
        }
    }
}
