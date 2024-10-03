using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLINQ
{
    public partial class Form1 : Form
    {

        List<SanPham> sanPhams = new List<SanPham>();
        List<SanPham> sanPhamTimKiems = new List<SanPham>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maSP = txt_MaSP.Text;
            string tenSP = txt_TenSp.Text;
            int soLuong = Int32.Parse(txt_SoLuong.Text);
            int donGia = Int32.Parse(txt_DonGia.Text);
            string xuatXu = txt_XuatXu.Text;
            DateTime ngayHetHan = dt_NgayHetHan.Value;

            SanPham sanPham = new SanPham(maSP, tenSP, soLuong, donGia, xuatXu, ngayHetHan);

            if (!sanPhams.Exists(x => x.MaSP == txt_MaSP.Text))
            {
                sanPhams.Add(sanPham);
                updateDataGridSP();
            }else
            {
                MessageBox.Show("Mã sản phẩm đã tồn lại!", "Thông báo");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt_NgayHetHan.Format = DateTimePickerFormat.Custom;
            dt_NgayHetHan.CustomFormat = "dd/MM/yyyy";
        }

        private void data_dsSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data_dsSP.Rows[e.RowIndex];

            txt_MaSP.Text = row.Cells["maSPCol"].Value.ToString();
            txt_TenSp.Text = row.Cells["tenSPCol"].Value.ToString();
            txt_SoLuong.Text = row.Cells["soLuongCol"].Value.ToString();
            txt_DonGia.Text = row.Cells["donGiaCol"].Value.ToString();
            txt_XuatXu.Text = row.Cells["xuatXuCol"].Value.ToString();
            dt_NgayHetHan.Text = row.Cells["ngayHetHanCol"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!ExistSP()) return;

            SanPham sanPham = sanPhams.Find(x => x.MaSP == txt_MaSP.Text);
            sanPhams.Remove(sanPham);

            updateDataGridSP();
        }

        private void updateDataGridSP()
        {
            data_dsSP.Rows.Clear();

            sanPhams.ForEach(item =>
            {
                data_dsSP.Rows.Add(item.MaSP, item.TenSP, item.SoLuong, item.DonGia, item.XuatXu, item.NgayHetHan);

            });
        }

        private void updateDataGridSPTimKiem()
        {
            data_TimKiem.Rows.Clear();

            sanPhamTimKiems.ForEach(item =>
            {
                data_TimKiem.Rows.Add(item.MaSP, item.TenSP, item.SoLuong, item.DonGia, item.XuatXu, item.NgayHetHan);

            });
        }

        private void btn_SP_DG_Click(object sender, EventArgs e)
        {
            sanPhamTimKiems.Clear();
            if (!ExistSP()) return;

            int donGiaCaoNhat = sanPhams.Max(p => p.DonGia);


            sanPhamTimKiems = sanPhams.Where(p => p.DonGia ==  donGiaCaoNhat).ToList();

            updateDataGridSPTimKiem();

        }

        private void btn_SP_NB_Click(object sender, EventArgs e)
        {
            sanPhamTimKiems.Clear();
            if (!ExistSP()) return;

            sanPhamTimKiems = sanPhams.Where(p => p.XuatXu ==  "Nhật Bản").ToList();
            updateDataGridSPTimKiem();
        }

        private void btn_SP_QH_Click(object sender, EventArgs e)
        {
            sanPhamTimKiems.Clear();
            if (!ExistSP()) return;

            sanPhamTimKiems = sanPhams.Where(p => p.NgayHetHan < DateTime.Now).ToList();
            updateDataGridSPTimKiem();
        }

        private void btn_SP_A_B_Click(object sender, EventArgs e)
        {
            sanPhamTimKiems.Clear();
            if (!ExistSP()) return;
            int minGia = Int32.Parse(txt_A.Text);
            int maxGia = Int32.Parse(txt_B.Text);

         
            sanPhamTimKiems = sanPhams.Where(p => p.DonGia >= minGia && p.DonGia <= maxGia).ToList();
            updateDataGridSPTimKiem();
        }

        private void btn_Xoa_XX_Click(object sender, EventArgs e)
        {
            if (!ExistSP()) return;
            List<SanPham> sanPhamXoas = sanPhams.Where(p => p.XuatXu == txt_XX_Xoa.Text).ToList();

            sanPhamXoas.ForEach(p => sanPhams.Remove(p));
            updateDataGridSP();
        }

        private void btn_Check_QH_Click(object sender, EventArgs e)
        {
            if (!ExistSP()) return;
            List<SanPham> sanPhamQuaHan = sanPhams.Where(p => p.NgayHetHan < DateTime.Now).ToList();

            MessageBox.Show($"Có {sanPhamQuaHan.Count} sản phẩm quá hạn", "Thông báo");
        }

        private void btn_Xoa_All_SP_Click(object sender, EventArgs e)
        {
            if (!ExistSP()) return;
            sanPhams.Clear();
            updateDataGridSP();
        }

        private void btn_Xoa_SP_QH_Click(object sender, EventArgs e)
        {
            if (!ExistSP()) return;
            List<SanPham> sanPhamQuaHan = sanPhams.Where(p => p.NgayHetHan < DateTime.Now).ToList();

            sanPhamQuaHan.ForEach(p => sanPhams.Remove(p));

            updateDataGridSP();
        }

        private bool ExistSP()
        {
            return sanPhams.Count != 0;
        }
    }
}
