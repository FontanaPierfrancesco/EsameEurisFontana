using Libreria.ProgettoCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgettoCinema.Models
{
    public class BigliettoView
    {
        public string IdBiglietto { get; set; }
        public int NPosto { get; set; }
        public decimal PrezzoBiglietto { get; set; }

        //Applicare riduzione agli anziani, calcolare sconti bambini

        public BigliettoView()
        {

        }

        public BigliettoView(Biglietto biglietto)
        {
            this.IdBiglietto = biglietto.IdBiglietto;
            this.NPosto = biglietto.NPosto;
            this.PrezzoBiglietto = biglietto.PrezzoBiglietto;
        }

        public Biglietto ToBiglietto()
        {
            return new Biglietto(this.IdBiglietto, this.NPosto, this.PrezzoBiglietto);
        }
    }
}