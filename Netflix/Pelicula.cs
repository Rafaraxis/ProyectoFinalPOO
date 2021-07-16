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

        public void imprimir()
        {
            Console.WriteLine("Titulo:" + this.Titulo + " Año:" + this.Year + "Genero:" + this.Genero + "Director:" + this.Director);
        }

        //public List<Pelicula> Peliculas { get; set; }
        //public Pelicula()
        //{
        //    Peliculas = new List<Pelicula>();
        //}
    }
}
