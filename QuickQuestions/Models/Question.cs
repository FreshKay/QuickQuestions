using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuickQuestions.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Enter the question!")]
        [StringLength(100)]
        public string QuestionContent { get; set; }
        public string QuestionImg { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}