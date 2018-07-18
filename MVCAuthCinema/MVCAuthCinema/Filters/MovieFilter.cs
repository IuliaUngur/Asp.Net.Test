using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Repo.Filters
{
    public class MovieFilter : Attribute, IActionFilter
    {
        DateTime start;
        private string _author;

        public MovieFilter(string author)
        {
            _author = author;
        }

        public void OnActionExecuting(ActionExecutingContext context) // before
        {
            start = DateTime.Now;
            Console.WriteLine("method - before");
        }

        public void OnActionExecuted(ActionExecutedContext context) // after
        {
            Console.WriteLine("method - after");
        }
    }
}