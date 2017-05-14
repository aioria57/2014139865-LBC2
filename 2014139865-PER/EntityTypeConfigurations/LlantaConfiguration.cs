using _2014139865_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865_PER.EntityTypeConfigurations
{
    public class LlantaConfiguration : EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            //Table Configurations
            ToTable("Llanta");

            HasKey(c => new { c.LlantaId, c.CarroId });

           

        }
    }
}
