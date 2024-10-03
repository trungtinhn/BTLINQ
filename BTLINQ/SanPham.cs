using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLINQ
{
    public class SanPham : IEnumerable
    {
        private string maSP;
        private string tenSP;
        private int soLuong;
        private int donGia;
        private string xuatXu;
        private DateTime ngayHetHan;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }

        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public string XuatXu
        {
            get { return xuatXu; }
            set { xuatXu = value; }
        }

        public DateTime NgayHetHan
        {
            get { return ngayHetHan; }
            set { ngayHetHan = value; }
        }


        public SanPham()
        {
        }



        public SanPham(string maSP, string tenSP, int soLuong, int donGia, string xuatXu, DateTime ngayHetHan)
        {
            this.maSP=maSP;
            this.tenSP=tenSP;
            this.soLuong=soLuong;
            this.donGia=donGia;
            this.xuatXu=xuatXu;
            this.ngayHetHan=ngayHetHan;
        }

        public override bool Equals(object obj)
        {
            return obj is SanPham pham&&
                   maSP==pham.maSP&&
                   tenSP==pham.tenSP&&
                   soLuong==pham.soLuong&&
                   donGia==pham.donGia&&
                   xuatXu==pham.xuatXu&&
                   ngayHetHan==pham.ngayHetHan;
        }



        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
