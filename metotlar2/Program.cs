// See https://aka.ms/new-console-template for more information

using System;

namespace metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("metotlar2");
            string sayi = "999";
            int outSayi;
           bool sonuc= int.TryParse(sayi, out  outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarili");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarisiz ");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplam);
            Console.WriteLine(toplam);

            //metotlara Aşiri Yükleme
            int ifade = 999;
            
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Oğuzhan", "ULUUĞUR");
            //metot imzasi metotadi + parametre sayisi+ parametre tipi

        }
        class Metotlar
        {
            public void  Topla(int a, int b,out int toplam)
            {
                toplam = a + b;
            }
            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(string veri1,string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
        }
    }
}