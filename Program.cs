// See https://aka.ms/new-console-template for more information
using System;
namespace GiaiPhuongTrinhBacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai Phuong Trinh Bac Nhat");
            Console.WriteLine("Cho phuong trinh a = a * x + b = 0', xin hay nhap:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("Phuong trinh co nghiem la: {0}!", solution);
            }
            else
            {
                if (b == 0)
                    {
                        Console.Write("Phuong trinh co nghiem la: x!");
                    }
                else
                    {
                        Console.Write("Phuong trinh vo nghiem!");
                    }
            }
        }
    }
}
