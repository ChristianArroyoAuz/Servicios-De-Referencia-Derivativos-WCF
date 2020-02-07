// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 05/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System;

namespace ServicioCalculadoraDerivativos
{
    //Llamando a las interfaces de los metodos Derivar, Suma, Resta, Multiplicacion y division
    public class Calculadora : ICalculadoraDerivativos, ICalculadoraSuma, ICalculadoraResta, ICalculadoraMultiplicacion, ICalculadoraDivision
    {
        //Metodo que me devuelve el resultado del tiempo en ejeucion en mlisegundos
        public Decimal CalcularDerivativo(int dias, string[] simboloss, string[] funciones)
        {
            return (decimal)(System.DateTime.Now.Millisecond);
        }

        //Metodo que me devuelve el resultado de la suma
        public Decimal CalcularSuma(Decimal x, Decimal y)
        {
            return (decimal)(x + y);
        }

        //Metodo que me devuelve el resultado de la resta
        public Decimal CalcularResta(Decimal x, Decimal y)
        {
            return (decimal)(x - y);
        }

        //Metodo que me devuelve el resultado de la smultiplicacion
        public Decimal CalcularMultiplicacion(Decimal x, Decimal y)
        {
            return (decimal)(x * y);
        }

        //Metodo que me devuelve el resultado de la division
        public Decimal CalcularDivision(Decimal x, Decimal y)
        {
            //Funcionalidad que revisa la division para cero
            if (y == 0)
            {
                //Si la division es para cero retornara como resultado 0
                return (decimal)(0);
            }
            else
            {
                return (decimal)(x / y);
            }
        }
    }
}