using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickQuestions.Infrastructure
{
    public static class UrlHelpers
    {
        public static string CategoryIconsPath(this UrlHelper helper, string categoryIconName)
        {
            var CategoryIcons = AppConfig.CatIcons;
            var path = Path.Combine(CategoryIcons, categoryIconName);
            var rightPath = helper.Content(path);

            return rightPath;
        }
    }
}