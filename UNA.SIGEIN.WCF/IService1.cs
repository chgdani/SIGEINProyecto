using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UNA.SIGEIN.CONTENEDORES;
using UNA.SIGEIN.BS;

namespace UNA.SIGEIN.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void AgregarUsuario(CONTENEDORES.Usuario usuario);

        [OperationContract]
        void ActualizarUsuario(CONTENEDORES.Usuario usuario);

        [OperationContract]
        void EliminarUsuario(CONTENEDORES.Usuario usuario);

        [OperationContract]
        CONTENEDORES.Usuario BuscarUsuario(CONTENEDORES.Usuario usuario);

        [OperationContract]
        CONTENEDORES.Usuario ValidarUsuario(string id, string pass);

        [OperationContract]
        List<CONTENEDORES.Usuario> ListarUsuario();

        [OperationContract]
        void AgregarDepartamento(CONTENEDORES.Departamento departamento);

        [OperationContract]
        void ActualizarDepartamento(CONTENEDORES.Departamento departamento);

        [OperationContract]
        void EliminarDepartamento(CONTENEDORES.Departamento departamento);

        [OperationContract]
        CONTENEDORES.Departamento BuscarDepartamento(CONTENEDORES.Departamento departamento);

        [OperationContract]
        List<CONTENEDORES.Departamento> ListarDepartamento();

    }
}
