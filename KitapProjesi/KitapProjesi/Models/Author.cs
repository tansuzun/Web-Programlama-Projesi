using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapProjesi.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorLastname { get; set; }
        public string? Biography { get; set; }
    }
}
