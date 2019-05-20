using ChallengeC.Models;
using ChallengeC.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeC.Repository
{
    public class MunicipalityRepository : IMunicipality
    {
        private DBContext db;

        public MunicipalityRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Municipality> GetMunicipalities => db.Municipality;

        public Municipality GetMunicipality(int Id)
        {
            Municipality dbEntity = db.Municipality.Find(Id);
            return dbEntity;
        }
    }
}
