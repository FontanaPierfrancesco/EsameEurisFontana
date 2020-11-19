using Libreria.ProgettoCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgettoCinema.Models
{
    public class CinemaView
    {
        public string IdCinema { get; set; }
        public string NomeCinema { get; set; }
        public string IdSala { get; set; }
        public string IdFilm { get; set; }

        //public SalaCinematograficaView Sale { get; set; }

        public CinemaView()
        {

        }

        public CinemaView(Cinema cinema)
        {
            this.IdCinema = cinema.IdCinema;
            this.NomeCinema = cinema.NomeCinema;
            this.IdSala = cinema.IdSala;
            this.IdFilm = cinema.IdFilm;
        }

        public Cinema ToCinema()
        {
            return new Cinema(this.IdCinema, this.NomeCinema, this.IdSala, this.IdFilm);
        }
    }
}