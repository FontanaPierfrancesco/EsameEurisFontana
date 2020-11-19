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
    public class SpettatoreController : Controller
    {        
        private readonly SpettatoreSqlprovider _spettatoreSqlprovider;        

        public SpettatoreController()
        {           
            _spettatoreSqlprovider = new SpettatoreSqlprovider(ConfigurationManager.ConnectionStrings["connectionCinema"].ConnectionString);            
        }

        // GET: Spettatore
        public ActionResult Index()
        {
            return View(_spettatoreSqlprovider.GetAll().Select(sp => new SpettatoreView(sp)));
        }

        // GET: Spettatore/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Spettatore/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Spettatore/Create
        [HttpPost]
        public ActionResult Create(SpettatoreView spettatore)
        {
            try
            {
                _spettatoreSqlprovider.Create(spettatore.ToSpettatore());

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Spettatore/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Spettatore/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SpettatoreView spettatore)
        {
            try
            {
                _spettatoreSqlprovider.Update(spettatore.ToSpettatore());

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }              
    }
}
