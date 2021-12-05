using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KitapProjesi.Models
{
    public class Book
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ISBN { get; set; }
        public string BookName { get; set; }

        public int? publishYear { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        public Category Category { get; set; }

        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]

        public Publisher Publisher { get; set; }
    }
}
