using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HShopping.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HShopping.Controllers
{
    public class ProductController : Controller
    {
        private readonly dbHshoppingContext _context;

        public ProductController(dbHshoppingContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details( int id)
        {
            var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
            if(product == null)
            {
                return RedirectToAction("Index");
            }    
            return View(product);
        }

    }
}
