﻿using System;
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
            Console.WriteLine("Titulo:" + Titulo + " Año:" + Year + " Temporada:" + Temporada + " Cadena:" + Cadena);
        }
        //public List<Serie> Series { get; set; }
        //public Serie()
        //{
        //    Series = new List<Serie>();
        //}
    }
}
