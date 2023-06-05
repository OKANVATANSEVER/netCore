
namespace OPP
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler Fotosentez");
        }

    }
    public class TohunluBitkiler:Bitkiler
    {
        public TohunluBitkiler()
        {
         base.Fotosentez();   
         base.Beslenme();
         base.Bosaltim();
         base.Solunum();
        }
         public  void TohunlaCagalma()
        {
            Console.WriteLine("Bitkiler Tohumla Coğalilar");
        }
    }
     public class TohunsuzBitkiler:Bitkiler
    {
        public  void TohunsuzCogalma()
        {
            Console.WriteLine("Bitkiler Sporla Coğalilar");
        }
    }
}