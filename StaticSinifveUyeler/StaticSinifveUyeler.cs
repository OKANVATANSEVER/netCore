using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
	public class StaticSinifveUyeler
	{   
		static void Main(string[] args)
		{
			Console.WriteLine("Çalişan sayisi: {0}" , Calisan.CalisanSayisi); // ilk static olan const. çalişir ve 1 kez çalişir

			Calisan calisan = new Calisan("okan0", "vatansever", "HR");
			Calisan calisan2 = new Calisan("okan1", "vatansever", "MU");
			Calisan calisan3 = new Calisan("okan2", "vatansever", "BT");

			Console.WriteLine("Çalişan sayisi: {0}" ,Calisan.CalisanSayisi);
			Console.WriteLine("Toplama işleminin sonucu: {0}" , Islemler.Topla(100,200));
			Console.WriteLine("Çikarma işleminin sonucu: {0}" , Islemler.Cikar(200,100));
		}

		class Calisan 
		{
			private static int calisanSayisi; //field

			public static int CalisanSayisi { get => calisanSayisi;} //property

			private string Isim;
			private string Soyisim;
			private string Departman;

			static Calisan() //Static constructor'larin erişim belirleyicisi olmaz
			{
				calisanSayisi = 0;
			}
			public Calisan(string isim, string soyisim, string departman) //constructor
			{
				this.Isim = isim;
				this.Soyisim = soyisim;
				this.Departman = departman;
				calisanSayisi++;
			}
		}

		static class Islemler
		{
			public static long Topla(int sayi1, int sayi2)
			{
				return sayi1 + sayi2;
			}
			public static long Cikar(int sayi1, int sayi2)
			{
				return sayi1 - sayi2;
			}
		}
	}
}
