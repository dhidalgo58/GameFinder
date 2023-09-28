using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Data.Entities
{
    public class GameEntity
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public string Title { get; set; }
        public string? Publisher { get; set; }
        public DateTime? YearPublished { get; set; }
        public int? GameGenreId { get; set; }
        public int? GameSystemId { get; set; }
    }
}

