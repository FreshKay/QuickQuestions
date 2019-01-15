using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuickQuestions.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerText { get; set; }
        public string AnswerImg { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }
}