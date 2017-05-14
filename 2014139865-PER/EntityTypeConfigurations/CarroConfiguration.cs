using _2014139865_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865_PER.EntityTypeConfigurations
{
    public class CarroConfiguration : EntityTypeConfiguration<Carro>
    {
        public CarroConfiguration()
        {
           
            ToTable("Carro");

            HasKey(c => new { c.CarroId, c.EnsambladoraId });

        
            HasRequired(a => a.Ensambladora)
                .WithOptional(a => a.Carro);

        }
    }
}
