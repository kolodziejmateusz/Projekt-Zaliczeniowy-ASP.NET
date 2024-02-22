using Laboratorium_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3.Controllers
{
    public class AlbumController : Controller
    {
        private static Dictionary<int, Album> _albums = new Dictionary<int, Album>();

        public IActionResult Index()
        {
            return View(_albums);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                int id = _albums.Keys.Count != 0 ? _albums.Keys.Max() : 0;
                album.Id = id + 1;
                _albums.Add(album.Id, album);

                return RedirectToAction("Index");
            }
            else
            {
                return View(album);
            }
        }

        //[HttpGet]
        //public String Edit(int? id)
        //{
        //    return "Edycja " + id;
        //}

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (_albums.Keys.Contains(id))
            {
                return View(_albums[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            if (_albums.Keys.Contains(id))
            {
                return View(_albums[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (_albums.Keys.Contains(id))
            {
                return View(_albums[id]);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
