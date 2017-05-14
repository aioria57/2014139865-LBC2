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
    public class CarroRepository : Repository<Carro>, ICarroRepository
    {
        private readonly EnsambladoraDbContex _Context;

        public CarroRepository(EnsambladoraDbContex context)
        {
            _Context = context;
        }
        public CarroRepository() : base()
        {

        }
        void IRepository<Carro>.Add(Carro entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.AddRange(IEnumerable<Carro> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Carro> IRepository<Carro>.Find(Expression<Func<Carro, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Carro IRepository<Carro>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Carro> IRepository<Carro>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.Remove(Carro entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.RemoveRange(IEnumerable<Carro> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.Update(Carro entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Carro>.UpdateRange(IEnumerable<Carro> entities)
        {
            throw new NotImplementedException();
        }
    }
}
