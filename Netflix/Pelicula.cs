using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Pelicula : Cartelera
    {
        public string Genero { get; set; }
        public string Director { get; set; }

        public Pelicula()
        {

        }

        public void chilo()
        {
            Console.WriteLine("NETFLIX \n");
        }

        //public List<Pelicula> Peliculas { get; set; }
        //public Pelicula()
        //{
        //    Peliculas = new List<Pelicula>();
        //}
    }
}
