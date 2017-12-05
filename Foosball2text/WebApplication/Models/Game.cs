namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string LeftUserName { get; set; }

        [Required]
        [StringLength(50)]
        public string RightUserName { get; set; }

        public int LeftScore { get; set; }

        public int RightScore { get; set; }

        public bool? InProgress { get; set; }
    }
}
