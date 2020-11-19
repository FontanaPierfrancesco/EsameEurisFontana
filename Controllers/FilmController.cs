using Libreria.ProgettoCinema;
using ProgettoCinema.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgettoCinema.Controllers
{
    public class FilmController : Controller
    {

        private readonly FilmSqlProvider _filmSqlProvider;

        public FilmController()
        {
            _filmSqlProvider = new FilmSqlProvider(ConfigurationManager.ConnectionStrings["connectionCinema"].ConnectionString);
        }
        // GET: Film
        public ActionResult Index()
        {
            return View(_filmSqlProvider.GetAll().Select(f => new FilmView(f)));
        }
       
        // GET: Film/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Film/Create
        [HttpPost]
        public ActionResult Create(FilmView film)   
        {
            try
            {
                _filmSqlProvider.Update(film.ToFilm());

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Film/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Film/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FilmView film)
        {
            try
            {
                _filmSqlProvider.Update(film.ToFilm());

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }          
    }
}
