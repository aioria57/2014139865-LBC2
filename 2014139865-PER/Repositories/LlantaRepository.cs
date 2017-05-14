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
    public class LlantaRepository : Repository<Llanta>, ILlantaRepository
    {
        private readonly EnsambladoraDbContex _Context;

        public LlantaRepository(EnsambladoraDbContex  context)
        {
            _Context = context;
        }
        public LlantaRepository() : base()
        {

        }
        void IRepository<Llanta>.Add(Llanta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.AddRange(IEnumerable<Llanta> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Llanta> IRepository<Llanta>.Find(Expression<Func<Llanta, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Llanta IRepository<Llanta>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Llanta> IRepository<Llanta>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.Remove(Llanta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.RemoveRange(IEnumerable<Llanta> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.Update(Llanta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.UpdateRange(IEnumerable<Llanta> entities)
        {
            throw new NotImplementedException();
        }
    }
}
