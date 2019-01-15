using QuickQuestions.Migrations;
using QuickQuestions.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace QuickQuestions.DAL
{
    public class QuizInitializer : MigrateDatabaseToLatestVersion<QuizContext, Configuration>
    {
        public static void SeedQuizData(QuizContext context)
        {
            var categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "JavaScript", CategoryImg = "csharp.png"},
                new Category { CategoryId = 2, CategoryName = "C#", CategoryImg = "csharp.png"},
                new Category { CategoryId = 3, CategoryName = "Java", CategoryImg = "csharp.png"},
                new Category { CategoryId = 4, CategoryName = "Asp. net", CategoryImg = "csharp.png"},
                new Category { CategoryId = 5, CategoryName = "HTML", CategoryImg = "csharp.png"},
            };

            categories.ForEach(k => context.Categories.AddOrUpdate(k));
            context.SaveChanges();

            var questions = new List<Question>
            {
                new Question { QuestionId = 1, CategoryId = 1, QuestionContent = "Is it or not?"},
                new Question { QuestionId = 2, CategoryId = 1, QuestionContent = "Is it or not?"},
                new Question { QuestionId = 3, CategoryId = 2, QuestionContent = "Is it or not?"},
                new Question { QuestionId = 4, CategoryId = 2, QuestionContent = "Is it or not?"},
                new Question { QuestionId = 5, CategoryId = 3, QuestionContent = "Is it or not?"},
                new Question { QuestionId = 6, CategoryId = 4, QuestionContent = "Is it or not?"},
                new Question { QuestionId = 7, CategoryId = 5, QuestionContent = "Is it or not?"},
            };

            questions.ForEach(k => context.Questions.AddOrUpdate(k));
            context.SaveChanges();


            var answers = new List<Answer>
            {
                new Answer { AnswerId = 1, QuestionId = 1},
                new Answer { AnswerId = 2, QuestionId = 1},
                new Answer { AnswerId = 3, QuestionId = 2},
                new Answer { AnswerId = 4, QuestionId = 3},
                new Answer { AnswerId = 5, QuestionId = 4},
                new Answer { AnswerId = 6, QuestionId = 5},
                new Answer { AnswerId = 7, QuestionId = 6},
                new Answer { AnswerId = 8, QuestionId = 7},
                new Answer { AnswerId = 9, QuestionId = 7},

            };

            answers.ForEach(k => context.Answers.AddOrUpdate(k));
            context.SaveChanges();
        }
    }
}