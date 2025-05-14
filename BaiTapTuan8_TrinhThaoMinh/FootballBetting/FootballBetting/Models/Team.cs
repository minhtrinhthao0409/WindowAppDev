using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Initials { get; set; } // 3 letters
        public decimal Budget { get; set; }

        public int PrimaryKitColorId { get; set; }
        public Color PrimaryKitColor { get; set; } = null!;

        public int SecondaryKitColorId { get; set; }
        public Color SecondaryKitColor { get; set; } = null!;

        public int TownId { get; set; }
        public Town Town { get; set; } = null!;
        public ICollection<Player> Players { get; set; } = [];
    }

}
