using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeC.Controllers
{
    
    [ApiController]
    public class MunicipalityController : ControllerBase
    {
        [HttpPost]
        [Route("Search")]
        public string Search(Municipality municipality)
        {

        }
    }
}