using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Pelicula
    {
        public string Titulo { get; set; }
        public int Year { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }

        public List<Serie> Carteleras { get; set; }
        public Pelicula()
        {
            Carteleras = new List<Serie>();
        }

        public void chilo()
        {
            Console.WriteLine("Pelicula");
        }


    }
}
