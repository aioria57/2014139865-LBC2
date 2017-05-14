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
    public class VolanteRepository : Repository<Volante>, IVolanteRepository
    {
        private readonly EnsambladoraDbContex _Context;

        public VolanteRepository(EnsambladoraDbContex context)
        {
            _Context = context;
        }
        public VolanteRepository() : base()
        {

        }
        void IRepository<Volante>.Add(Volante entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.AddRange(IEnumerable<Volante> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Volante> IRepository<Volante>.Find(Expression<Func<Volante, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Volante IRepository<Volante>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Volante> IRepository<Volante>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.Remove(Volante entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.RemoveRange(IEnumerable<Volante> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.Update(Volante entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.UpdateRange(IEnumerable<Volante> entities)
        {
            throw new NotImplementedException();
        }
    }
}
