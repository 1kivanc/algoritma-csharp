// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
//  Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

using System;

public class Algoritma02
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dizi kaç adet sayıdan oluşsun: ");
        
        int adet;
        while (true){
            adet = int.Parse(Console.ReadLine());
            if(adet>0){
                int[] sayilar = new int[adet];
                for(int i = 0; i<adet; i++) {
                    Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                    
                }
                Console.WriteLine("Bu dizi deki sayıları hangi sayıya bölmek istersin: ");
                bolenInput:
                int bolen =  int.Parse(Console.ReadLine());
                if(bolen>0){
                    for(int i = 0; i<adet; i++){
                        if(sayilar[i] % bolen == 0 || bolen == sayilar[i]){
                            Console.WriteLine(sayilar[i]);
                        }
                    }
                    
                }else{
                        Console.Write("Girdiğiniz bölen sayısı geçersiz baştan gir : ");
                        goto bolenInput;
                }
                
            }else {
                Console.WriteLine("Girdigin sayi gecersiz baştan gir:");
            }
        }
        
        
    }
}