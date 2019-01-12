using QuickQuestions.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickQuestions.Controllers
{
    public class QuizController : Controller
    {
        private QuizContext db = new QuizContext();

        public ActionResult Start()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var details = db.Categories.Find(id);
            return View(details);
        }
    }
}