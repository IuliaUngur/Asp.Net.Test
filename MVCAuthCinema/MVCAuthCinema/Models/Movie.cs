using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Repo.Models
{
    public class Movie
    {
        [Required]
        public int ID { get; set; }

        [MaxLength(80), Required]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
