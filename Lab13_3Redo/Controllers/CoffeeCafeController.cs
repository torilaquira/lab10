using Lab13_3Redo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13_3Redo.Controllers
{
    public class CoffeeCafeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> results = DAL.GetAllProducts();
            return View(results);
        }

        public IActionResult Products (int prod)
        {
            
            Product thedept = DAL.GetDetails(prod);
            
            return View(thedept);
        }
    }
}
