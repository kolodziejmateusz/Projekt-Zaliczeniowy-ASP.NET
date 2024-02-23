using Laboratorium_4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_4.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public IActionResult Index()
        {
            var albums = _albumService.FindAll();
            return View(albums);
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
                _albumService.Add(album);
                return RedirectToAction("Index");
            }
            else
            {
                return View(album);
            }
        }

        public IActionResult Delete(int id)
        {
            _albumService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var album = _albumService.FindById(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

        [HttpPost]
        public IActionResult Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                _albumService.Edit(album);
                return RedirectToAction("Index");
            }
            return View(album);
        }

        public IActionResult Details(int id)
        {
            var album = _albumService.FindById(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }
    }
}
