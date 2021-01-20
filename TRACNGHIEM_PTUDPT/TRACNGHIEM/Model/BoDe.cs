using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRACNGHIEM.Model
{
    class BoDe
    {
        private String maCH;
        private String noiDung;
        private String loaiCH;
        private String dapAn;
        private String maMH;
        private String maTD;
        private String maGV;
        //private LuaChon luaChon;
        private String A;
        private String B;
        private String C;
        private String D;
   


        public string MaCH { get => maCH; set => maCH = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string LoaiCH { get => loaiCH; set => loaiCH = value; }
        public string DapAn { get => dapAn; set => dapAn = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public string MaTD{ get => maTD; set => maTD = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string DapAnA { get => A; set => A = value; }
        public string DapAnB { get => B; set => B = value; }
        public string DapAnC { get => C; set => C = value; }
        public string DapAnD { get => D; set => D = value; }
        
        //public LuaChon LuaChon { get => luaChon; set => luaChon = value; }
        public static List<BoDe> thithu;

        public static List<BoDe> boDe;
        public BoDe(string maCH, string noiDung, string loaiCH, string dapAn, string maMH, string maTD ,
            string maGV)
        {
            this.maCH = maCH;
            this.noiDung = noiDung;
            this.loaiCH = loaiCH;
            this.dapAn = dapAn;
            this.maMH = maMH;
            this.maTD = maTD;
            this.maGV = maGV;
        
            Program.myReader.Close();
            DataTable lc = Program.ExecSqlDataTable("EXEC SP_GET_LUA_CHON '" + maCH + "'");
            List<LuaChon> listLC = convertToListLC(lc);
            LuaChon.lc = listLC;
            LuaChon[] arrluachon = listLC.ToArray();
            
            this.A = arrluachon[0].NoiDung;
            this.B = arrluachon[1].NoiDung;
            this.C = arrluachon[2].NoiDung;
            this.D = arrluachon[3].NoiDung;
            
            
        }
        private List<LuaChon> convertToListLC(DataTable ds)
        {
            List<LuaChon> list = new List<LuaChon>();
            foreach (DataRow row in ds.Rows)
            {
                LuaChon lc = new LuaChon(
                    
                    row["NOIDUNG"].ToString()

                    );
                list.Add(lc);
            }
            return list;
        }

    }
}
