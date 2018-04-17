using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Authorization;

namespace Blog.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: Article/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }

            var article = _context.Articles
                .Include(a => a.Author)
                .First(m => m.Id == id);

            if (article == null)
            {
                return StatusCode(500);
            }

            return View(article);
        }

        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var article = await _context.Articles
        //        .Include(a => a.Author)
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (article == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(article);
        //}

        //GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        // GET: Article/List
        public ActionResult List()
        {
            var articles = _context.Articles
                .Include(a => a.Author)
                .ToList();

            return View(articles);
        }


        // GET: Articles
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.Articles.Include(a => a.Author);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        // GET: Articles/Details/5


        // GET: Articles/Create
        [Authorize]
        public IActionResult Create()
        {
            // ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [Authorize]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                //set user id
                var authorId = _context.Users
                    .Where(u => u.UserName == this.User.Identity.Name)
                    .First()
                    .Id;

                //set article author
                article.AuthorId = authorId;

                //save article
                _context.Articles.Add(article);
                _context.SaveChanges();

                //_context.Add(article);
                // await _context.SaveChangesAsync();
                // return RedirectToAction(nameof(Index));

                return RedirectToAction("Index");

            }
            //ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", article.AuthorId);
            return View(article);
        }

        // GET: Articles/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = _context.Articles
                .Where(a => a.Id == id)
                .First();

            //if (IsUserAuthorizedToEdit(article) == false)
            //{
            //    return Forbid();
            //}

            if (article == null)
            {
                return NotFound();
            }
            var model = new ArticleViewModel();
            model.Id = article.Id;
            model.Title = article.Title;
            model.Content = article.Content;

      
            return View(model);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit(ArticleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var article = _context.Articles
                     .FirstOrDefault(a => a.Id == model.Id);
                article.Title = model.Title;
                article.Content = model.Content;
            }

            return RedirectToAction("Index"); 

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(article);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!ArticleExists(article.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", article.AuthorId);
            //return View(article);
        }

        // GET: Articles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = _context.Articles
                .Include(a => a.Author)
                .First(m => m.Id == id);

            if (IsUserAuthorizedToEdit(article) == false)
            {
                return Forbid(); 
            }

            if (article == null)
            {
                return StatusCode(404);
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var article = _context.Articles
                .Include(a => a.Author)
                .First(m => m.Id == id);

            if (article == null)
            {
                return NotFound();
            }

            _context.Articles.Remove(article);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        private bool IsUserAuthorizedToEdit(Article article)
        {
            bool isAdmin = this.User.IsInRole("Admin");
            bool isAuthor = article.IsAuthor(this.User.Identity.Name);

            return isAdmin || isAuthor; 
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
