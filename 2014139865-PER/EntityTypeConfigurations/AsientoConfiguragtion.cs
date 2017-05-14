using _2014139865_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865_PER.EntityTypeConfigurations
{
    public class AsientoConfiguration : EntityTypeConfiguration<Asiento>
    {
        public AsientoConfiguration()
        {
            
            ToTable("Asiento");

            HasKey(c => new { c.AsientoId, c.CarroId });

   

        }
    }
}
