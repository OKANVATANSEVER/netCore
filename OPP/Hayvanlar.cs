
namespace OPP
{
    public class Hayvanlar:Canlilar
    {
        public  void Adastasyon()
        {
            Console.WriteLine("Hayvanlar Adastasyon");
        }

    }
    public class Sürüngenler:Hayvanlar
    {
        public  void SurunerekHareketEderler()
        {
            Console.WriteLine("Sürüngenler Sürünerek Hareket Ederler");
        }

    }
    public class Kuşlar:Hayvanlar
    {
        public  void Ucmak()
        {
            Console.WriteLine("Kuşlar Uçar");
        }

    }
}