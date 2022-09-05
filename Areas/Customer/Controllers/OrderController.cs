using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webshop.Data;

namespace Webshop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET checkout action method
        public IActionResult Checkout()
        {
            return View();
        }

        //POST Checkout action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task
    }
}