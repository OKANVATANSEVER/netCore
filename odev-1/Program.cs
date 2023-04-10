// See https://aka.ms/new-console-template for more information

using System;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ödev 1");
            //1. Soru 

            // Console.WriteLine("Bir Sayi giriniz : ");
            // int sayi=int.Parse(Console.ReadLine());

            // Console.WriteLine($"{sayi} Tane Sayisi giriniz : ");
            // List<int> sayilar=new();
            // for (int i=0;i<sayi;i++)
            // {
            //      Console.WriteLine($"{i+1}. Sayisi giriniz : ");
            //     sayilar.Add(int.Parse(Console.ReadLine()));
            // }
            
            // foreach (int i in sayilar)
            // {
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            // }

            // 2. Soru 

        //     Console.WriteLine("1.Sayiyi giriniz : ");
        //     int n = int.Parse(Console.ReadLine());
        //     Console.WriteLine("2.Sayiyi giriniz : ");
        //     int m = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"{n} Tane Sayisi giriniz : ");
        //    List<int> sayilar=new();
        //     for (int i=0;i<n;i++)
        //     {
        //          Console.WriteLine($"{i+1}. Sayisi giriniz : ");
        //         sayilar.Add(int.Parse(Console.ReadLine()));
        //     }
           
        //    foreach (int i  in sayilar)
        //    {
        //         if(i==m )
        //         {
        //               Console.Write("Eşitler olan -->");
        //             Console.WriteLine(i);
        //         }
        //         if(i%m==0)
        //         {
        //             Console.Write("Bölünem -->");
        //             Console.WriteLine(i);
        //         }
        //    }
            

           

            //3.soru 
 
            // Console.WriteLine("Pozitif Bir Sayi Girin : ");
            // int sayi = int.Parse(Console.ReadLine());            

            // string[] kelimeler = new string[sayi];
            // for (int i = 0; i < sayi; i++)
            // {
            //    Console.WriteLine((i+1) + " .Kelimeyi Giriniz  :  ");
            //    string sayi2 = Console.ReadLine();
            //    kelimeler[i] = sayi2;

            // }
            // Array.Reverse(kelimeler);
            // foreach (var item in kelimeler)
            // {
            //    Console.WriteLine(item);
            // }
            // Console.ReadLine();


            //4.soru
            Console.WriteLine("Cümle yaziniz.");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            int w = words.Count();
            char[] c = input.Replace(" ", string.Empty).ToCharArray();
            int c1 = c.Count();
            Console.WriteLine("Kelime sayisi: {0},Harf sayisi: {1}", w, c1); 
            Console.ReadKey();







        }
    }
}


