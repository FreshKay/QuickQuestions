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

            var quizzes = new List<Quiz>
            {
                new Quiz { QuizID = 1 },
                new Quiz { QuizID = 2 },
                new Quiz { QuizID = 3 },
                new Quiz { QuizID = 4 },
                new Quiz { QuizID = 5 },

            };

            quizzes.ForEach(k => context.Quizzes.AddOrUpdate(k));
            context.SaveChanges();

            var questions = new List<Question>
            {
                new Question { QuestionID = 1, QuizID = 1},
                new Question { QuestionID = 2, QuizID = 1},
                new Question { QuestionID = 3, QuizID = 1},
                new Question { QuestionID = 4, QuizID = 1},
                new Question { QuestionID = 5, QuizID = 1},
                new Question { QuestionID = 6, QuizID = 1},
                new Question { QuestionID = 7, QuizID = 1},
            };

            questions.ForEach(k => context.Questions.AddOrUpdate(k));
            context.SaveChanges();


            var answers = new List<Answer>
            {
                new Answer { AnswerID = 1 , QuestionID = 1},
                new Answer { AnswerID = 2 , QuestionID = 2},
                new Answer { AnswerID = 3 , QuestionID = 3},
                new Answer { AnswerID = 4 , QuestionID = 4},
                new Answer { AnswerID = 5 , QuestionID = 5},
                new Answer { AnswerID = 6 , QuestionID = 5},
                new Answer { AnswerID = 7 , QuestionID = 6},
                new Answer { AnswerID = 8 , QuestionID = 7},
                new Answer { AnswerID = 9 , QuestionID = 7},

            };

            answers.ForEach(k => context.Answers.AddOrUpdate(k));
            context.SaveChanges();

        }
    }
}