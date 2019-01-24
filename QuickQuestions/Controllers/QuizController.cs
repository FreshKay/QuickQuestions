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

        [HttpGet]
        public ActionResult QuizTest()
        {
            QuizViewModel quizSelected = Session["SelectedQuiz"] as QuizViewModel;
            IQueryable<QuestionViewModel> questions = null;

            if (quizSelected != null)
            {
                questions = db.Questions.Where(q => q.Quiz.QuizID == quizSelected.QuizID)
                   .Select(q => new QuestionViewModel
                   {
                       QuestionID = q.QuestionID,
                       QuestionText = q.QuestionText,
                       Choices = q.Choices.Select(c => new ChoiceViewModel
                       {
                           ChoiceID = c.ChoiceID,
                           ChoiceText = c.ChoiceText
                       }).ToList()

                   }).AsQueryable();


            }

            return View(questions);
        }

        [HttpPost]
        public ActionResult QuizTest(List<QuizAnswersViewModel> resultQuiz)
        {
            List<QuizAnswersViewModel> finalResultQuiz = new List<ViewModels.QuizAnswersViewModel>();

            foreach (QuizAnswersViewModel answser in resultQuiz)
            {
                QuizAnswersViewModel result = db.Answers.Where(a => a.QuestionID == answser.QuestionID).Select(a => new QuizAnswersViewModel
                {
                    QuestionID = a.QuestionID.Value,
                    AnswerQ = a.AnswerText,
                    isCorrect = (answser.AnswerQ.ToLower().Equals(a.AnswerText.ToLower()))

                }).FirstOrDefault();

                finalResultQuiz.Add(result);
            }

            return Json(new { result = finalResultQuiz }, JsonRequestBehavior.AllowGet);
        }
    }
}