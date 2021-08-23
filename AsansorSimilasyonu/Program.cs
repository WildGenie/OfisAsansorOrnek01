using System;
using System.Collections.Generic;

namespace AsansorSimilasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            int katSayisi = 6;
            int yolcuKapasitesi = 6;
            Console.WriteLine("Hello World!");
            var asansor = new Asansor(new AsansorPaneli(katSayisi), katSayisi, yolcuKapasitesi);
            var katlar = new List<Kat> { 
                new Kat(new KatPaneli(),0),
                new Kat(new KatPaneli(),1),
                new Kat(new KatPaneli(),2),
                new Kat(new KatPaneli(),3),
                new Kat(new KatPaneli(),4),
                new Kat(new KatPaneli(),5)
            };
            var ofis = new Ofis(asansor, katlar);

            //var ornekYolcu = new Yolcu(0, 2);
            //ofis.Katlar[0].YolcuEkle(ornekYolcu);
            //ornekYolcu.HareketBaslangic();

        }
    }
}
