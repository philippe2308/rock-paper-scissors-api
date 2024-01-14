using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rock_paper_scissors_api.Models
{
    public class Match
    {
        public int Winner { get; set; }
        public int Loser { get; set; }
        public string Action { get; set; }
    }
}