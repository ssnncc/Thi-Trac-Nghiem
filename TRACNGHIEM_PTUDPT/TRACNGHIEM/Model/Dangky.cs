using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRACNGHIEM.Model
{
    class Dangky
    {
        private String maMH;
        private String maLop;
        private DateTime ngayThi;
        private String maNV;
        private String trinhDo;
        private int thoiGian;
        private int soCauThi;
        private int iddk;

        public static Dangky thithu;

        public static Dangky dangky;
        public string MaMH { get => maMH; set => maMH = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public DateTime NgayThi { get => ngayThi; set => ngayThi = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public int ThoiGian { get => thoiGian; set => thoiGian = value; }
        public int SoCauThi { get => soCauThi; set => soCauThi = value; }
        public int IDDK { get => iddk; set => iddk = value; }

        public Dangky(
           
            string maMH,
            string maLop,
            DateTime ngayThi,
            string maNV,
            string trinhDo,
            int thoiGian,
            int soCauThi)
        {
           
            this.maMH = maMH;
            this.maLop = maLop;
            this.ngayThi = ngayThi;
            this.maNV = maNV;
            this.trinhDo = trinhDo;
            this.ThoiGian = thoiGian;
            this.SoCauThi = soCauThi;
            
        }
    }
}
