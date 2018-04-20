﻿namespace IMDB.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class FilmController : Controller
    {
        private readonly IMDBDbContext dbContext;

        public FilmController(IMDBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var films = dbContext.Films.ToList();

            return View(films); 
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
          
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Film film)
        {
            dbContext.Films.Add(film);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int? id)
        {
            Film film = dbContext
               .Films
               .Where(p => p.Id == id)
               .FirstOrDefault();

            return View(film);
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult EditCondirm(int id, Film filmModel)
        {
            dbContext.Films.Update(filmModel);
            dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int? id)
        {
            Film film = dbContext
                .Films
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return View(film); 
        }

        [HttpPost]
        [Route("/delete/{id}")]
        public IActionResult DeleteConfirm(int id, Film filmModel)
        {
            dbContext.Films.Remove(filmModel);
            dbContext.SaveChanges();

            return RedirectToAction("Index"); 
        }
    }
}
