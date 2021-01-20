using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRACNGHIEM.Model
{
    class BangDiem
    {
        
        private String maSV;
        private Double diem;
     

        
        public string MaSV { get => maSV; set => maSV = value; }
        public double Diem { get => diem; set => diem = value; }

        public static List<BangDiem> bd;


        public BangDiem( double diem)
        {
            this.diem = diem;
        }
       
    }
}
