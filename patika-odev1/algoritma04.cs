// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
//  Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
using System;

public class Algoritma04
{
    public static void Main(string[] args)
    {
              
        Console.WriteLine("Lütfen bir cümle giriniz: ");
        string cumle = Console.ReadLine();
        
        int kelimeSayisi = cumle.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;
        
        int harfSayisi=0; 
        foreach(char c in cumle){
            if(char.IsLetter(c)){
                harfSayisi++;
            }
        }
        Console.WriteLine("Girilen cümlede {0} kelime ve {1} harf bulunmaktadır.", kelimeSayisi, harfSayisi);
    }
}