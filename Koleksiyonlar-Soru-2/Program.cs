using System;
using System.Collections;


namespace Koleksiyonlar_Soru_2
{
    class Program
    {
         
         static void Main(string[] args)
        {   ArrayList liste =new ArrayList();  
            ArrayList max= new ArrayList();
            ArrayList min= new ArrayList(); 
            int toplam1=0;
            int toplam2=0;
            int[] dizi=new int[21]; 
            Console.WriteLine("Lütfen 20 Adet Pozitif Sayı Giriniz:");
            for (int i = 1; i <=20; i++)

       {
    

          dizi[i] = Convert.ToInt32(Console.ReadLine());
          if(dizi[i]<0)
          {
          Console.WriteLine("Lütfen Pozitif Sayı Giriniz:");
          i-=i;


          }

          }

         foreach (var item in dizi)
         {   
             liste.Add(item);
             liste.Sort();
            
            
             
         }
          int s = (int)liste[liste.Count-1];
          int t = (int)liste[liste.Count-2];
          int y = (int)liste[liste.Count-3];
          
             max.Add(s);
             max.Add(t);
             max.Add(y);
             min.Add(liste[1]);
             min.Add(liste[2]);
             min.Add(liste[3]);
             int a = (int)min[min.Count-1];
             int b = (int)min[min.Count-2];
             int c = (int)min[min.Count-3];
             Console.WriteLine("Maxsimum Değerler:");
             
         foreach (var l in max)
         {
             
             Console.WriteLine(l);
         }
         toplam1=y+s+t;
          double ortalama1=toplam1/max.Count;
          Console.WriteLine("ORTALAMA:");
          Console.WriteLine(ortalama1);
         
            
          Console.WriteLine("Minimum Değerler:");
          foreach (var item in min)
          {
              Console.WriteLine(item);
          }
          toplam2=a+b+c;
          double ortalama2=toplam2/min.Count;
          Console.WriteLine("ORTALAMA:");
          Console.WriteLine(ortalama2);
          Console.WriteLine("Ortalamaların Toplamı:"+(ortalama2+ortalama1));
          
          
         

        }
    }
}
