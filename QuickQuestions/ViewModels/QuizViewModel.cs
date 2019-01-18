using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickQuestions.ViewModels
{
    public class QuizViewModel
    {
        public int QuizID { get; set; }
        public string QuizName { get; set; }
        public List<SelectListItem> ListOfQuizz { get; set; }

    }

    public class QuestionViewModel
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public string Anwser { get; set; }
        public ICollection<ChoiceViewModel> Choices { get; set; }
    }

    public class ChoiceViewModel
    {
        public int ChoiceID { get; set; }
        public string ChoiceText { get; set; }
    }

    public class QuizAnswersViewModel
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string AnswerQ { get; set; }
        public bool isCorrect { get; set; }


    }
}