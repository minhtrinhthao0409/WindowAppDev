using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Models
{
    public class Country
    {
        public string Id { get; set; } // e.g., "VNM", "GER"
        public string Name { get; set; }

        public int ContinentId { get; set; }
        public Continent Continent { get; set; }

        public ICollection<Town> Towns { get; set; } = [];
    }

}
