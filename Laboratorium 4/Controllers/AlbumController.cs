using Laboratorium_4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_4.Controllers
{
    public class AlbumController : Controller
    {
        //private static Dictionary<int, Album> _albums = new Dictionary<int, Album>();
        //static AlbumController()
        //{
        //var album1 = new Album
        //{
        //    Id = 1,
        //    Name = "Abbey Road",
        //    Band = "The Beatles",
        //    TrackList = "Come Together, Something, Maxwell's Silver Hammer, Oh! Darling, Octopus's Garden, I Want You (She's So Heavy), Here Comes The Sun, Because, You Never Give Me Your Money, Sun King, Mean Mr. Mustard, Polythene Pam, She Came In Through The Bathroom Window, Golden Slumbers, Carry That Weight, The End, Her Majesty.",
        //    ReleaseDate = new DateTime(1969, 9, 26),
        //    Duration = "47:23",
        //    Popularity = Popularity.High
        //};

        //    var album2 = new Album
        //    {
        //        Id = 2,
        //        Name = "The Dark Side of the Moon",
        //        Band = "Pink Floyd",
        //        TrackList = "Speak to Me, Breathe, On the Run, Time, The Great Gig in the Sky, Money, Us and Them, Any Colour You Like, Brain Damage, Eclipse.",
        //        ReleaseDate = new DateTime(1973, 3, 1),
        //        Duration = "42:49",
        //        Popularity = Popularity.TopChart
        //    };

        //    _albums.Add(album1.Id, album1);
        //    _albums.Add(album2.Id, album2);
        //}



        //public IActionResult Index()
        //{
        //    return View(_albums.Values.ToList());
        //}

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Album album)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        int id = _albums.Keys.Count != 0 ? _albums.Keys.Max() : 0;
        //        album.Id = id + 1;
        //        _albums.Add(album.Id, album);

        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View(album);
        //    }
        //}

        ////[HttpGet]
        ////public String Edit(int? id)
        ////{
        ////    return "Edycja " + id;
        ////}

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    if (_albums.Keys.Contains(id))
        //    {
        //        //logika edit
        //        return View(_albums[id]);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

        //[HttpGet]
        //public IActionResult Details(int id)
        //{
        //    if (_albums.Keys.Contains(id))
        //    {
        //        return View(_albums[id]);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    if (_albums.Keys.Contains(id))
        //    {
        //        //logika delete
        //        return View(_albums[id]);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

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
            var contact = _albumService.FindById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }
    }
}
