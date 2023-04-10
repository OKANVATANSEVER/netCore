// See https://aka.ms/new-console-template for more information
using System;

namespace Classlar
{
    class Program
    {

static void Main(string[] args)
        {
            Console.WriteLine("Metotlar");
            //erisim_belirteci geri_dönüs_tipi metot_adi(parametreListesi/arguman)
            //{
            //komutlar;
            //return;
            //}"
            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);
            int sonuc = Topla(a, b);
            Console.Write("metot a+b=",sonuc);
            Methotlar ornek = new Methotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
           
            int sonuc2 = ornek.Arttir_Topla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir( Convert.ToString(a + b));

        }
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }
    class Methotlar
    {
       public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int Arttir_Topla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
