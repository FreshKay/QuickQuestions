using System.ComponentModel.DataAnnotations;

namespace QuickQuestions.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        [Required(ErrorMessage = "Enter the answer!")]
        [StringLength(100)]
        public string AnswerContent { get; set; }
        [Required(ErrorMessage = "Choose the correct answer!")]
        public bool GoodAnswer { get; set; }
        public string AnswerImg { get; set; }

        public virtual Question Question { get; set; }
    }
}