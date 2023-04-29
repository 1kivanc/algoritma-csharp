// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

using System;

public class Algoritma01
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Kac sayi gireceginizi giriniz: ");
        int adet;
        while(true){
            adet =int.Parse(Console.ReadLine());
            if(adet>0){
                int[] sayilar = new int[adet];
                for(int i = 0; i<adet; i++){
                    Console.WriteLine("{0}. sayiyi giriniz: ",i+1);
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Girmiş Oldugunuz Cift sayilar");
                int ciftSayi = 0;
                for(int i = 0; i<adet ; i++){
                    if(sayilar[i] % 2 == 0){
                        
                        Console.WriteLine(sayilar[i]);
                        ciftSayi++;
                    }
                }
                Console.WriteLine("Girmiş olduğunuz "+adet+" sayidan "+ciftSayi+" tanesi cift sayidir");
                
            }else{
                Console.WriteLine("Sayi gecersiz tekrar gir");
            }
        }
        
    }
}