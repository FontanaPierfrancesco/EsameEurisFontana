using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class Biglietto
    {
        public readonly string IdBiglietto;                    
        public int NPosto { get; set; }
        public decimal PrezzoBiglietto { get; set; }

        public Biglietto(string idBiglietto, int nPosto, decimal prezzoBiglietto)
        {
            IdBiglietto = idBiglietto;
            NPosto = nPosto;
            PrezzoBiglietto = prezzoBiglietto;
            
            
        }
    }
}
