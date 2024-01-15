using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rock_paper_scissors_api.Models
{
    public class Element
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string WinnerImage { get; set; }
        public string LoserImage { get; set; }

    }
}