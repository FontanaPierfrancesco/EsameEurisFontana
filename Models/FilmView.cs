using Libreria.ProgettoCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgettoCinema.Models
{
    public class FilmView
    {
        public string IdFilm { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string Produttore { get; set; }
        public string Genere { get; set; }
        public DateTime Durata { get; set; }

        public FilmView()
        {

        }

        public FilmView(Film film)
        {
            this.IdFilm = film.IdFilm;
            this.Titolo = film.Titolo;
            this.Autore = film.Autore;
            this.Produttore = film.Produttore;
            this.Genere = film.Genere;
            this.Durata = film.Durata;
        }

        public Film ToFilm()
        {
            return new Film(this.IdFilm, this.Titolo, this.Autore, this.Produttore, this.Genere, this.Durata);
        }
    }
}