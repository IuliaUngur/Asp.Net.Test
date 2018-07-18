using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Repo.Filters
{
    public class GlobalFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("global - before");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("global - after");
        }
    }
}
