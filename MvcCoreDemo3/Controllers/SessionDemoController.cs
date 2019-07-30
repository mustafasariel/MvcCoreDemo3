using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDemo3.Controllers
{
    public class SessionDemoController : Controller
    {
        public IActionResult Index()
        {

            if (HttpContext.Session.GetInt32("sayac") == null)
            {
                HttpContext.Session.SetInt32("sayac", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("sayac", (int)HttpContext.Session.GetInt32("sayac") + 1);
            }
            return View();
        }

        public string GetSayac()
        {
            return HttpContext.Session.GetInt32("sayac").ToString();
        }
    }
}