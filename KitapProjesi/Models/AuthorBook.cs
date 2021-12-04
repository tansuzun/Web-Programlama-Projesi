using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapProjesi.Models
{
    public class AuthorBook
    {
        public int AuthorBookId { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public Book Book { get; set; }
    }
}
