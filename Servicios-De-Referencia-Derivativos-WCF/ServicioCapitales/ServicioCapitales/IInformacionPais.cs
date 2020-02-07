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
    //ServiceContract:Indica que una interfaz o una clase define un contrato de servicio en una aplicación de WCF
    //Interface: Una interfaz contiene definiciones para un grupo de funcionalidades relacionadas que una clase o una estructura pueden poner en práctica
    [ServiceContract]
    public interface IInformacionPais
    {
        //OperationContract: Indica que un método define una operación que forma parte de un contrato de servicio en una aplicación de WCF
        [OperationContract]
        //Metodos para optener los valores deseados, Capital, Pais, Moneda, Numeros Primos y cantidad de numeros primos
        string ObtenerCapital(string pais);
        [OperationContract]
        string IndicarPais(string capital);
        [OperationContract]
        string IndicarMoneda(string pais);
        [OperationContract]
        int ObtenerCantidadDePrimos(int inicio, int fin);
        [OperationContract]
        ArrayList EncontrarPrimos(int inicio, int fin);
    }
}