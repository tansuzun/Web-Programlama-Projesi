using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBookProject.Data;

namespace WebBookProject.Controllers
{
    public class ListCategories : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListCategories(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> CategoryGetList()
        {
            var categoryBooks = _context.Book.Include(b => b.Category).Where(x => x.CategoryId == x.Category.CategoryId).ToList();
            return View(categoryBooks);
           // return View(await _context.Category.ToListAsync());
        }

        public async Task<IActionResult> ListCategory()
        {
            var categoryBooks = _context.Book.Include(b => b.Category).Where(x => x.CategoryId == x.Category.CategoryId).ToList();
            return View(categoryBooks);
            // return View(await _context.Category.ToListAsync());
        }
        // GET: ListCategories/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ListCategories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ListCategories/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ListCategories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ListCategories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ListCategories/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
