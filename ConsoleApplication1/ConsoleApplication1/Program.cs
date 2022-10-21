using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class hinhtron
    {
        static void Main(string[] args)
        {
            int R;
            const double PI=3.1415 ;//khai bao hang so PI
            double S,C;
            Console.Write("NHAP VAO BAN KINH HINH TRON:");
            R=Convert.ToInt32(Console.ReadLine());
            S=PI*R*R;
            C=2*PI*R;
            Console.Write("CHU VI HINH TRON HINH TRON:{0:0.000}\n",C);
            Console.Write("DIEN TICH HINH TRON:{0:0.000}",S);
            Console.ReadLine();
        }
    }
}
