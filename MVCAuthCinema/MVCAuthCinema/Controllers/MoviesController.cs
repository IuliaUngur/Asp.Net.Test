using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinema.Repo.Data;
using Cinema.Repo.Models;
using Cinema.Repo.Filters;

namespace Cinema.Repo.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [MovieFilter("Iulia")] 
        public IActionResult Index() {
            Console.WriteLine("In index");
            return View();
        }
    }
}