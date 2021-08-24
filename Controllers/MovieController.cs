using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var customers = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Name = "Superman"
                },
                new Movie()
                {
                    Id = 2,
                    Name = "Spiderman"
                }
            };
            return View(customers);
        }
    }
}