using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models
{
    public class GameSystem
    {
        [Key]
        public int GameSystemId { get; set; }
        
        public string SystemName { get; set; }
    }
}