using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_lab6.Models;

namespace WebApp_lab6.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            Song song = new Song();
            song.name = '';
            song.artist = '';
            return View();
        }

        public ActionResult Square(int id)
        {
            return Content("" + (id * id));
        }
    }
}