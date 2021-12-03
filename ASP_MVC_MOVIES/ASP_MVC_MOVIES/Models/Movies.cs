using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_MOVIES.Models
{
    public enum Genre
    {
        Comedy, Drama, Action, Thriller
    }
    public class Movies
    {
        [Key]
        public int ID { get; set; }
        [StringLength(60), Required]
        
        public string Title { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public Genre Genre { get; set; } = Genre.Action;

        [Range(5.99, 7.99), Required]
        public decimal Price { get; set; }

    }
}
