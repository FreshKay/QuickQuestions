using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace QuickQuestions.Infrastructure
{
    public class AppConfig
    {
        private static string _catIcons = ConfigurationManager.AppSettings["CategoryIcons"];

        public static string CatIcons
        {
            get
            {
                return _catIcons;
            }
        }
    }
}