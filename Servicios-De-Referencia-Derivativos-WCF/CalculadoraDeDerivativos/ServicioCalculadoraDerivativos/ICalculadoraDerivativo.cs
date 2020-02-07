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
    //ServiceContract:Indica que una interfaz o una clase define un contrato de servicio en una aplicación de WCF
    //Interface: Una interfaz contiene definiciones para un grupo de funcionalidades relacionadas que una clase o una estructura pueden poner en práctica
    [ServiceContract]
    public interface ICalculadoraDerivativos
    {
        //OperationContract: Indica que un método define una operación que forma parte de un contrato de servicio en una aplicación de WCF
        [OperationContract]
        //Metodo para devolver los milisegundos de la ejucocion del metodo
        Decimal CalcularDerivativo(int dias, string[] simboloss, string[] funciones);
    }

    [ServiceContract]
    public interface ICalculadoraSuma
    {
        [OperationContract]
        //Metodo para realzar la suma de dos numeros
        Decimal CalcularSuma(Decimal x, Decimal y);
    }

    [ServiceContract]
    public interface ICalculadoraResta
    {
        [OperationContract]
        //Metodo para realzar la resta de dos numeros
        Decimal CalcularResta(Decimal x, Decimal y);
    }

    [ServiceContract]
    public interface ICalculadoraMultiplicacion
    {
        [OperationContract]
        //Metodo para realzar la multiplicacion de dos numeros
        Decimal CalcularMultiplicacion(Decimal x, Decimal y);
    }

    [ServiceContract]
    public interface ICalculadoraDivision
    {
        [OperationContract]
        //Metodo para realzar la division de dos numeros
        Decimal CalcularDivision(Decimal x, Decimal y);
    }
}