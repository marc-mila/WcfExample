using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfExample
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.

    //servicio wcf
    [ServiceContract]
    public interface IService1
    {

        //metodo de wcf a traves de customattribute: servicecontract
        [OperationContract]
        int Suma(int num1, int num2);

    }
}
