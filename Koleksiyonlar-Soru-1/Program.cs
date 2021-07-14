using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {   int[] dizi=new int[21] ;
            Console.WriteLine("20 Adet Pozitif Sayı giriniz:");
            ArrayList liste =new ArrayList();
            ArrayList asal=new ArrayList();
            ArrayList natasal=new ArrayList();
           int  toplam1=0;
           int toplam2=0;
         

for (int i = 1; i <=20; i++)

{
    

dizi[i] = Convert.ToInt32(Console.ReadLine());
if(dizi[i]<0)
{
 Console.WriteLine("Lütfen pozitif sayı giriniz:");
 i-=i;


}

}




    foreach (var cift in dizi)
    {
         if(AsalSayi(cift)){
            
         asal.Add(cift);
         asal.Sort();
         asal.Reverse();
         toplam1=toplam1+cift;
         
         }
         else{
         natasal.Add(cift);
          natasal.Sort();
          natasal.Reverse();
          toplam2=toplam2+cift;
         }

 
    }
    Console.WriteLine("Asal olmayan Sayılar:");
    foreach (var item in natasal)
    {
       
    Console.WriteLine(item);
    }
    Console.WriteLine("***Eleman Sayısı***");
    Console.WriteLine(natasal.Count);
    Console.WriteLine("***Ortalama***");
    Console.WriteLine(toplam2/natasal.Count);

    Console.WriteLine("Asal olan Sayılar:");
    foreach (var item in asal)
    {    
    Console.WriteLine(item);
    }
    Console.WriteLine("***Eleman Sayısı***");
    Console.WriteLine(asal.Count);
    Console.WriteLine("***Ortalama***");
    Console.WriteLine(toplam1/asal.Count);
   

    }
   
    private static bool AsalSayi(int sayi)

    {
    bool result = true;
    for (int i = 2; i < sayi - 1; i++)
    {

    if (sayi % i == 0)

    {

    result = false;

     i = sayi;

    }

    }
    if (sayi < 2) result = false;
    return result;

   }
   } }