namespace WebApplication.Models
{
    public class User
    {
        public string UserName { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public double MaxSpeed { get; set; }
        public int TotalGoals { get; set; }
        public int RankPoints { get; set; }
    }
}