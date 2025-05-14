using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int TypeId { get; set; }
        public CompetitionType Type { get; set; }

        public ICollection<Game> Games { get; set; } = [];
    }
}
