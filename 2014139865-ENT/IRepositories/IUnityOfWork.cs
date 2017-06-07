using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable

    {

        IAsientoRepository Asientos { get; }

        IAutomovilRepository Automoviles { get; }

        IBusRepository Buses { get; }

        ICarroRepository Carros { get; }

        ICinturonRepository Contirones { get; }

        IEnsambladoraRepository Ensambladoras { get; }

        ILlantaRepository Llantas { get; }

        IParabrisasRepository Parabrisas { get; }

        IPropietarioRepository Propietarios { get; }

        IVolanteRepository Volantes { get; }

        int SaveChanges();

        void StateModified(object entity);

    }
}
