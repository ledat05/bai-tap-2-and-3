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
                // Câu a
                Console.OutputEncoding = Encoding.UTF8;
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
                Tong.ToiGian();
                Console.WriteLine("Xuat Ket Qua:[{0}/{1}] + [{2}/{3}] = [{4}/{5}]",
                    S1.gettuso(),S1.getmauo(),S2.gettuso(),S2.getmauo(),Tong.gettuso(),Tong.getmauo());
                PhanSo Tru = S1.Tru(S2);
                Tru.ToiGian();
                Console.WriteLine("Xuat Ket Qua:[{0}/{1}] - [{2}/{3}] = [{4}/{5}]",
                    S1.gettuso(), S1.getmauo(), S2.gettuso(), S2.getmauo(), Tru.gettuso(), Tru.getmauo());
                PhanSo Tich = S1.Tich(S2);
                Tich.ToiGian();
                Console.WriteLine("Xuat Ket Qua:[{0}/{1}] * [{2}/{3}] = [{4}/{5}]",
                    S1.gettuso(), S1.getmauo(), S2.gettuso(), S2.getmauo(), Tich.gettuso(), Tich.getmauo());
                PhanSo Thuong = S1.Tich(S2);
                Thuong.ToiGian();
                Console.WriteLine("Xuat Ket Qua:[{0}/{1}] / [{2}/{3}] = [{4}/{5}]",
                    S1.gettuso(), S1.getmauo(), S2.gettuso(), S2.getmauo(), Thuong.gettuso(), Thuong.getmauo());
                //Câu b
                Console.WriteLine("**Tính Toán dãy Phân Số:");
                Console.Write("Nhập vào số nguyên dương:");
                int n=int.Parse(Console.ReadLine());
                PhanSo S=new PhanSo(0,1);
                for (int i=0;i<n;i++)
                {
                    S = S.cong(new PhanSo(1, i));
                }
                Console.WriteLine("Kết quả dãy phân số: 1+1/2+1/3+...+1/n = {0}/{1}", S.gettuso(), S.getmauo());
                Console.ReadLine() ;
            }
        }
    }
}
