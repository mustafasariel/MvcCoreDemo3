using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreDemo3.Filters
{
    public class CustomFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var s = "sonra";
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var s = "önce";
        }
    }
}
