using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickQuestions.Models
{
    public class Quiz
    {
        public Quiz()
        {
            this.Questions = new HashSet<Question>();
        }

        public int QuizID { get; set; }
        public string QuizName { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}