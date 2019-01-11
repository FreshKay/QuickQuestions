using QuickQuestions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickQuestions.ViewModels
{
    public class HomeViewModel
    {
        public  IEnumerable<Category> Categories { get; set; }
    }
}