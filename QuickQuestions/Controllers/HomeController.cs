using QuickQuestions.DAL;
using QuickQuestions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickQuestions.Controllers
{
    public class HomeController : Controller
    {
        private QuizContext db = new QuizContext();

        public ActionResult Index()
        {
            var categories = db.Categories.ToList();
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult Howto()
        {
            return View();
        }
    }
}