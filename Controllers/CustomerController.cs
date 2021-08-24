using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                Name = "Mohammad"
            },
            new Customer()
            {
                Id = 2,
                Name = "Ali"
            }
        };
        
        public IActionResult Index()
        {
            
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            if (id > customers.Count)
            {
                return new NotFoundResult();
            }

            return View(customers[id-1]);
        }
    }
}