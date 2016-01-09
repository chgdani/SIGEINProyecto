using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.SIGEIN.CONTENEDORES;

namespace UNA.SIGEIN.DS
{
    public interface IUsuario
    {
        void AgregarUsuario(CONTENEDORES.Usuario usuario);

        void ActualizarUsuario(CONTENEDORES.Usuario usuario);

        void EliminarUsuario(CONTENEDORES.Usuario usuario);

        CONTENEDORES.Usuario BuscarUsario(CONTENEDORES.Usuario usuario);

        CONTENEDORES.Usuario ValidarUsuario(string id, string pass);

        List<CONTENEDORES.Usuario> ListaUsuario();

    }

    public interface IDepartamento
    {

        void AgregarDepartamento(CONTENEDORES.Departamento departamento);

        void ActualizarDepartamento(CONTENEDORES.Departamento departamento);

        void EliminarDepartamento(CONTENEDORES.Departamento departamento);

        CONTENEDORES.Departamento BuscarDepartamento(CONTENEDORES.Departamento departamento);

        List<CONTENEDORES.Departamento> ListaDepartamento();

    }
}
