using Libreria.ProgettoCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgettoCinema.Models
{
    public class SpettatoreView
    {
        public string IdSpettatore { get; set; }    
        public string NomeSpettatore { get; set; }
        public string CognomeSpettatore { get; set; }
        public DateTime DataNascita { get; set; }
        public string IdBiglietto { get; set; }
        
        //public bool Maggiorenne { get; set; }

        

        public SpettatoreView()
        {

        }


        public SpettatoreView(Spettatore spettatore)
        {
            this.IdSpettatore = spettatore.IdSpettatore;
            this.NomeSpettatore = spettatore.NomeSpettatore;
            this.CognomeSpettatore = spettatore.CognomeSpettatore;
            this.DataNascita = spettatore.DataNascita;
            this.IdBiglietto = spettatore.IdBiglietto;
        }

        public Spettatore ToSpettatore()
        {
            return new Spettatore(this.IdSpettatore, this.NomeSpettatore, this.CognomeSpettatore, this.DataNascita, this.IdBiglietto);
        }
    }
}