using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.SIGEIN.CONTENEDORES;
using UNA.SIGEIN.DS;

namespace UNA.SIGEIN.BS
{
    
    public interface ILogicaNegocio
    {
        void AgregarUsuario(CONTENEDORES.Usuario usuario);

        void ActualizarUsuario(CONTENEDORES.Usuario usuario);

        void EliminarUsuario(CONTENEDORES.Usuario usuario);

        CONTENEDORES.Usuario BuscarUsuario(CONTENEDORES.Usuario usuario);

        CONTENEDORES.Usuario ValidarUsuario(string id, string pass);


        List<CONTENEDORES.Usuario> ListarUsuario();

        void AgregarDepartamento(CONTENEDORES.Departamento departamento);

        void ActualizarDepartamento(CONTENEDORES.Departamento departamento);

        void EliminarDepartamento(CONTENEDORES.Departamento departamento);

        CONTENEDORES.Departamento BuscarDepartamento(CONTENEDORES.Departamento departamento);

        List<CONTENEDORES.Departamento> ListarDepartamento();

        
    }

   
}
