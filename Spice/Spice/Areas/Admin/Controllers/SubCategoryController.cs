using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SubCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get INDEX
        public async Task<IActionResult> Index()
        {
            var subCategories = await _db.SubCategory.Include(s => s.Category).ToListAsync();
            return View(subCategories);
        }

        // GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                //if valid
                _db.SubCategory.Add(subCategory);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(subCategory);
        }
    }
}