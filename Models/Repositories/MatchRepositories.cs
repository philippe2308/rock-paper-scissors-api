using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rock_paper_scissors_api.Models.Repositories
{
    public static class MatchRepositories
    {
        private static List<Match> matches = new List<Match>(){
            new Match { Winner= ElementsRepositories.GetElementByName("Spock").Id, Loser= ElementsRepositories.GetElementByName("Scissors").Id, Action="smashes"},
            new Match { Winner= ElementsRepositories.GetElementByName("Spock").Id, Loser= ElementsRepositories.GetElementByName("Rock").Id, Action="vaporizes"},
            new Match { Winner= ElementsRepositories.GetElementByName("Paper").Id, Loser= ElementsRepositories.GetElementByName("Spock").Id, Action="disproves"},
            new Match { Winner= ElementsRepositories.GetElementByName("Lizard").Id, Loser= ElementsRepositories.GetElementByName("Spock").Id, Action="poisons"},
            new Match { Winner= ElementsRepositories.GetElementByName("Lizard").Id, Loser= ElementsRepositories.GetElementByName("Paper").Id, Action="eats"},
            new Match { Winner= ElementsRepositories.GetElementByName("Rock").Id, Loser= ElementsRepositories.GetElementByName("Lizard").Id, Action="crushes"},
            new Match { Winner= ElementsRepositories.GetElementByName("Scissors").Id, Loser= ElementsRepositories.GetElementByName("Lizard").Id, Action="decapitates"},
            new Match { Winner= ElementsRepositories.GetElementByName("Scissors").Id, Loser= ElementsRepositories.GetElementByName("Paper").Id, Action="cuts"},
            new Match { Winner= ElementsRepositories.GetElementByName("Rock").Id, Loser= ElementsRepositories.GetElementByName("Scissors").Id, Action="crushes"},
            new Match { Winner= ElementsRepositories.GetElementByName("Paper").Id, Loser= ElementsRepositories.GetElementByName("Rock").Id, Action="covers"},
        };
        public static List<Match> GetMatches()
        {
            return matches;
        }

        public static Match GetMatch(int playerId1, int playerId2)
        {
            return matches.FirstOrDefault(x => (x.Loser == playerId1 && x.Winner == playerId2 || x.Loser == playerId2 && x.Winner == playerId1));
        }
    }
}