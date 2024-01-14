using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rock_paper_scissors_api.Models;
using rock_paper_scissors_api.Models.Repositories;

namespace rock_paper_scissors_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchController : ControllerBase
    {

        [HttpGet("{playerId1}/{playerId2}")]
        public Models.Match GetMatchResult(int playerId1, int playerId2)
        {

            return MatchRepositories.GetMatch(playerId1, playerId2);
        }
    }
}