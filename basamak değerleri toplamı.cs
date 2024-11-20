using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bir sayı girin");
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;
            while (sayi > 0)

            {
                toplam += sayi % 10;
                sayi /= 10;
            }

            Console.WriteLine("basamak değerlerinin toplamı" + toplam);
            Console.ReadLine();


        }
    }
}
