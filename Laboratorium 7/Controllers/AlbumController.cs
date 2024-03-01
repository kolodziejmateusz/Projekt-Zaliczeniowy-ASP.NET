using Laboratorium_7.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_7.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var albums = _albumService.FindAll();
            return View(albums);
        }

        private void InitializeRecordLabels(Album model)
        {
            model.RecordLabels = _albumService
                .FindAllOrganizations()
                .Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.Name })
                .ToList();
        }


        [HttpGet]
        public IActionResult Create()
        {
            Album model = new Album();
            InitializeRecordLabels(model);
            return View(model);
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
                InitializeRecordLabels(album);
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
