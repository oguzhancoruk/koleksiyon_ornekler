using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Bir cümle giriniz:");
           string metin = Console.ReadLine();
            string sesli = "aeıioöuüAEIİIOÖUÜ";
            ArrayList dizi=new ArrayList();
            int sayac =0;
            for (int i = 0; i < metin.Length; i++)
            {
                
                if(sesli.Contains(metin[i]))
                {
                    sayac++;
                    dizi.Add(metin[i]);
                    dizi.Sort();
                    
                }
            }

            
            Console.WriteLine("Girdiğiniz cümle:"+metin);
            Console.WriteLine("Sesli harf sayısı:"+sayac);
            Console.WriteLine("Sesli harfler");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
