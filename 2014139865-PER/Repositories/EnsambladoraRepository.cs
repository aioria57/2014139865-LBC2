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
    public class EnsambladoraRepository : Repository<Ensambladora>, IEnsambladoraRepository
    {
        private readonly EnsambladoraDbContex _Context;

        public EnsambladoraRepository(EnsambladoraDbContex context)
        {
            _Context = context;
        }
        public EnsambladoraRepository() : base()
        {

        }
        void IRepository<Ensambladora>.Add(Ensambladora entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.AddRange(IEnumerable<Ensambladora> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Ensambladora> IRepository<Ensambladora>.Find(Expression<Func<Ensambladora, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Ensambladora IRepository<Ensambladora>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Ensambladora> IRepository<Ensambladora>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.Remove(Ensambladora entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.RemoveRange(IEnumerable<Ensambladora> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.Update(Ensambladora entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.UpdateRange(IEnumerable<Ensambladora> entities)
        {
            throw new NotImplementedException();
        }
    }
}
