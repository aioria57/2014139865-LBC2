using _2014139865_ENT.Entities;
using _2014139865_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865_PER.Repositories
{
    public class CinturonRepository : Repository<Cinturon>, ICinturonRepository
    {
        private readonly EnsambladoraDbContex _Context;

        public CinturonRepository(EnsambladoraDbContex  context)
        {
            _Context = context;
        }
        public CinturonRepository() : base()
        {

        }
        void IRepository<Cinturon>.Add(Cinturon entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.AddRange(IEnumerable<Cinturon> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Cinturon> IRepository<Cinturon>.Find(Expression<Func<Cinturon, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Cinturon IRepository<Cinturon>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Cinturon> IRepository<Cinturon>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.Remove(Cinturon entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.RemoveRange(IEnumerable<Cinturon> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.Update(Cinturon entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.UpdateRange(IEnumerable<Cinturon> entities)
        {
            throw new NotImplementedException();
        }
    }
}
