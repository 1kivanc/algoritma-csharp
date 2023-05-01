

using System;
using System.Collections.Generic;

namespace AsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> asalSayilar = new List<int>();
            List<int> asalOlmayanSayilar = new List<int>();

            int toplamAsalSayi = 0;
            int toplamAsalOlmayanSayi = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Pozitif bir sayı girin: ");
                string girilenSayiStr = Console.ReadLine();
                int girilenSayi;

                if (Int32.TryParse(girilenSayiStr, out girilenSayi) && girilenSayi > 0)
                {
                    bool asalMi = true;

                    for (int j = 2; j <= Math.Sqrt(girilenSayi); j++)
                    {
                        if (girilenSayi % j == 0)
                        {
                            asalMi = false;
                            break;
                        }
                    }

                    if (asalMi)
                    {
                        asalSayilar.Add(girilenSayi);
                        toplamAsalSayi += girilenSayi;
                    }
                    else
                    {
                        asalOlmayanSayilar.Add(girilenSayi);
                        toplamAsalOlmayanSayi += girilenSayi;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı girin.");
                    i--;
                }
            }

            asalSayilar.Sort();
            asalOlmayanSayilar.Sort();

            Console.WriteLine("Asal sayılar: ");
            foreach (int sayi in asalSayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Asal olmayan sayılar: ");
            foreach (int sayi in asalOlmayanSayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Asal sayıların toplamı: " + toplamAsalSayi);
            Console.WriteLine("Asal sayıların ortalaması: " + (float)toplamAsalSayi / asalSayilar.Count);
            Console.WriteLine("Asal olmayan sayıların toplamı: " + toplamAsalOlmayanSayi);
            Console.WriteLine("Asal olmayan sayıların ortalaması: " + (float)toplamAsalOlmayanSayi / asalOlmayanSayilar.Count);

            Console.ReadKey();
        }
    }
}
