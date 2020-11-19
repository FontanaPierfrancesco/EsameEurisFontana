using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class SalaCinematografica
    {
        public readonly string IdSala;        
        
        public readonly string IdSpettatore;
        public readonly string IdFilm;
        public string NomeSala { get; set; }
        public SalaCinematografica(string idSala, string nomeSala,string idSpettatore, string idFilm)
        {
            IdSala = idSala;
            NomeSala = nomeSala;           
            IdSpettatore = idSpettatore;
            IdFilm = idFilm;
        }
    }
}
