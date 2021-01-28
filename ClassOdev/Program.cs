using System;

namespace ClassOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Fiyati = 5;
            urun1.Kategori = "Sebze";

            Urun urun2 = new Urun();
            urun2.Adı = "Armut";
            urun2.Fiyati = 4;
            urun2.Kategori = "Sebze";

            Urun urun3 = new Urun();
            urun3.Adı = "Makarna";
            urun3.Fiyati = 2;
            urun3.Kategori = "Kuru bakliyat";

            Urun urun4 = new Urun();
            urun4.Adı = "kolonya";
            urun4.Fiyati = 5;
            urun4.Kategori = "Temizlik";
            
            Urun urun5 = new Urun();
            urun5.Adı = "Tavuk";
            urun5.Fiyati = 25;
            urun5.Kategori = "Et";

            Urun urun6 = new Urun();
            urun6.Adı = "Sucuk";
            urun6.Fiyati = 75;
            urun6.Kategori = "Et";

            Urun[] ürünler = new Urun[] {urun1,urun2,urun3,urun4,urun5,urun6 };
            foreach (var Urun in ürünler)
            {
                Console.WriteLine(Urun.Adı + "=" + Urun.Fiyati);
            }

        }
    }
    class Urun
    {
        public int Fiyati { get; set; }
        public string Kategori { get; set; }
        public string Adı { get; set; }

    }
}
