using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tien_Dien
    {
        class Program
        {
            static void Main(string[] args)
            {
            const int GTD1 = 1650, GTD2 = 1734, GTD3 = 2014;
            const int Bac1 = 50, Bac2 = 100, Bac3 = 150;
            double TienDien;

            Console.WriteLine("So Nha :");
            string so_nha = Console.ReadLine();
            Console.WriteLine("Ho va Ten Khach Hang :");
            string ho_va_ten = Console.ReadLine();
            Console.WriteLine("Ma Do Dong Ho :");
            string ma_so_dong_ho = Console.ReadLine();

            Console.WriteLine("Chi so dau :");
            double csd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chi so cuoi:");
            double csc = Convert.ToDouble(Console.ReadLine());

            double kw = csc - csd;
            if ((kw > 0) && (kw <= Bac1))
                TienDien = GTD1 * kw;
            else
                if (kw <= Bac2)
                TienDien = (Bac1 * GTD1) + (kw - Bac1) * GTD2;
            else
                TienDien = (Bac1 * GTD1) + (Bac2 * GTD2) + (kw - Bac2) * GTD3;
            Console.WriteLine("so tien phai tra {0}", TienDien);
            Console.ReadLine();

        }
    }
}