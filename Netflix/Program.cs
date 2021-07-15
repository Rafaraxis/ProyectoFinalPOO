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
            // Variable Opciones del Do and while
            int opcion;
            // Creacion de la lista
            List<Cartelera> listaCartelera = new List<Cartelera>();
            // Polimorfismo
            Serie serieClase = new Serie();
            Pelicula peliculaClase = new Pelicula();

            Cartelera series = new Serie();
            Cartelera peliculas = new Pelicula();
            // Ciclo DO hasta que le de click al 6 para cerrar programa
            do
            {
                peliculaClase.chilo();
                Console.WriteLine("1.- Crear Serie");
                Console.WriteLine("2.- Crear Película");
                Console.WriteLine("3.- Listar Series");
                Console.WriteLine("4.- Listar Películas");
                Console.WriteLine("5.- Listar Películas y Series");
                Console.WriteLine("6.- Salir");

                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        // Guardar Variables en Clase
                        Console.WriteLine("Titulo:");
                        serieClase.Titulo = Console.ReadLine();
                        Console.WriteLine("Año:");
                        serieClase.Year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Temporada:");
                        serieClase.Temporada = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cadena:");
                        serieClase.Cadena = Console.ReadLine();
                        // Lista de Series Guardar
                        listaCartelera.Add(new Cartelera { Titulo = serieClase.Titulo, Year = serieClase.Year, Tipo = "Serie"});
                        break;
                    case 2:
                        Console.WriteLine("Titulo:");
                        peliculaClase.Titulo = Console.ReadLine();
                        Console.WriteLine("Año:");
                        peliculaClase.Year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Género:");
                        peliculaClase.Genero = Console.ReadLine();
                        Console.WriteLine("Director:");
                        peliculaClase.Director = Console.ReadLine();
                        //Lista de Peliculas Guardar
                        listaCartelera.Add(new Cartelera { Titulo = peliculaClase.Titulo, Year = peliculaClase.Year, Tipo = "Pelicula" });
                        break;
                    case 3:
                        series.Titulo = "hola";
                        series.Titulo = "hola2";

                        ((Serie)(series)).imprimir();
                        //foreach (Cartelera cartelera in listaCartelera)
                        //{

                        //    if (cartelera.Tipo == "Serie")
                        //    {
                        //        Console.WriteLine("_____________________________________________________\n");


                        //        //Console.WriteLine("Titulo:" + cartelera.Titulo + " Año:" + cartelera.Year + " Temporada:" + serieClase.Temporada + " Cadena:" + serieClase.Cadena);
                        //        Console.WriteLine("_____________________________________________________\n");
                        //    }
                        //}
                        break;
                    case 4:
                        foreach (Cartelera cartelera in listaCartelera)
                        {
                            if (cartelera.Tipo == "Pelicula")
                            {
                                Console.WriteLine("_____________________________________________________\n");
                                Console.WriteLine("Titulo:" + cartelera.Titulo + " Año:" + cartelera.Year + " Género:" + peliculaClase.Genero + " Director:" + peliculaClase.Director);
                                Console.WriteLine("_____________________________________________________\n");
                            }
                        }
                        break;
                    case 5:
                        foreach (Cartelera cartelera in listaCartelera)
                        {
                            Console.WriteLine("_____________________________________________________\n");
                            Console.WriteLine("Titulo: " + cartelera.Titulo + " Año:" + cartelera.Year + " Tipo:" + cartelera.Tipo);
                            Console.WriteLine("_____________________________________________________\n");
                        }
                        break;
                }

            } while (opcion != 6);
            //Imprimir SERIES PRUEBA
            //Console.WriteLine("\n SERIES \n");
            //Console.WriteLine("Titulo:" + serieClase.Titulo);
            //Console.WriteLine("Año:" + serieClase.Year);
            //Console.WriteLine("Temporada:" + serieClase.Temporada);
            //Console.WriteLine("Cadena:" + serieClase.Cadena);

            //Console.WriteLine("\n PELICULAS \n");
            //peliculaClase.Titulo = "Chabelo y Pepito contra los monstruos";
            //peliculaClase.Year = 1973;
            //peliculaClase.Genero = "Comedia";
            //peliculaClase.Director = "José Estrada";

            //Console.WriteLine("Titulo:" + peliculaClase.Titulo);
            //Console.WriteLine("Año:" + peliculaClase.Year);
            //Console.WriteLine("Temporada:" + peliculaClase.Genero);
            //Console.WriteLine("Cadena:" + peliculaClase.Director);

            //List<Series> cartelera = new List<Serie>();
            //cartelera.Add(new Serie());
        }
    }
}
