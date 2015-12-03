using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LyricGetter.Models;
using LyricEngine;

namespace LyricGetter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(String webAddress)
        {

            SongInfo info = new SongInfo();

            WebAddressManager web = new WebAddressManager();

            string lyrics = web.WebHandler(webAddress);
            info.Lyric = lyrics;
            return View((Object)info.Lyric);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}