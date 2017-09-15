using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte MovieGenreId { get; set; }

        public MovieGenreDto MovieGenre { get; set; }

        public DateTime ReleaseDate { get; set; }

        
        public DateTime DateAdded { get; set; }

        
        [Range(1, 20)]
        public byte NoInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}