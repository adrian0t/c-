using lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class FilmController : Controller
    {
         private static IList<Film> films = new List<Film>
{   
            new Film(){Id = 1, Name = "Film1", Description = "opis filmu1", Price=3},
            new Film(){Id = 2, Name = "Film2", Description = "opis filmu2", Price=5},
            new Film(){Id = 3, Name = "Film3", Description = "opis filmu3", Price=3},
};
        // GET: FilmController
        public ActionResult Index()
        {
            return View(films);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(films.FirstOrDefault(x=>x.Id==id));
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View(new Film());
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            film.Id = films.Count + 1;
            films.Add(film);
            return RedirectToAction(nameof(Index));
           
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            
           
            return View(films.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Film updatedFilm)
        {
            
                Film film = films.FirstOrDefault(x => x.Id == id);
                film.Name = updatedFilm.Name;
                film.Description = updatedFilm.Description;
                film.Price = updatedFilm.Price;
                return RedirectToAction(nameof(Index));
        }


        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(films.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int id)
        {
            Film film = films.FirstOrDefault(x => x.Id == id);
            films.Remove(film);
            return RedirectToAction(nameof(Index));
        }

    }
}
