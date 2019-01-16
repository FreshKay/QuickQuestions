using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuickQuestions.Models
{
    public class Answer
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }
        public int? QuestionID { get; set; }

        public virtual Question Question { get; set; }
    }
}