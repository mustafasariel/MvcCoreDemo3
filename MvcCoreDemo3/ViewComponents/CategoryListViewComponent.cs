using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcCoreDemo3.Entities;
using MvcCoreDemo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreDemo3.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke(string filter)
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category { Id = 1, Name = "C#" });
            categories.Add(new Category { Id = 2, Name = "Design Paterns" });
            categories.Add(new Category { Id = 3, Name = "Web Programming" });
            categories.Add(new Category { Id = 4, Name = ".net core" });


            var result = new CategoryListViewModel();
            result.Categories = categories.Where(s => s.Name.ToLower().Contains(filter)).ToList();
            return View(result);
        }
    }
}
