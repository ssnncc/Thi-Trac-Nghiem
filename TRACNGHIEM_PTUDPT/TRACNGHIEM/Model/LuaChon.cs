using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRACNGHIEM.Model
{
    class LuaChon
    {
        private int maLC;
        private String tenLC;
        private String maCH;
        private String noiDung;
    
        public int MaLC { get => maLC; set => maLC = value; }
        public string TenLC { get => tenLC; set => tenLC = value; }
        public string MaCH { get => maCH; set => maCH = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }

        public static List<LuaChon> lc;

        
        public LuaChon(int maLC, string tenLC, string maCH, string noiDung )
        {

            this.maCH = maCH;
            this.tenLC = tenLC;
            this.maCH = maCH;
            this.noiDung = noiDung;
            
            
        }
        public LuaChon(string noiDung)
        {
            this.noiDung = noiDung;
        }
        

    }
}
