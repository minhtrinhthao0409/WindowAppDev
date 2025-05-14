using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Models
{
    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Team> Teams { get; set; } = [];
    }

}
