using QuickQuestions.DAL;
using QuickQuestions.Models;
using QuickQuestions.ViewModels;
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
            var vm = new HomeViewModel
            {
                Categories = categories
            };

            return View(vm);
        }

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult Howto()
        {
            return View();
        }

        //public ActionResult Categories()
        //{
        //    var categories = db.Categories.ToList();
        //    var vm = new HomeViewModel
        //    {
        //        Categories = categories
        //    };

        //    return View(vm);
        //}

        [HttpGet]
        public ActionResult Categories()
        {
            var quiz = db.Quizzes.ToList();
            var vm = new QuizViewModel
            {
                ListOfQuizz = quiz
            };
            //quiz.ListOfQuizz = db.Quizzes.Select(q => new SelectListItem
            //{
            //    Text = q.QuizName,
            //    Value = q.QuizID.ToString()

            //}).ToList();

            return View(vm);
        }

        [HttpPost]
        public ActionResult Categories(QuizViewModel quiz)
        {
            QuizViewModel quizSelected = db.Quizzes.Where(q => q.QuizID == quiz.QuizID).Select(q => new QuizViewModel
            {
                QuizID = q.QuizID,
                QuizName = q.QuizName,

            }).FirstOrDefault();

            if (quizSelected != null)
            {
                Session["SelectedQuiz"] = quizSelected;

                return RedirectToAction("QuizTest");
            }

            return View();
        }
    }
}