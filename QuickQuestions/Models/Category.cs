using System.Collections.Generic;

namespace QuickQuestions.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImg { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}