using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Models
{
    public class Position
    {
        public required string Id { get; set; } // e.g., "GK", "DF"
        public string Description { get; set; } = null!;

        public ICollection<Player> Players { get; set; } = [];
    }

}
