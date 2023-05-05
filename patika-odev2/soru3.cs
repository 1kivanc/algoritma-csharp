//Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

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
            Console.WriteLine("bir cümle gir");
            string cumle = Console.ReadLine();

            char[] sesliHarf = new char[cumle.Length];

            int sesliHarfSayi = 0; 

            foreach(char c in cumle)
            {
                if ("aeiouAEIOU".Contains(c)){

                    sesliHarf[sesliHarfSayi] = c;
                    sesliHarfSayi++;
                }
            }
            Array.Sort(sesliHarf, 0, sesliHarfSayi);

            Console.WriteLine("sesli harfler: ");
            for(int i= 0; i < sesliHarfSayi; i++)
            {
                Console.WriteLine("{0}", sesliHarf[i]);
            }
            Console.ReadLine();
        }
    }
}
