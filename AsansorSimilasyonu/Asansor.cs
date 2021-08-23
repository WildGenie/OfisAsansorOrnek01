using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsansorSimilasyonu
{
    public class Asansor
    {
        public Asansor(AsansorPaneli asansorPaneli, int katSayisi, int yolcuKapasitesi)
        {
            AsansorPaneli = asansorPaneli;
            AsansorPaneli.Asansor = this;
            KatSayisi = katSayisi;
            YolcuKapasitesi = yolcuKapasitesi;
            Yolcular = new List<Yolcu>(yolcuKapasitesi);
            Rota = new List<int>(katSayisi);
            MevcutKat = 0;
            MevcutYon = Yon.Yok;

        }

        internal void RotaEkle(int katNo, Yon yon)
        {
            if (!Rota.Contains(katNo))
            {
                Rota.Add(katNo);
                //HareketKontrol();
            }
        }

        private void HareketKontrol()
        {
            switch (MevcutYon)
            {
                case Yon.Yok:
                    if (Rota.Count() > 0)
                    {
                        MevcutYon = Rota[0] > MevcutKat ? Yon.Yukari : Yon.Asagi;
                    }
                    break;
                case Yon.Yukari:
                    MevcutKat++;
                    KatUlasmaKontrol();
                    break;
                case Yon.Asagi:
                    MevcutKat--;
                    KatUlasmaKontrol();
                    break;
            }
        }

        private void KatUlasmaKontrol()
        {
            //foreach (var item in Rota)
            //{
            //    if (MevcutKat == item)
            //    {
            //        Ofis.Katlar[MevcutKat].AsansorKataUlasti();
            //    }
            //}
            //if (Rota.LastIndexOf(MevcutKat) )
            //{

            //}
            var index = Rota.LastIndexOf(MevcutKat);
            if (index != -1)
            {
                Ofis.Katlar[MevcutKat].AsansorKataUlasti();
                Rota.RemoveAt(index);
            }
        }

        public Ofis Ofis { get; internal set; }
        public int YolcuKapasitesi
        {
            get;
        }

        public List<Yolcu> Yolcular
        {
            get;
        }

        public AsansorPaneli AsansorPaneli
        {
            get;
        }

        public int MevcutKat
        {
            get;
            set;
        }
        public Yon MevcutYon { get; private set; }
        public List<int> Rota
        {
            get;
        }

        public int KatSayisi { get; }
    }
}