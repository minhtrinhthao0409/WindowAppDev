namespace FootballBetting.Models
{
    public class ResultPrediction
    {
        public int Id { get; set; }
        public string Prediction { get; set; } // HomeWin, Draw, AwayWin

        public ICollection<BetGame> BetGames { get; set; } = [];
    }
}
