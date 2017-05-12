using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865_ENT
{
   public class Asiento
    {
        public Cinturon Cinturon { get; set; }
        public string NumSerie { get; set; }

        public Asiento()
        {
            Cinturon = new Cinturon();
        }
    }
}
