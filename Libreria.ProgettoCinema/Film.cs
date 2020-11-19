using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class Film
    {
        public readonly string IdFilm;             
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string Produttore { get; set; }
        public string Genere { get; set; }
        public DateTime Durata { get; set; }

        public Film(string idFilm, string titolo, string autore, string produttore, string genere, DateTime durata)
        {
            IdFilm = idFilm;
            Titolo = titolo;
            Autore = autore;
            Produttore = produttore;
            Genere = genere;
            Durata = durata;           
        }
    }
}
