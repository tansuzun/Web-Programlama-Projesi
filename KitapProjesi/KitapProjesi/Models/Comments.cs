using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KitapProjesi.Models
{
    public class Comments
    {
        public int CommentsId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public string ISBN { get; set; }
        [ForeignKey("ISBN")]
        public Book Book { get; set; }
    }
}
