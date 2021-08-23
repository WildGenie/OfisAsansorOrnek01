using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsansorSimilasyonu
{
    public class Ofis
    {
        public Ofis(Asansor asansor, List<Kat> katlar)
        {
            Asansor = asansor;
            Asansor.Ofis = this;
            Katlar = katlar;
            foreach (var kat in Katlar)
            {
                kat.Ofis = this;
            }
        }

        public Asansor Asansor
        {
            get;
        }

        public List<Kat> Katlar
        {
            get;
        }
    }
}