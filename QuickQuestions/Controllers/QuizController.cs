using QuickQuestions.DAL;
using QuickQuestions.ViewModels;
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

        [HttpGet]
        public ActionResult SelectQuizz()
        {
            QuizViewModel quiz = new ViewModels.QuizViewModel();
            quiz.ListOfQuizz = db.Quizzes.Select(q => new SelectListItem
            {
                Text = q.QuizName,
                Value = q.QuizID.ToString()

            }).ToList();

            return View(quiz);
        }

        [HttpPost]
        public ActionResult SelectQuizz(QuizViewModel quiz)
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