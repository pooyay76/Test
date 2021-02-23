using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Test.Models;

namespace Test.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>{
            new Project(1,"Brilliant Trader","AI Generated FOREX Signal","Mr.x","project-1.jpg"),
            new Project(2, "Librarian", "All Purpose Learning Center", "Mr.x","project-2.jpg"),
            new Project(3,"Inside Job","We Help You Find Your Dream Job!","Mr.x","project-3.jpg"),
            new Project(4,"Companion","Smart House Developer","Mr.x","project-4.jpg")
            };
            return View("_Projects",projects);
        }
    }
}
