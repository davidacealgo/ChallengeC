using ChallengeC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeC.Services
{
    interface IMunicipality
    {
        IEnumerable<Municipality> GetMunicipalities { get; }
        Municipality GetMunicipality(int Id);

    }
}
