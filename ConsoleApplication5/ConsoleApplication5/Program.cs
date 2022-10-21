using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon;
            string next;
            do{
            Console.Write("moi ban nhap cau can tinh  VD:1,2,3,4..... :");
            chon = Convert.ToInt16(Console.ReadLine());
            switch (chon)
            {
                case 1 :
                    cau1 xyz = new cau1();
                    xyz.c1();
                     break;
                case 2 : 
                    cau2 ab = new cau2();
                    ab.c2(); break;
                case 3 : 
                    A a1 = new A();
                    a1.nhap();break;
                case 4:
                    c4 s = new c4();
                    s.mang(); break;
                default: Console.Write("cau ban nhap hien khong co"); break;
            }
            
            Console.Write("ban co muon tiep tuc khong Y/N");
            next = Console.ReadLine();
            if (next != "y" && next != "n") { Console.Write("ban vua nhap sai tuy chon!"); }
            } while (next == "y");
            Console.ReadKey();
        }
    }
    class cau1
    {
        public void c1()
        {
            string masv, hoten, lop;
            int ngaysinh, tuoi;
            Console.Write("nhap ma sinh vien : ");
            masv = Console.ReadLine();
            Console.Write("nhap ho ten : ");
            hoten = Console.ReadLine();
            Console.Write("nhap lop : ");
            lop = Console.ReadLine();
            Console.Write("nhap ngay sinh : ");
            ngaysinh = Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap tuoi : ");
            tuoi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("*************************");
            Console.WriteLine("ma sinh vien : " + masv);
            Console.WriteLine("ho ten : " + hoten);
            Console.WriteLine("lop : " + lop);
            Console.WriteLine("ngay sinh : " + ngaysinh);
            Console.WriteLine("tuoi : " + tuoi);
        }
    }
    class cau2
    {
        public void c2()
        {
            int a, b;
            string pt, chon;
            do
            {
                Console.Write("nhap a:");
                a = Convert.ToInt16(Console.ReadLine());
                Console.Write("nhap b:");
                b = Convert.ToInt16(Console.ReadLine());
                Console.Write("nhap phep tinh:");
                pt = Console.ReadLine();
                switch (pt)
                {
                    case "+": Console.WriteLine(" a + b = " + (a + b)); break;
                    case "-": Console.WriteLine(" a - b = " + (a - b)); break;
                    case "*": Console.WriteLine(" a * b = " + (a * b)); break;
                    case "/": Console.WriteLine(" a / b = " + (a / b)); break;
                    default: Console.WriteLine("ban vua nhap sai phep tinh!"); break;
                }
                Console.Write("ban co muon tiep tuc k:");
                chon = Console.ReadLine();
                if (chon != "y" && chon != "n") { Console.Write("ban vua nhap sai tuy chon!"); }
            } while (chon == "y");
            Console.ReadKey();
        }
    }
    class A 
    {
        public int x { get; set; }
        public void nhap()
        {
            int x;
            Console.Write("nhap vao so nguyen bat ki : ");
            x = Convert.ToInt16(Console.ReadLine());
            B b1 = new B();
            b1.ktra(x);
        }
    }
    class B : A
    {
        public void ktra(int x)
        {
           if(x%2==0)
           {
               Console.WriteLine("so vua nhap la so chan");
           }
           else Console.WriteLine("so vua nhap la so le"); 
        }
    }
    class c4
    {
        public void mang()
        {
            int[] a = new int[100];
            int i = 0, tong = 0,duong=0,am=0,num,lap1=0;
            do
            {
                Console.Write("moi ban nhap so thu {0} =", i);
                a[i] = Convert.ToInt16(Console.ReadLine());
                i++;
                tong += a[i - 1];  
            } while (a[i - 1] != 0);
            for (i = 0; i <= 10; i++)
            {
                if (a[i] > 0) { duong++; }
                else if (a[i] < 0) { am++; }
                else break;
            }
            Console.Write("nhap so can kiem tra lan lap :");
            num = Convert.ToInt16(Console.ReadLine());
            for (i = 0; i <= 10; i++)
            {
                if (a[i] == num) { lap1++; }
            }
            Console.WriteLine("tong cua mang la :" + tong);
            Console.WriteLine("mang co {0} so duong ",duong);
            Console.WriteLine("mang co {0} so am ",am);
            Console.WriteLine("co {0} so {1} trong mang ",lap1,num);
        }
    }
}
