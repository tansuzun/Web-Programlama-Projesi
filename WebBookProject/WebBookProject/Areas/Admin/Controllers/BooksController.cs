using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBookProject.Data;
using WebBookProject.Models;

namespace WebBookProject.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Book.Include(b => b.Author).Include(b => b.Category).Include(b => b.Publisher);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            List<SelectListItem> categories = (from x in _context.Category.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.Category = categories;

            List<SelectListItem> publishers = (from x in _context.Publisher.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.PublisherName,
                                                   Value = x.PublisherId.ToString()
                                               }).ToList();
            ViewBag.Publisher = publishers;

            List<SelectListItem> authors = (from x in _context.Author.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.AuthorName+x.AuthorLastname,
                                                   Value = x.AuthorId.ToString()
                                               }).ToList();
            ViewBag.Author = authors;
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId");
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId");
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "PublisherId", "PublisherId");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,BookName,publishYear,Description,ImageUrl,CategoryId,PublisherId,AuthorId")] AddBook book)
        {

            Book newBook = new Book();
            if (book.ImageUrl != null)
            {
                var extension = Path.GetExtension(book.ImageUrl.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Photos/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                book.ImageUrl.CopyTo(stream);
                newBook.ImageUrl = newImageName;
            }
            newBook.BookName = book.BookName;
            newBook.Author = book.Author;
            newBook.AuthorId = book.AuthorId;
            newBook.Category = book.Category;
            newBook.CategoryId = book.CategoryId;
            newBook.Description = book.Description;
            newBook.Publisher = book.Publisher;
            newBook.PublisherId = book.PublisherId;
            newBook.publishYear = book.publishYear;
           // if (ModelState.IsValid)
           // {
                _context.Add(newBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            // }
            List<SelectListItem> categories = (from x in _context.Category.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.Category = categories;

            List<SelectListItem> publishers = (from x in _context.Publisher.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.PublisherName,
                                                   Value = x.PublisherId.ToString()
                                               }).ToList();
            ViewBag.Publisher = publishers;

            List<SelectListItem> authors = (from x in _context.Author.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName +"  "+ x.AuthorLastname,
                                                Value = x.AuthorId.ToString()
                                            }).ToList();
            ViewBag.Author = authors;
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId", book.AuthorId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId", book.CategoryId);
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "PublisherId", "PublisherId", book.PublisherId);
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId", book.AuthorId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId", book.CategoryId);
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "PublisherId", "PublisherId", book.PublisherId);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookId,BookName,publishYear,Description,ImageUrl,CategoryId,PublisherId,AuthorId")] Book book)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId", book.AuthorId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId", book.CategoryId);
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "PublisherId", "PublisherId", book.PublisherId);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Book.FindAsync(id);
            _context.Book.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Book.Any(e => e.BookId == id);
        }
    }
}
