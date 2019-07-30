using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreDemo3.Entities;
using MvcCoreDemo3.Filters;
using MvcCoreDemo3.Models;

namespace MvcCoreDemo3.Controllers
{
    public class HomeController : Controller
    {
        public object BlogViewModel { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        [HandleException(ViewName = "DivideByZero", ExceptionType = typeof(DivideByZeroException))]
        public IActionResult Index2()
        {
            throw new DivideByZeroException();
            return View();
        }
        public IActionResult GetCategory()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category { Id = 1, Name = "C#" });
            categories.Add(new Category { Id = 2, Name = "Design Paterns" });
            categories.Add(new Category { Id = 3, Name = "Web Programming" });

            HomeViewModel model = new HomeViewModel();
            model.Categories = categories;
            return View(new CategoryListViewModel
            {
                Categories = categories
            });
        }

    }
}