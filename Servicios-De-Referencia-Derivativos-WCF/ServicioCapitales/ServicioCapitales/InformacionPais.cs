// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 05/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Collections;
using System.Linq;
using System.Text;
using System;

namespace ServicioCapitales
{
    //Obtiene o establece el valor que indica cuando se crean nuevos objetos de servicio.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    //Heredando de la interfaz IInformacionPais
    public class InformacionPais : IInformacionPais
    {
        //Metodo para obtener la capital de un pais cuando se ingresa el nombre del pais
        public string ObtenerCapital(string pais)
        {
            if (pais == "Ecuador" || pais == "ecuador")
            {
                return "Quito";
            }
            if (pais == "Colombia" || pais == "colombia")
            {
                return "Bogota";
            }
            if (pais == "Peru" || pais == "peru")
            {
                return "Lima";
            }
            if (pais == "Alemania" || pais == "alemania")
            {
                return "Berlin";
            }
            if (pais == "EEUU" || pais == "eeuu" || pais == "estados unidos" || pais == "Estados Unidos")
            {
                return "Whashington";
            }
            if (pais == "Mexico" || pais == "mexico")
            {
                return "Mexico";
            }
            //Si el texto ingresado no corresponde a ninguno de los paises registrados devolvera como resultado "Pais Desconocido"
            //Esto incluye si se ingresa numero o caracteres especiales
            else
            {
                return "Pais Desconocido";
            }
        }

        //Metodo que me devuelve el nombre del pais cuando se ingresa la capital
        public string IndicarPais(string capital)
        {
            if (capital == "Quito" || capital == "quito")
            {
                return "Ecuador";
            }
            if (capital == "Bogota" || capital == "bogota")
            {
                return "Colombia";
            }
            if (capital == "Berlin" || capital == "berlin")
            {
                return "Alemania";
            }
            if (capital == "Washington" || capital == "washington")
            {
                return "E.E.U.U.";
            }
            if (capital == "Lima" || capital == "lima")
            {
                return "Perú";
            }
            if (capital == "Mexico" || capital == "mexico")
            {
                return "México";
            }
            //Si el texto ingresado no corresponde a ninguna de las capitales registradas devolvera como resultado "Capital Desconocida"
            //Esto incluye si se ingresa numero o caracteres especiales
            else
            {
                return "Capital Desconocida";
            }
        }

        //Metodo que me indica la moneda de cada pais cuando se ingresa el nombre del pais
        public string IndicarMoneda(string pais)
        {
            if (pais == "Ecuador" || pais == "ecuador")
            {
                return "Dolar";
            }
            if (pais == "Colombia" || pais == "colombia")
            {
                return "Peso colombiano";
            }
            if (pais == "Alemania" || pais == "alemania")
            {
                return "Euro";
            }
            if (pais == "EEUU" || pais == "eeuu" || pais == "estados unidos" || pais == "Estados Unidos")
            {
                return "Dolar";
            }
            if (pais == "Peru" || pais == "peru")
            {
                return "Sol";
            }
            if (pais == "Mexico" || pais == "mexico")
            {
                return "Pesos";
            }
            //Si el texto ingresado no corresponde a ninguno de los paises registrado devolvera como resultado "Pais Desconocido"
            //Esto incluye si se ingresa numero o caracteres especiales
            else
            {
                return "Pais desconocido";
            }
        }


        //metodo para obtener los numeros primos dentro de un intervalo, de dos numeros ingresados
        public int ObtenerCantidadDePrimos(int inicio, int fin)
        {
            //Cantidad de numeros primos
            int num = 0;
            //Igualamos con el valor ingresado
            int var = inicio;
            do
            {
                int a = 0;
                //Creamos un bucle hasta el valor ingresado como final
                for (int i = 1; i < (fin + 1); i++)
                {
                    if (var % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    num++;
                }
                var++;
            }
            while (var != fin + 1);
            {
                //retornamos el numero e numeros primos
                return num;
            }
        }

        //Metodo que me crea un arreglo de numeros que me devuelve como resultado los numeros primos dentro de un rango ingresado
        public ArrayList EncontrarPrimos(int inicio, int fin)
        {
            //Creamos un arreglo de numero
            ArrayList prim = new ArrayList();
            //Ponemos inicio al intervalo de numeros
            int au = inicio;
            do
            {
                int a = 0;
                //Creamos un bucle dentro del rango establecido
                for (int i = 1; i < (fin + 1); i++)
                {
                    if (au % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    prim.Add(au);
                }
                au++;
            }
            while (au != fin + 1);
            {
                //Renornamos el arreglo de numeros
                return prim;
            }
        }
    }
}