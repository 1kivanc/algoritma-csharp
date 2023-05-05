using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Console.WriteLine("Lütfen 20 adet sayı giriniz: ");
            for(int i = 0; i<20; i++)
            {
                Console.WriteLine("{0}. numarayı giriniz: ",i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);

            int kucukSayilar = 0;
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine("en kuçük {0}: {1} ",i+1,numbers[i]);
                kucukSayilar += numbers[i];

            }
            double kucukSayilarOrt = (double)kucukSayilar/3;
            Console.WriteLine("girilen en küçük 3 sayının ortalaması {0} ", kucukSayilarOrt);

            int buyukSayilar = 0;
            for(int i = 19; i>16; i--)
            {
                Console.WriteLine("en büyük {0}: {1}",20-i,numbers[i]);
                buyukSayilar += numbers[i];
            }
            double buyukSayilarOrt = (double)buyukSayilar / 3;
            Console.WriteLine("girilen en büyük 3 sayının ortalaması {0}", buyukSayilarOrt);

            Console.WriteLine("genel ortalam {0} ", (kucukSayilarOrt + buyukSayilarOrt) / 2);

            Console.ReadLine();
        }
    }
}
