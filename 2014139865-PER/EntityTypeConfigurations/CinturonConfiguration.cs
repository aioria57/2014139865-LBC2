using _2014139865_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865_PER.EntityTypeConfigurations
{
    public class CinturonConfiguration : EntityTypeConfiguration<Cinturon>
    {
        public CinturonConfiguration()
        {
           
            ToTable("Cinturon");

            HasKey(c => new { c.CinturonId });

   

        }
    }
}
