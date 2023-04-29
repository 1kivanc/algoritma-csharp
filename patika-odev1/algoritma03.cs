// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
// Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
//  Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

using System;

public class Algoritma03
{
    public static void Main(string[] args)
    {
              
        Console.WriteLine("Kaç adet kelime girmek istiyorsunuz: ");
        int adet = Convert.ToInt16(Console.ReadLine());
        
        while(adet <=0){
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            adet = Convert.ToInt16(Console.ReadLine());
        }
        
        string[] kelimeler = new string[adet];
        for(int i  = 0; i<adet ; i++){
            Console.WriteLine("{0}. kelimeyi giriniz : ",i+1);
            kelimeler[i] = Console.ReadLine();
        }
        Console.WriteLine("Kelimelerin terstersen sıralanışı:  ");
        for(int i = adet-1; i>=0; i--){
            Console.WriteLine(kelimeler[i]);
        }
    }
}