using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinh
{
    class Program
    {
        static void Main(string[] args)
        {
            //goi den ham hien ten trong namespace_vidu
            //baitap.bai5.pheptinh();
            /*    vidu a= new vidu;--tao 1 bien: la the hien cua class da xay dung
             *    a.vidu1();--goi den ham can thuc hien:ten_bien.ten_ham; */
            //btvn.bai1.b1();
            //btvn.bai4.b4();

            /*string chon;
            Console.Write("moi ban chon bai tap : 1,2,3,4,5,...");
            chon = Console.ReadLine();
            switch(chon)
            {
                case "1":
                    btvn.bai1.b1();    break;
                case "2":
                    btvn.bai2.b2(); break;
                case "3":
                    btvn.bai3.b3(); break;
                case "4":
                    btvn.bai4.b4(); break;
                case "5":
                    btvn.bai5.b5(); break;
                case "6":
                    btvn.bai6.b6(); break;
                case "7":
                    btvn.bai7.b7(); break;
                case "8":
                    btvn.bai8.b8(); break;
                case "9":
                    btvn.bai9.b9(); break;
                case "10":
                    btvn.bai10.b10(); break;
                case "11":
                    btvn.bai11.b11(); break;
                case "12":
                    btvn.bai12.b12(); break;
                case "13":
                    btvn.bai13.b13(); break;
                case "14":
                    btvn.bai14.b14(); break;
                case "15":
                    btvn.bai15.b15(); break;
                default: Console.WriteLine("chua co bai tap ban can"); break;
            }*/
            baiktra.cau1.c1();
            Console.ReadKey();
        }
    }
    class vidu
    {
        public static void vidu1()
        { }
    }
}
namespace baitap
{
    class bai1
    {
        public static void cau()
        {
            int a, b,tong,min,max,tich;
            Console.Write("nhap a:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap b:");
            b = Convert.ToInt16(Console.ReadLine());
            tong = a + b;
            min = a > b ? b : a;
            max = a > b ? a : b;
            tich = a * b;
            Console.WriteLine("tong cua {0} , {1} la: {2}", a, b, tong);
            Console.WriteLine("min cua {0} , {1} la: {2}", a, b, min);
            Console.WriteLine("max cua {0} , {1} la: {2}", a, b, max);
            Console.WriteLine("tich cua {0} , {1} la: {2}", a, b, tich);
            Console.ReadLine();
        }
    }
    class bai2
    {
        public static void cau2()
        {
            int ndc;
            Console.Write("nhap nong do con:");
            ndc = Convert.ToInt16(Console.ReadLine());
            if (ndc <= 50)
                Console.WriteLine("phat 1 trieu");
            else if (ndc <= 100)
                Console.WriteLine("phat 3 trieu");
            else if (ndc <= 150)
                Console.WriteLine("phat 5 trieu");
            else
                Console.WriteLine("phat 10 trieu");
            Console.ReadKey();
        }
    }
    class bai3
    {
        public static void ptbac2()
        {
            double a, b, c, dlt, x1, x2;
            Console.Write("nhap a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap c :");
            c = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("pt ban nhap khong phai pt bac 2!");
            }
            if(a!=0)
            {
                dlt = b * b - 4 * a * c;
                if(dlt>0)
                {
                    x1 = (-b + Math.Sqrt(dlt)) / (2 * a);
                    x2 = (-b - Math.Sqrt(dlt)) / (2 * a);
                    Console.WriteLine("phuong trinh da cho co hai nghiem la :x1={0:0.00} va x2={1:0.00}",x1,x2);
                }
                else if(dlt==0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("phuong trinh co nghiem kep la x1=x2=",x1);
                }
                else
                {
                    Console.WriteLine("pt vo nghiem");
                }
            }
            Console.ReadKey();
        }
    }
    class bai4
    {
        public static void nhapso()
        {
            int a;
            Console.Write("nhap a:");
            a = Convert.ToInt16(Console.ReadLine());
            switch(a)
            {
                case 0: Console.WriteLine("ban vua nhap so khong"); break;
                case 1: Console.WriteLine("ban vua nhap so mot"); break;
                case 2: Console.WriteLine("ban vua nhap so hai"); break;
                case 3: Console.WriteLine("ban vua nhap so ba"); break;
                case 4: Console.WriteLine("ban vua nhap so bon"); break;
                case 5: Console.WriteLine("ban vua nhap so nam"); break;
                case 6: Console.WriteLine("ban vua nhap so sau"); break;
                case 7: Console.WriteLine("ban vua nhap so bay"); break;
                case 8: Console.WriteLine("ban vua nhap so tam"); break;
                case 9: Console.WriteLine("ban vua nhap so chin"); break;
                default: Console.WriteLine("ban nhap so ngoai khoang tu khong den chin!"); break;
            }
            Console.ReadKey();
        }
    }
    class bai5
    {
        public static void pheptinh()
        {
            int a,b;
            string pt,chon;
            do{
            Console.Write("nhap a:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap b:");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap phep tinh:");
            pt = Console.ReadLine();
            switch (pt)
            {
                case "+" :Console.WriteLine(" a + b = "+(a+b)); break;
                case "-" :Console.WriteLine(" a - b = "+(a-b)); break;
                case "*" :Console.WriteLine(" a * b = "+(a*b)); break;
                case "/" :Console.WriteLine(" a / b = "+(a/b)); break;
                default: Console.WriteLine("ban vua nhap sai phep tinh!"); break;
            }
            Console.Write("ban co muon tiep tuc k:");
            chon = Console.ReadLine();
            if(chon != "y" && chon!= "n"){ Console.Write("ban vua nhap sai tuy chon!");}
            }while(chon=="y");
            Console.ReadKey();
        }
    }
    class bai6
    {
        public static void nhap(int[] a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("nhap:");
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
        }
    }
}
namespace btvn
{
    class bai1
    {
        public static void b1()
        {
            //khai bao bien
            String masv, hoten,diachi;
            double  tin1, tin2, anh, tb ;
            //nhap du lieu
            Console.Write("nhap ma so sinh vien :");
            masv = Console.ReadLine();
            Console.Write("nhap ho ten :");
            hoten = Console.ReadLine();
            Console.Write("nhap dia chi sinh vien :");
            diachi = Console.ReadLine();
            Console.Write("nhap diem tin1 :");
            tin1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap diem tin2 :");
            tin2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap diem tieng anh :");
            anh = Convert.ToDouble(Console.ReadLine());
            // tinh diem trung binh
            tb = (tin1 + tin2 + anh) / 3;
            //in ket qua 
            Console.WriteLine("***********************");
            Console.WriteLine("MSSV :" + masv);
            Console.WriteLine("HO TEN :" + hoten);
            Console.WriteLine("DIEM TIN 1 :" + tin1);
            Console.WriteLine("DIEM TIN2 :" + tin2);
            Console.WriteLine("DIEM TIENG ANH :" + anh);
            Console.WriteLine("DIEM TRUNG BINH LA :{0:0.00}", tb);
            Console.ReadKey();
        }
    }
    class bai2
    {
        public static void b2()
        {
            string MAcb;
            int HSL, LCB;
            float BHYT, BHXH, BHTN, THUCLINH;
            Console.Write("nhap ma so can bo :");
            MAcb = Console.ReadLine();
            Console.Write("nhap he so luong :");
            HSL = Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap luong co ban :");
            LCB = Convert.ToInt16(Console.ReadLine());
            BHYT = 3 % LCB;
            BHXH = 15 % LCB;
            BHTN = 2 % LCB;
            THUCLINH = LCB - BHYT - BHXH - BHTN;
            Console.WriteLine("***********************");
            Console.WriteLine("bao hiem y te :" + BHYT);
            Console.WriteLine("bao hiem xa hoi :" + BHXH);
            Console.WriteLine("bao hiem that nghiep :" + BHTN);
            Console.WriteLine("thuc linh :" + THUCLINH);
            Console.ReadKey();
        }
    }
    class bai3
    {
        public static void b3()
        {
            int a, b, c, max, min;
            Console.Write("nhap a:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap b:");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap c:");
            c = Convert.ToInt16(Console.ReadLine());
            max = a > b ? a : b;
            max = max > c ? max : c;
            Console.WriteLine("max 3 so {0} , {1} , {2} la: {3}", a, b, c, max);
            min = a < b ? a : b;
            min = min > c ? c : min;
            Console.WriteLine("min 3 so la" + min);
            Console.ReadKey();
        }
    }
    class bai4
    {
        public static void b4()
        {
            int BL, NC;
            double PC, TL, NCTL;
            Console.Write("nhap bac luong:");
            BL = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap ngay cong:");
            NC = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap ghu cap:");
            PC = Convert.ToDouble(Console.ReadLine());
            if(NC<25 && NC>0)
            { NCTL = (double)NC;
            TL = BL * 1150000 * (double)NCTL + PC;
            Console.WriteLine("tien luong = " + TL);
            }
            else if(NC>=25 && NC<=31)
            { NCTL = ((double)NC - 25) * 2 + 25;
            TL = BL * 1150000 * (double)NCTL + PC;
            Console.WriteLine("tien luong = " + TL);
            }
            else { Console.Write("ban da nhap sai ngay cong"); }
            Console.ReadKey();
        }
    }
    class bai5
    {
        public static void b5()
        {
            int a;
            Console.Write("nhap vao so nguyen a :");
            a = Convert.ToInt16(Console.ReadLine());
            if (a % 2 == 0) 
                { Console.WriteLine("{0} la so chan",a); }
            else
                { Console.WriteLine("{0} la so le", a); }
            if (a > 0)
                { Console.WriteLine("{0} la so duong", a); }
            else if(a < 0)
                { Console.WriteLine("{0} la so am", a); }
            else
                { Console.WriteLine("{0} la khong la so am khong la so duong"); }
            Console.ReadKey();
        }
    }
    class bai6
    {
        public static void b6()
        {
            double a, b, c, chuvi, P, S;
            Console.Write("nhap canh 1 : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap canh 2 : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap canh 3 : ");
            c = Convert.ToDouble(Console.ReadLine());
            if((a+b)>c && (a+c)>b && (b+c)>a )
            { 
                chuvi = a + b + c;
                P = chuvi / 2;
                S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                Console.WriteLine("chu vi cua tam giac la : "+chuvi);
                Console.WriteLine("dien tich cua tam gia la : "+S);
            }
            else
            { 
                Console.WriteLine("ba canh ban vua nhap khong phai la ba canh cua tam giac ");
                Console.WriteLine("*luu y tong cua hai canh bat ki phai luon hon canh con lai*");
            }
        }
    }
    class bai7
    {
        public static void b7()
        {
            double a, b, c, dlt, x1, x2;
            Console.Write("nhap a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap c :");
            c = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("pt ban nhap khong phai pt bac 2!");
            }
            if (a != 0)
            {
                dlt = b * b - 4 * a * c;
                if (dlt > 0)
                {
                    x1 = (-b + Math.Sqrt(dlt)) / (2 * a);
                    x2 = (-b - Math.Sqrt(dlt)) / (2 * a);
                    Console.WriteLine("phuong trinh da cho co hai nghiem la :x1={0:0.00} va x2={1:0.00}", x1, x2);
                }
                else if (dlt == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("phuong trinh co nghiem kep la x1=x2=", x1);
                }
                else
                {
                    Console.WriteLine("pt vo nghiem");
                }
            }
            Console.ReadKey();
        }
    }
    class bai8
    {
        public static void b8()
        {
            int month, year;
            Console.Write("nhap thang :");
            month = Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap nam :");
            year = Convert.ToInt16(Console.ReadLine());
            switch (month)
            {
                case 1: Console.Write("thang 1 co 31 ngay"); break;
                case 2: if (year % 4 == 0)
                    { Console.Write("thang 2 co 29 ngay"); }
                    else { Console.Write("thang 2 co 28 ngay"); }
                    break;
                case 3: Console.Write("thang 3 co 31 ngay"); break;
                case 4: Console.Write("thang 4 co 30 ngay"); break;
                case 5: Console.Write("thang 5 co 31 ngay"); break;
                case 6: Console.Write("thang 6 co 30 ngay"); break;
                case 7: Console.Write("thang 7 co 31 ngay"); break;
                case 8: Console.Write("thang 8 co 31 ngay"); break;
                case 9: Console.Write("thang 9 co 30 ngay"); break;
                case 10: Console.Write("thang 10 co 31 ngay"); break;
                case 11: Console.Write("thang 11 co 30 ngay"); break;
                case 12: Console.Write("thang 12 co 31 ngay"); break;
                default: Console.Write("ban vau nhap sai thang!"); break;
            }
            Console.ReadKey();
        }
    }
    class bai9
    {
        public static void b9()
        {
            string chon;
            Console.Write("nhap ma mau ma ban thich : ");
            chon = Console.ReadLine();
            switch(chon)
            {
                case "1": Console.WriteLine("mau ban thich la mau do"); break;
                case "2": Console.WriteLine("mau ban thich la mau den"); break;
                case "3": Console.WriteLine("mau ban thich la mau trang"); break;
                case "4": Console.WriteLine("mau ban thich la mau xanh"); break;
                case "5": Console.WriteLine("mau ban thich la mau tim"); break;
                case "6": Console.WriteLine("mau ban thich la mau hong"); break;
                default: Console.WriteLine("ma mau ban vua nhap khong co trong bang mau"); break;
            }
        }
    }
    class bai10
    {
        public static void b10()
        {
            int n,a,tong=0;
            Console.Write("nhap n : ");
            n = Convert.ToInt16(Console.ReadLine());
            a=(-1)*n;
            for(int i=a; i<2; i++)
            {
                tong += i;
            }
            Console.WriteLine("tong cac so nguyen am trong khoang tu {0} den 1 la : {1}", a, tong);
        }
    }
    class bai11
    {
        public static void b11()
        {
            int[] a =new int[100];
            int i=0,tong=0;
            double tbc;
            //nhap vao mang so nguyen va dung lai khi nhap 0
            do
            {
                Console.Write("moi ban nhap so thu {0} =", i);
                a[i] = Convert.ToInt16(Console.ReadLine());
                i++;
                tong += a[i-1];
            } while (a[i-1]!= 0);
            tbc = (double)tong / (double)i;
            Console.WriteLine("tong cua day la :"+tong);
            Console.WriteLine("trung binh cong cua day la :" + tbc);
        }
    }
    class bai12
    {
        public static void b12()
        {
            int a,b,i;
            a = 1;
            b = 101;
            for( i=a; i<b; i++)
            {
                if (i%10 == 0) 
                {
                    Console.Write("  " + i);
                }
            }
        }
    }
    class bai13
    {
        public static void b13()
        {
            int a;
            Console.Write("nhap n : ");
            a = Convert.ToInt16(Console.ReadLine());
            int tich = 1;
            for(int i=1;i<=a;i++)
            {
                tich *= i;
                Console.WriteLine("i " + i);
                
            }
            Console.WriteLine("{0}! co gia tri la {1}",a,tich);
        }
    }
    class bai14
    {
        public static void b14()
        {
            string x;
            Console.Write("moi ban nhap bieu thuc can tinh : ");
            x = Console.ReadLine();
            switch(x)
            {
                case "1":
                    { 
                        double tong = 0;
                        for (int i = 0; i < 50; i++)
                        {
                            tong += (double)1 /(i*2 +1);
                        }
                        Console.WriteLine("gia tri cua bieu thuc (1 + 1/3 + 1/5 +....) la :{0:0.0000}",tong);
                    }   break;
                case "2":
                    {
                        double tong = 0;
                        for (int i = 0; i < 25; i++)
                        {
                            tong += (double)1 / (i * 4 + 1);
                        }
                        Console.WriteLine("gia tri cua bieu thuc (1 + 1/5 + 1/9 +....) la :{0:0.0000}", tong);
                    }   break;
                case "3":
                    {
                        double tong = 0;
                        for (int i = 1; i < 100; i++)
                        {
                            if (i % 2 == 0) { tong -= (double)1 / i; }
                            else { tong += (double)1 / i; }
                            
                        }
                        Console.WriteLine("gia tri cua bieu thuc (1 - 1/2 + 1/3 - 1/4 ....) la :{0:0.0000}", tong);
                    }   break;
                case "4":
                    {
                        int n;
                        Console.Write("nhap n :");
                        n = Convert.ToInt16(Console.ReadLine());
                        double tong = 0;
                        for (int i = 1; i <=n; i++)
                        {
                            tong += (double)1 / (i*i);
                        }
                        Console.WriteLine("gia tri cua bieu thuc (1 + 1/2^2 + 1/3^3 +....+1/n^2) la :{0:0.0000}", tong);
                    } break;
                case "5":
                    {
                        int n;
                        Console.Write("nhap n :");
                        n = Convert.ToInt16(Console.ReadLine());
                        double tong = 0;
                        int gt = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            gt *= i;
                            tong += (double)1 / gt;
                        }
                        Console.WriteLine("gia tri cua bieu thuc (1 + 1/2! + 1/3! +....+1/n!) la :{0:0.0000}", tong);
                    } break;
                case "6":
                    {   
                        int n;
                        Console.Write("nhap n :");
                        n = Convert.ToInt16(Console.ReadLine());
                        double tich = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            tich *= (double)(1 + (double)1 / (i * i));
                        }
                        Console.WriteLine("gia tri cua bieu thuc (1+(1/1^2)(1+(1/2^2)(1+(1/3^2)...(1+(1/n^2) la :{0:0.0000}", tich);
                    } break;
            }
        }
    }
    class bai15
    {
        public static void b15()
        {
            int nam;
            Console.Write("nhap nam : ");
            nam = Convert.ToInt16(Console.ReadLine());
            if (nam % 4 == 0) { Console.WriteLine("nam {0} la nam nhuan", nam); }
            else { Console.WriteLine("nam {0} khong phai la nam nhuan", nam); }
        }
    }
} 
namespace baiktra 
{
    class cau1
    {
        public static void c1()
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
            Console.WriteLine("ma sinh vien : "+ masv);
            Console.WriteLine("ho ten : "+hoten);
            Console.WriteLine("lop : "+lop);
            Console.WriteLine("ngay sinh : "+ngaysinh);
            Console.WriteLine("tuoi : "+tuoi);
        }
    }
    class cau2
    {
        public static void c2()
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
}
