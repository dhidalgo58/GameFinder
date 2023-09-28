using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models
{
    public class GameGenre
    {
        [Key]
        public int GameGenreId { get; set; }

        [Required]
        public string GenreName { get; set; }
    }
}