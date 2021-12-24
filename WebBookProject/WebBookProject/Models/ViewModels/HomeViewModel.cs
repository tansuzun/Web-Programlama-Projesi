using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBookProject.Models;

namespace WebBookProject.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<Book> Book { get; set; }
        public IEnumerable<Publisher> Publisher { get; set; }
        public IEnumerable<Author> Author { get; set; }
    }
}
