using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Test.Models;

namespace Test.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            var articles = new List<Article>{
            new Article(1,"Global Warning!","We are making hell on earth!", "blog-post-thumb-card-1.jpg"),
            new Article(2, "Successful Jobs In 2030!", "Your daily 9:00-5:00 job is not in it", "blog-post-thumb-card-2.jpg"),
            new Article(3,"Pothead's Travel Guide","A Pothead's most precious knowledge","blog-post-thumb-card-3.jpg"),
            new Article(4,"How Marriage Can Help Younger Folk?","Life's not all about sex","blog-post-thumb-card-4.jpg")
            };
            return View("_Articles",articles);
        }
    }
}
