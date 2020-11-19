using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class Spettatore
    {
        public readonly string IdSpettatore;       
        public readonly DateTime DataNascita;
        public readonly string IdBiglietto;
        public string NomeSpettatore { get; set; }
        public string CognomeSpettatore { get; set; }
        

        public Spettatore(string idSpettatore, string nomeSpettatore, string cognomeSpettatore, DateTime dataNascita, string idBiglietto)
        {
            IdSpettatore = idSpettatore;
            NomeSpettatore = nomeSpettatore;
            CognomeSpettatore = cognomeSpettatore;
            DataNascita = dataNascita;
            IdBiglietto = idBiglietto;
           
        }
    }
}
