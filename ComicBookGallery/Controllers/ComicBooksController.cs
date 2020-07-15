using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail(int id)
        {
            ComicBook comicBook = new ComicBookRepository().GetComicBook(id);

            return View(comicBook);
        }
    }
}