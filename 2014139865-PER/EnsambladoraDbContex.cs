using _2014139865_ENT;
using _2014139865_ENT.Entities;
using _2014139865_PER.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865_PER
{
    public class EnsambladoraDbContex:DbContext
    {

        public DbSet<Asiento> Asiento { get; set; }
        public DbSet<Automovil> Automovil { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Cinturon> Cinturon { get; set; }
        public DbSet<Ensambladora> Ensambladora { get; set; }
        public DbSet<Llanta> Llanta { get; set; }
        public DbSet<Parabrisas> Parabrisas { get; set; }
        public DbSet<Propietario> Propietario { get; set; }
        public DbSet<Volante> Volante{ get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AsientoConfiguration());
            modelBuilder.Configurations.Add(new AutomovilConfiguration());
            modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new CarroConfiguration());
            modelBuilder.Configurations.Add(new CinturonConfiguration());
            modelBuilder.Configurations.Add(new EnsambladoraConfiguration());
            modelBuilder.Configurations.Add(new LlantaConfiguration());
            modelBuilder.Configurations.Add(new ParabrisasConfiguration());
            modelBuilder.Configurations.Add(new PropietarioConfiguration());
            modelBuilder.Configurations.Add(new VolanteConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }



}




