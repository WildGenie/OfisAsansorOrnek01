using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsansorSimilasyonu
{
    public class KatPaneli : Panel
    {
        public Kat Kat { get; internal set; }

        internal void Cagri(Yon yon)
        {
            this.Kat.Ofis.Asansor.RotaEkle(this.Kat.KatNo, yon);
        }
    }
}