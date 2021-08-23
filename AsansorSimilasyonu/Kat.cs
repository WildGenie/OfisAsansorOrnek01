using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsansorSimilasyonu
{
    public class Kat
    {
        public Kat(KatPaneli katPaneli, int katNo)
        {
            KatPaneli = katPaneli;
            KatPaneli.Kat = this;
            KatNo = katNo;
            Yolcular = new List<Yolcu>();
        }

        public List<Yolcu> Yolcular
        {
            get;
        } 

        public KatPaneli KatPaneli
        {
            get;
        }

        public int KatNo
        {
            get;
        }

        public Ofis Ofis { get; internal set; }

        internal void YolcuEkle(Yolcu yolcu)
        {
            Yolcular.Add(yolcu);
            yolcu.MevcutAsansor = null;
            yolcu.MevcutKat = this;
        }

        public void AsansorKataUlasti()
        {
            var asansor = Ofis.Asansor;
            foreach (var asansorYolcusu in Ofis.Asansor.Yolcular)
            {
                if (asansorYolcusu.HedefKat == KatNo)
                {
                    Ofis.Asansor.Yolcular.Remove(asansorYolcusu);
                }
            }

            List<Yolcu> asansoreBinenler = new List<Yolcu>();
            foreach (var katYolcusu in this.Yolcular)
            {
                var yolcuYon = katYolcusu.HedefKat > katYolcusu.BaslangicKat ? Yon.Yukari: Yon.Asagi;
                if (asansor.YolcuKapasitesi > asansor.Yolcular.Count() && asansor.MevcutYon == yolcuYon)
                {
                    asansoreBinenler.Add(katYolcusu);
                }
            }
            foreach (var asansoreBinen in asansoreBinenler)
            {
                AsansoreBinenYolcu(asansor, asansoreBinen);
            }

        }

        private void AsansoreBinenYolcu(Asansor asansor, Yolcu yolcu)
        {
            this.Yolcular.Remove(yolcu);
            yolcu.MevcutAsansor = asansor;
            yolcu.MevcutKat = null;
            asansor.AsansorPaneli.Cagri(yolcu.HedefKat);
        }

    }
}