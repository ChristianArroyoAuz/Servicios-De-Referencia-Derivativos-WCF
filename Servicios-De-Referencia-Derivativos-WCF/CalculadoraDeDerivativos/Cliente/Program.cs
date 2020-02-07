// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 05/08/2016.                                                                              *
// ******************************************************************************************


using Cliente.ServicioDerivativos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForegroundColor: Usado para dar color a las letras de la consola
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Presionar una tecla para iniciar...");
            Console.ReadKey();
            //Bucle que se ejecuta de manera infinita hasta que se cumpla alguna de las condiciones.
            while (true)
            {
                //Variable para recibir la opcion ingresada
                string opcion;
                //Limpiando la pantalla de la consola
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Menu de Opciones
                Console.WriteLine("MENÚ DE OPCIONES....ELIJA UNA POR FAVOR");
                Console.WriteLine();
                Console.WriteLine("1. CALCULADORA DERIVATIVOS...");
                Console.WriteLine("2. SUMA DE DOS NÚMEROS...");
                Console.WriteLine("3. RESTA DE DOS NÚMEROS...");
                Console.WriteLine("4. MULTIPLICACIÓN DE DOS NÚMEROS...");
                Console.WriteLine("5. DIVISION DE DOS NUMEROS...");
                Console.WriteLine("6. SALIR...");
                Console.WriteLine();
                Console.Write("Ingrese su opcion por favor: ");
                //Leyendo la opcion ingresada por el cliente 1, 2, 3 , 4 , 5 , 6
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            //Estableciendo el proxy de servicio a la Decimalerfaz Derivativos
                            CalculadoraDerivativosClient proxy = new CalculadoraDerivativosClient();
                            //Estableciendo los valores necesarios del metodo Derivativo
                            decimal resultado = proxy.CalcularDerivativo(3, new string[] { "MSFT" }, new string[] { });
                            //Cerrando el proxy de la coneccion para permitir otras conexiones
                            proxy.Close();
                            Console.WriteLine("Calcular Derivativo...");
                            Console.WriteLine();
                            //Imprimiendo los resultados
                            Console.WriteLine(string.Format("Resultdado: {0}", resultado));
                            Console.WriteLine();
                            Console.Write("Presione una tecla para continuar...");
                            //Mantiene la pantalla en espera para que el programa no se cierre
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Decimal x;
                            Decimal y;
                            bool numero;
                            Console.WriteLine("Calcular Suma...");
                            Console.WriteLine();
                            //Validamos el primer numero sea un numero
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el primer numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable x al valor ingresado
                                numero = Decimal.TryParse(Console.ReadLine(), out x);
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
                                Console.ForegroundColor = ConsoleColor.Blue;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el segundo numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable y al valor ingresado
                                numero = Decimal.TryParse(Console.ReadLine(), out y);
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
                            //Estableciendo el proxy de servicio a la interfaz Suma
                            CalculadoraSumaClient proxy = new CalculadoraSumaClient();
                            //Ingresando los datos para realizar la operacion indicada
                            Decimal resultado = proxy.CalcularSuma(x, y);
                            //Cerrando el proxy de la coneccion para permitir otras conexiones
                            proxy.Close();
                            //Imprimiendo los resultados
                            Console.WriteLine();
                            Console.WriteLine(string.Format("Resultdado: {0}", resultado));
                            Console.WriteLine();
                            Console.Write("Presione una tecla para continuar...");
                            //Mantiene la pantalla en espera para que el programa no se cierre
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Decimal x;
                            Decimal y;
                            bool numero;
                            Console.WriteLine("Calcular Resta...");
                            Console.WriteLine();
                            //Validamos el primer numero sea un numero
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el primer numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable x al valor ingresado
                                numero = Decimal.TryParse(Console.ReadLine(), out x);
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
                                Console.ForegroundColor = ConsoleColor.Green;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el segundo numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable y al valor ingresado
                                numero = Decimal.TryParse(Console.ReadLine(), out y);
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
                            //Estableciendo el proxy de servicio a la interfaz Resta
                            CalculadoraRestaClient proxy = new CalculadoraRestaClient();
                            //Ingresando los datos para realizar la operacion indicada
                            Decimal resultado = proxy.CalcularResta(x, y);
                            //Cerrando el proxy de la coneccion para permitir otras conexiones
                            proxy.Close();
                            //Imprimiendo los resultados
                            Console.WriteLine();
                            Console.WriteLine(string.Format("Resultdado: {0}", resultado));
                            Console.WriteLine();
                            Console.Write("Presione una tecla para continuar...");
                            //Mantiene la pantalla en espera para que el programa no se cierre
                            Console.ReadKey();
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Decimal x;
                            Decimal y;
                            bool numero;
                            Console.WriteLine("Calcular Multiplicacion...");
                            Console.WriteLine();
                            //Validamos el primer numero sea un numero
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el primer numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable x al valor ingresado
                                numero = Decimal.TryParse(Console.ReadLine(), out x);
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
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el segundo numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable y al valor ingresado
                                numero = Decimal.TryParse(Console.ReadLine(), out y);
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
                            //Estableciendo el proxy de servicio a la interfaz multiplicacion
                            CalculadoraMultiplicacionClient proxy = new CalculadoraMultiplicacionClient();
                            //Ingresando los datos para realizar la operacion indicada
                            Decimal resultado = proxy.CalcularMultiplicacion(x, y);
                            //Cerrando el proxy de la coneccion para permitir otras conexiones
                            proxy.Close();
                            //Imprimiendo los resultados
                            Console.WriteLine();
                            Console.WriteLine(string.Format("Resultdado: {0}", resultado));
                            Console.WriteLine();
                            Console.Write("Presione una tecla para continuar...");
                            //Mantiene la pantalla en espera para que el programa no se cierre
                            Console.ReadKey();
                            break;
                        }
                    case "5":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Decimal x;
                            Decimal y;
                            bool numero;
                            Console.WriteLine("Calcular Division...");
                            Console.WriteLine();
                            //Validamos el primer numero sea un numero
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el primer numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable x al valor ingresado
                                numero = Decimal.TryParse(Console.ReadLine(), out x);
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
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                //Ingresamos el primer numero
                                Console.Write("Ingrese el segundo numero: ");
                                //Validamos la conversion a numero si la respuesta es True e igulamos la variable y al valor ingresado
                                numero = Decimal.TryParse(Console.ReadLine(), out y);
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
                            //Estableciendo el proxy de servicio a la interfaz Division
                            CalculadoraDivisionClient proxy = new CalculadoraDivisionClient();
                            //Ingresando los datos para realizar la operacion indicada
                            Decimal resultado = proxy.CalcularDivision(x, y);
                            //Cerrando el proxy de la coneccion para permitir otras conexiones
                            proxy.Close();
                            //Imprimiendo los resultados
                            Console.WriteLine();
                            Console.WriteLine(string.Format("Resultdado: {0}", resultado));
                            Console.WriteLine();
                            Console.Write("Presione una tecla para continuar...");
                            //Mantiene la pantalla en espera para que el programa no se cierre
                            Console.ReadKey();
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
        }
    }
}