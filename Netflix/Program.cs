using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie serieClase = new Serie();
            Pelicula peliculaClase = new Pelicula();

            serieClase.Titulo = "Breaking Bad";
            serieClase.Year = 2005;
            serieClase.Temporada = 5;
            serieClase.Cadena = "AMC";

            Console.WriteLine("Titulo:" + serieClase.Titulo);
            Console.WriteLine("Año:" + serieClase.Year);
            Console.WriteLine("Temporada:" + serieClase.Temporada);
            Console.WriteLine("Cadena:" + serieClase.Cadena);

            List<Serie> cartelera = new List<Serie>();
            cartelera.Add(new Serie());

            // Programa se termina
            Console.ReadKey();
        }
    }
}
