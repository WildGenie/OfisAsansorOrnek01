using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsansorSimilasyonu
{
    public class AsansorPaneli : Panel
    {
        public AsansorPaneli(int katSayisi)
        {
            KatSayisi = katSayisi;
        }

        public Asansor Asansor { get; set; }
        public int KatSayisi { get; }

        internal void Cagri(int hedefKat)
        {
            var yon = hedefKat > Asansor.MevcutKat ? Yon.Yukari : Yon.Asagi;
            Asansor.RotaEkle(hedefKat,yon);
        }
    }
}