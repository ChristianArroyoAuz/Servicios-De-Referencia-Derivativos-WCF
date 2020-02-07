// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 05/08/2016.                                                                              *
// ******************************************************************************************


using ServicioCalculadoraDerivativos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System;

namespace Anfitrion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proporcionando un Host para los servicio de la clase calculadora, mediante el puerto 8080 y usando el protocolo HTTP
            using (ServiceHost anfitrion = new ServiceHost(typeof(Calculadora), new Uri("http://localhost:8080/Derivativos/Calculadora")))
            {
                //Abriendo la conexion para la comunicacion
                //anfitrion.Open();
                Console.WriteLine("El servicio de Calculadora está corriendo...");
                Console.WriteLine();
                Console.Write("Para terminar presione una tecla...");
                Console.ReadKey();
            }
        }
    }
}