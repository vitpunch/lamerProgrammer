using lamerProgrammer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lamerProgrammer.Controllers
{
    public class storyController : Controller
    {
        // GET: story
        public ActionResult Index()
        {
            return View("random");
        }
        public ActionResult Random()
        {
            Story story = new Story();
            story.Random();
            return View(story);
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Hot()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Number()
        {
            Story story = new Story();
            return View(story);
        }
    }
}