// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 05/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Collections;
using ServicioCapitales;
using System.Threading;
using System.Linq;
using System.Text;
using System;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Espacio de nombres proporciona clases e interfaces que habilitan la programación multiproceso.
            Thread servidor = new Thread(ServicioCapitales.Program.Main);
            //Ponemos a correr al servidor por detras de la aplicacion
            servidor.IsBackground = true;
            //Iniciamos la escucha del servidor
            servidor.Start();
            //Ponemos a dormir al hilo un cierto tiempo
            System.Threading.Thread.Sleep(100);
            //Generamos un canal para el puerto 8080 y las interfaces ServiciosCapitales

            ChannelFactory<ServicioCapitales.IInformacionPais> canal;
            canal = new ChannelFactory<ServicioCapitales.IInformacionPais>(new NetTcpBinding(), "net.tcp://localhost:8080");
            ServicioCapitales.IInformacionPais interfaz;
            //Creamos el canal con los parametros necesariso para la comunicacion
            interfaz = canal.CreateChannel();
            //Bucle que se ejecuta de manera infinita hasta que se cumpla alguna de las condiciones.
            while (true)
            {
                //Clear: Usamos para limpiar la pantalla de la consola
                //ForegroundColor: Lo usamos para dar color al texto que aparece en pantall
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Imprimimos la lista de opciones de las cuales puede accesar el usuario
                Console.WriteLine("Uso de WCF... Servidor corriendo...");
                Console.WriteLine();
                string opcion;
                Console.WriteLine("MENÚ DE OPCIONES....ELIJA UNA POR FAVOR");
                Console.WriteLine("1. CAPITAL DE UN PAÍS...");
                Console.WriteLine("2. MODENA DE UN PAÍS...");
                Console.WriteLine("3. PAÍS DE UNA CAPITAL...");
                Console.WriteLine("4. CANTIDAD DE NÚMEROS PRIMOS EN UN RANGO...");
                Console.WriteLine("5. NÚMEROS PRIMOS EN UN RANGO...");
                Console.WriteLine("6. SALIR...");
                Console.WriteLine();
                Console.Write("Ingrese una Opcion: ");
                //Leemos el valor ingresado
                opcion = Console.ReadLine();
                //Dependiendo del valor eingresado enviamos al cliente al caso indicado
                switch (opcion)
                {
                    case "1":
                        {
                            //Variables necesarias para caprurar los datos
                            string pais;
                            string capital;
                            //Ingresamos el nombre de un pais y nos retornara la capital de dicho pais
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("CAPITAL DE UN PAIS");
                            Console.WriteLine();
                            Console.Write("Ingrese un país: ");
                            //Igualamos los ingresado a la variable local para la consulta
                            pais = Console.ReadLine();
                            //Igualamos la variable local con el resultado de la consulta
                            capital = interfaz.ObtenerCapital(pais);
                            //Imprimimos la informacion obtenida
                            Console.WriteLine();
                            Console.WriteLine("Conectado con el servidor...");
                            Console.WriteLine();
                            Console.WriteLine("La capital es: " + capital);
                            Console.WriteLine();
                            //Retornamos al menu principal
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            //Variables necesarias para caprurar los datos
                            string pais;
                            string moneda;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("MONEDA DE UN PAIS");
                            Console.WriteLine();
                            Console.Write("Ingrese un país: ");
                            //Igualamos los ingresado a la variable local para la consulta
                            pais = Console.ReadLine();
                            //Igualamos la variable local con el resultado de la consulta
                            moneda = interfaz.IndicarMoneda(pais);
                            //Imprimimos la informacion obtenida
                            Console.WriteLine();
                            Console.WriteLine("Conectado con el servidor...");
                            Console.WriteLine();
                            Console.WriteLine("La moneda actual usada es: " + moneda);
                            Console.WriteLine();
                            //Retornamos al menu principal
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            //Variables necesarias para caprurar los datos
                            string ciudad;
                            string capital;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("CAPITAL DE UN PAIS");
                            Console.WriteLine();
                            Console.Write("Ingrese una ciudad: ");
                            //Igualamos los ingresado a la variable local para la consulta
                            ciudad = Console.ReadLine();
                            //Igualamos la variable local con el resultado de la consulta
                            capital = interfaz.IndicarPais(ciudad);
                            //Imprimimos la informacion obtenida
                            Console.WriteLine();
                            Console.WriteLine("Conectado con el servidor...");
                            Console.WriteLine();
                            Console.WriteLine("La ciudad pertenece al país con nombre: " + capital);
                            Console.WriteLine();
                            //Retornamos al menu principal
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    case "4":
                        {
                            //Variables necesarias para caprurar los datos
                            int numero_1;
                            int numero_2;
                            bool numero;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("CANTIDAD DE NUMEROS PRIMOS");
                            Console.WriteLine();
                            //Validamos el primer numero sea un numero
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el primer numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable x al valor ingresado
                                numero = Int32.TryParse(Console.ReadLine(), out numero_1);
                                //Se mostrara un mensaje de error si no se ingresa numeros
                                if (!numero)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine();
                                    Console.WriteLine("Debe ingresar solo numeros...");
                                    Console.WriteLine();
                                }
                            }
                            //Se repite el bucle mientras no se ingrese un numero
                            while (!numero);
                            Console.WriteLine();
                            //Validamos el segundo numero
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("Ingrese el segundo numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable x al valor ingresado
                                numero = Int32.TryParse(Console.ReadLine(), out numero_2);
                                //Si en segundo numero es menor al primero o si es un caracter lanzara un mensaje de error
                                if (numero_2 <= numero_1 || !numero)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine();
                                    Console.WriteLine("El valor del segundo numero debe ser mayor al valor del primer numero...");
                                    Console.WriteLine();
                                    Console.WriteLine("Y debe ingresar solo numeros...");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    //realizando la consulta y presentando los datos
                                    Console.WriteLine();
                                    Console.WriteLine("Conectado con el servidor...");
                                    Console.WriteLine();
                                    int resultado = interfaz.ObtenerCantidadDePrimos(numero_1, numero_2);
                                    Console.WriteLine("La cantidad de numeros primos son: " + resultado);
                                    Console.WriteLine();
                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            //Si no se cumple las condiciones no dejara el lazo
                            while (numero_2 <= numero_1 || !numero);
                            break;
                        }
                    case "5":
                        {
                            //Variables necesarias para caprurar los datos
                            int numero_1;
                            int numero_2;
                            bool numero;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("NUMEROS PRIMOS");
                            Console.WriteLine();
                            //Validamos el primer numero sea un numero
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el primer numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable x al valor ingresado
                                numero = Int32.TryParse(Console.ReadLine(), out numero_1);
                                //Se mostrara un mensaje de error si no se ingresa numeros
                                if (!numero)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine();
                                    Console.WriteLine("Debe ingresar solo numeros...");
                                    Console.WriteLine();
                                }
                            }
                            //Se repite el bucle mientras no se ingrese un numero
                            while (!numero);
                            Console.WriteLine();
                            //Validamos el segundo numero sea un numero
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Ingrese el segundo numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable x al valor ingresado
                                numero = Int32.TryParse(Console.ReadLine(), out numero_2);
                                //Si en segundo numero es menor al primero o si es un caracter lanzara un mensaje de error
                                if (numero_2 <= numero_1 || !numero)
                                {
                                    //Presentasion de mensaje de error
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine();
                                    Console.WriteLine("El valor del segundo numero debe ser mayor al valor del primer numero...");
                                    Console.WriteLine();
                                    Console.WriteLine("Y debe ingresar solo numeros...");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    //si las condiciones se cumple se realizara la presentacion de los datos requeridos
                                    Console.WriteLine();
                                    Console.WriteLine("Conectado con el servidor...");
                                    Console.WriteLine();
                                    //Consultando a la interfaz requerida
                                    ArrayList resultado = interfaz.EncontrarPrimos(numero_1, numero_2);
                                    Console.WriteLine("Los numeros primos son: ");
                                    Console.WriteLine();
                                    //recorriendo el arreglo de datos obtenidos y su impresion
                                    for (int i = 0; i < resultado.Count - 1; i++)
                                    {
                                        Console.WriteLine("Resultados: " + resultado[i]);
                                    }
                                    Console.WriteLine();
                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            //Se repite el bucle mientras no se ingrese un numero
                            while (numero_2 <= numero_1 || !numero);
                            break;
                        }
                    case "6":
                        {
                            //La aplicacion se cierra si la opcion ingresada es 6
                            return;
                        }
                    default:
                        {
                            //Si se ingresa algun valor diferente al rango 1 a 6 se lanzara un mensaje de error
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Debe ingresar una opcion correcta...");
                            Console.WriteLine();
                            Console.Write("Presione una tecla para continuar...");
                            //Mantiene la pantalla en espera para que el programa no se cierre
                            Console.ReadKey();
                            break;
                        }
                }
            }
            //Cerramos las interfaces y detenemos el servidor que esta escuchando
            (interfaz as ICommunicationObject).Close();
            ServicioCapitales.Program.StopServer();
        }
    }
}