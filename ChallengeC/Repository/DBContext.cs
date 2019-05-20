﻿using ChallengeC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeC.Repository
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext>options):base(options)
        {

        }

        public DbSet<Municipality> Municipality { get; set; }
    }
}
