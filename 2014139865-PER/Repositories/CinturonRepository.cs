﻿using _2014139865_ENT;
using _2014139865_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2014139865_PER.Repositories
{
    public class CinturonRepository : Repository<Cinturon>, ICinturonRepository
    {
        public CinturonRepository(EnsambladoraDbContext context) : base(context)
        {
        }
    }
}
