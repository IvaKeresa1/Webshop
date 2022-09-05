using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webshop.Data;
using Webshop.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Webshop.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductController : Controller
    {

        private ApplicationDbContext _db;
        private IHostingEnvironment _he;

        public ProductController(ApplicationDbContext db, IHostingEnvironment he)
        {
            _db = db;
            _he = he;
        }

        public IActionResult Index()
        {
            return View(_db.Products.Include(c => c.ProductTypes).Include(f => f.SpecialTag).ToList());
        }

        //POST Index action method
        //Sortiranje, probaj kasnije baš napraviti sort button
        [HttpPost]
        public IActionResult Index(decimal? lowAmount, decimal? largeAmount)
        {
            var products = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTag).Where(c => c.Price >= lowAmount && c.Price <= largeAmount).ToList();
            return View(products);
            if(lowAmount==null || largeAmount == null) {
                products = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTag).ToList();
            }
        }

        // GET Create method 
        public IActionResult Create()
        {
            ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
            ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "Name");
            return View();
        }

        //Post Create method
        [HttpPost]
        public async Task<IActionResult> Create(Products product, IFormFile image)
        {


            var searchProduct = _db.Products.FirstOrDefault(c => c.Name == product.Name);

            if (ModelState.IsValid)
            {
                if (searchProduct != null)
                {
                    ViewBag.message = "This product already exist";
                    ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
                    ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "Name");
                    return View(product);
                }
            }
            if (image != null)
            {
                var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                await image.CopyToAsync(new FileStream(name, FileMode.Create));
                product.Image = "Images/" + image.FileName;
            }

            if (image == null)
            {
                product.Image = "Images/noimage.png";
            }
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            return View(product);
        }

        //GET Edit Action Method

        public ActionResult Edit(int? id)
        {
            ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
            ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "Name");
            if(id == null)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTag).FirstOrDefault(c => c.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //POST Edit Action Method
        [HttpPost]
        public async Task<IActionResult> Edit(Products product, IFormFile image)
        {
            var searchProduct = _db.Products.FirstOrDefault(c => c.Name == product.Name);
            if (searchProduct != null)
            {
                ViewBag.message = "This product is already exist";
                ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
                ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "Name");
                return View(product);
            }

            if (image != null)
            {
                var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                await image.CopyToAsync(new FileStream(name, FileMode.Create));
                product.Image = "Images/" + image.FileName;
            }

            if (image == null)
            {
                product.Image = "Images/noimage.png";
            }
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            return View(product);
        }

        //GET Details Action Method

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTag).FirstOrDefault(c => c.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //GET Delete Ac

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _db.Products.Include(c=>c.SpecialTag).Include(c=>c.ProductTypes).Where(c => c.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _db.Products.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}