namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        public int GamesPlayed { get; set; }

        public int GamesWon { get; set; }

        public int TotalGoals { get; set; }

        public double MaxSpeed { get; set; }

        [Required]
        [StringLength(20)]
        public string TimePlayed { get; set; }

        public int RankPoints { get; set; }
    }
}
