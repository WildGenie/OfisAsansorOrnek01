using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsansorSimilasyonu
{
    public class Yolcu
    {
        public Yolcu(int baslangicKat, int hedefKat)
        {
            BaslangicKat = baslangicKat;
            HedefKat = hedefKat;
        }

        public int BaslangicKat { get; }
        public int HedefKat { get; }
        public Kat MevcutKat { get; internal set; }
        public Asansor MevcutAsansor { get; internal set; }

        internal void HareketBaslangic()
        {
            if (MevcutKat != null)
            {
                if (BaslangicKat > HedefKat)
                {
                    MevcutKat.KatPaneli.Cagri(Yon.Asagi);
                }
                else if (HedefKat > BaslangicKat)
                {
                    MevcutKat.KatPaneli.Cagri(Yon.Yukari);
                }
                else
                {
                    throw new Exception("Yolcu tanimlarken baslangic ve hedef katlari ayni olamaz");
                }

            }
        }
    }
}