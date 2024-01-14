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
    public class ElementController : ControllerBase
    {

        [HttpGet]
        public List<Element> GetElements()
        {
            return ElementsRepositories.GetElements();
        }
    }
}