using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Models
{
    public class Game
    {
        public int Id { get; set; }

        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }

        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }

        public DateTime Date { get; set; }

        public double HomeTeamWinRate { get; set; }
        public double AwayTeamWinRate { get; set; }
        public double DrawRate { get; set; }

        public int RoundId { get; set; }
        public Round Round { get; set; }

        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }

        public ICollection<PlayerStatistic> PlayerStatistics { get; set; } = [];
        public ICollection<BetGame> BetGames { get; set; } = [];
    }

}
