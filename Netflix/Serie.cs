using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Serie : Cartelera
    {
        public int Temporada { get; set; }
        public string Cadena { get; set; }
        public void imprimir()
        {
            Console.WriteLine("Titulo:" + this.Titulo + " Año:" + this.Year + " Temporada:" + this.Temporada + " Cadena:" + this.Cadena);
        }
<<<<<<< Updated upstream
=======
        public void imprimir()
        {
            Console.WriteLine("Titulo:" + this.Titulo + " Año:" + this.Year + " Temporada:" + this.Temporada + " Cadena:" + this.Cadena);
        }
>>>>>>> Stashed changes
        //public List<Serie> Series { get; set; }
        //public Serie()
        //{
        //    Series = new List<Serie>();
        //}
    }
}
