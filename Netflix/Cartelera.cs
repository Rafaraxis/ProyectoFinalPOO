using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Cartelera
    {
        public string Titulo { get; set; }
        public int Year { get; set; }
        public string Tipo { get; set; }



        public List<Cartelera> Carteleras { get; set; }
        public Cartelera()
        {
            Carteleras = new List<Cartelera>();
        }
    }
}
