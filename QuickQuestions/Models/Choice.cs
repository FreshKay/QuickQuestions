namespace QuickQuestions.Models
{
    public class Choice
    {
        public int ChoiceID { get; set; }
        public string ChoiceText { get; set; }
        public int? QuestionID { get; set; }

        public virtual Question Question { get; set; }
    }
}