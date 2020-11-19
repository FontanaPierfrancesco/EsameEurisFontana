using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class Cinema
    {
        public readonly string IdCinema;      
        public readonly string IdSala;
        public readonly string IdFilm;
        public string NomeCinema { get; set; }


        public Cinema(string idCinema,string nomeCinema,string idSala,string idFilm)
        {
            IdCinema = idCinema;
            NomeCinema = nomeCinema;
            IdSala = idSala;
            IdFilm = idFilm;
        }
    }
}
