using MvcCoreDemo3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreDemo3.Models
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Article> Articles { get; set; }
    }
}
