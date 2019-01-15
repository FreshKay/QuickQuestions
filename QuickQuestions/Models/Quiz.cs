using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickQuestions.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public TimeSpan? Duration { get; set; }
        public int Score { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}