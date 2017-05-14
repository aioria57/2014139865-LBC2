using _2014139865_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865_PER.EntityTypeConfigurations
{
    public class PropietarioConfiguration : EntityTypeConfiguration<Propietario>
    {
        public PropietarioConfiguration()
        {
        
            ToTable("Propietario");
            HasKey(a => a.PropietarioId);

         

        }
    }
}
