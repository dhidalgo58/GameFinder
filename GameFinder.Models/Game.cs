using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime YearPublished { get; set; }
        public int GameGenreId { get; set; }
        public int GameSystemId { get; set; }
    }
}