using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
    class PhanSo
    {
        private int tuso;
        private int mauso;
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int tuso,int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void settuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int gettuso()
        {
            return tuso;
        }
        public void setmauso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getmauo()
        {
            return mauso;
        }
        public void ToiGian()
        {
            int uscln = TimUSCLN(tuso, mauso);
            tuso = tuso / uscln;
            mauso = mauso / uscln;
        }
        public PhanSo cong(PhanSo PS)
        {
            PhanSo Kq = new PhanSo();
            Kq.tuso = tuso * PS.mauso + PS.tuso * mauso;
            Kq.mauso = mauso *PS.mauso;
            return Kq;
        }
        public PhanSo Tru(PhanSo PS)
        {
            PhanSo Kq = new PhanSo();
            Kq.tuso = tuso * PS.mauso - PS.tuso * mauso;
            Kq.mauso = mauso * PS.mauso;
            return Kq;
        }
        public PhanSo Tich(PhanSo PS)
        {
            PhanSo Kq = new PhanSo();
            Kq.tuso = tuso * PS.mauso;
            Kq.mauso = mauso * PS.mauso;
            return Kq;
        }

        public PhanSo Thuong(PhanSo PS)
        {
            PhanSo Kq = new PhanSo();          
            Kq.tuso = tuso * PS.mauso;
            Kq.mauso = mauso * PS.tuso;
            return Kq;
        }

        private int TimUSCLN(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y) ;
            {
                if (x > y)
                {
                    x = x - y;
                }
                else;
                y = y - x;
            }
            return x;
        }
        class Program
        {
            static void Main(string[] args)
            {               
                Console.WriteLine("Nhập Tu So:");
                int tuso = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập Mau So:");
                int mauso = int.Parse(Console.ReadLine());
                PhanSo S1 = new PhanSo(tuso, mauso);
                S1.settuso(tuso);
                S1.setmauso(mauso);
                Console.WriteLine("Nhập Tu So 2:");
                tuso = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập Mau So 2:");
                mauso = int.Parse(Console.ReadLine());
                PhanSo S2 = new PhanSo(tuso, mauso);

                PhanSo Tong = S1.cong(S2);
                Console.WriteLine("Xuat Ket Qua:[{0}/{1}+[{2}/[{3}=[{4}/{5}]",
                    S1.gettuso(),S1.getmauo(),S2.gettuso(),S2.getmauo(),Tong.gettuso(),Tong.getmauo());
            }
        }
    }
}
