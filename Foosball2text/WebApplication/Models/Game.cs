using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Game
    {
        public string LeftUserName { get; set; }
        public string RightUserName { get; set; }
        public int LeftScore { get; set; }
        public int RightScore { get; set; }
    }
}