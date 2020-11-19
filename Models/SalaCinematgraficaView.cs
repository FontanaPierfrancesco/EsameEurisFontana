using Libreria.ProgettoCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgettoCinema.Models
{
    public class SalaCinematgraficaView
    {
        public string IdSala { get; set; }
        public string NomeSala { get; set; }

        public const int  NumeroPosti = 10;
        public string IdSpettatore { get; set; }
        public string IdFilm { get; set; }

        public SalaCinematgraficaView()
        {

        }

        public SalaCinematgraficaView(SalaCinematografica salaCinematografica)
        {
            this.IdSala = salaCinematografica.IdSala;
            this.NomeSala = salaCinematografica.NomeSala;          
            this.IdSpettatore = salaCinematografica.IdSpettatore;
            this.IdFilm = salaCinematografica.IdFilm;
        }

        public SalaCinematografica ToSala()
        {
            return new SalaCinematografica(this.IdSala, this.NomeSala, this.IdSpettatore, this.IdFilm);
        }
    }
}