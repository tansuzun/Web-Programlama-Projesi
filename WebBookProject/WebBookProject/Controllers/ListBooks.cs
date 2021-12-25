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
    public class ListBooks : Controller
    {

        private readonly ApplicationDbContext _context;

        public ListBooks(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Books
        public async Task<IActionResult> ListBook()
        {
            var applicationDbContext = _context.Book.Include(b => b.Author).Include(b => b.Category).Include(b => b.Publisher);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: ListBooks
        //public ActionResult ListBook()
        //{
        //    return View();
        //}

        // GET: ListBooks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListBooks/Create
        public ActionResult Create()
        {
            return View();
        }

    }
}
