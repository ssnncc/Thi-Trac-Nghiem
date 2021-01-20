using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRACNGHIEM.Model
{
    class CT_BaiThi
    {
        private int idCTBaiThi;
        private int idBangDiem;
        private String cauHoi;
        private int thuTu;
        private String noiDung;
        private String A;
        private String B;
        private String C;
        private String D;
        private String dapAnDung;
        private String dapAnDaChon = "";
        //private int idLBT;
        public static ArrayList thithu = new ArrayList();
        public static ArrayList ct_baiThi = new ArrayList();
        //public CT_BaiThi(int idCTBaiThi, int idBangDiem, string cauHoi, int thuTu, String noiDung, String A, String B, String C, String D, String dapAnDung, String dapAnDaChon)
        //{
        //    this.idCTBaiThi = idCTBaiThi;
        //    this.idBangDiem = idBangDiem;
        //    this.cauHoi = cauHoi;
        //    this.thuTu = thuTu;
        //    this.noiDung = noiDung;
        //    this.A = A;
        //    this.B = B;
        //    this.C = C;
        //    this.D = D;
        //    this.dapAnDung = dapAnDung;
        //    this.dapAnDaChon = dapAnDaChon;
        //}

        //public CT_BaiThi(int idBangDiem, string cauHoi, int thuTu, String noiDung, String A, String B, String C, String D, String dapAnDung, String dapAnDaChon)
        //{
            
        //    this.idBangDiem = idBangDiem;
        //    this.cauHoi = cauHoi;
        //    this.thuTu = thuTu;
        //    this.noiDung = noiDung;
        //    this.A = A;
        //    this.B = B;
        //    this.C = C;
        //    this.D = D;
        //    this.dapAnDung = dapAnDung;
        //    this.dapAnDaChon = dapAnDaChon;
        //}
        public CT_BaiThi(string cauHoi, string dapAnChon)
        {
            this.cauHoi = cauHoi;
            this.dapAnDaChon = dapAnChon;
            //this.idLBT = idLBT;
        }
        public int getIdCTBaiThi()
        {
            return idCTBaiThi;
        }

        public int getIdBangDiem()
        {
            return idBangDiem;
        }

        public string getCauHoi()
        {
            return cauHoi;
        }

        public int getThuTu()
        {
            return thuTu;
        }

        public String getNoiDung()
        {
            return noiDung;
        }

        public String getDapAnDung()
        {
            return dapAnDung;
        }

        public String getDapAnDaChon()
        {
            return dapAnDaChon;
        }
        //public int getIDLBT()
        //{
        //    return idLBT;
        //}
        public CT_BaiThi(string cauHoi, int thuTu, String noiDung, String A, String B, String C, String D, String dapAnDung, String dapAnDaChon)
        {

            this.cauHoi = cauHoi;
            this.thuTu = thuTu;
            this.noiDung = noiDung;
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.dapAnDung = dapAnDung;
            this.dapAnDaChon = dapAnDaChon;
            
        }

        public void setIdBangDiem(int idBangDiem)
        {
            this.idBangDiem = idBangDiem;
        }
        public void setDapDaChon(String dapAn)
        {
            this.dapAnDaChon = dapAn;
        }
    }
}
