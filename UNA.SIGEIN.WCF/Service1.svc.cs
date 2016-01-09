using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UNA.SIGEIN.CONTENEDORES;

namespace UNA.SIGEIN.WCF
{
    public class Service1 : IService1
    {
        UNA.SIGEIN.BS.ILogicaNegocio BS = new UNA.SIGEIN.BS.LogicaNegocio();
        public void ActualizarDepartamento(Departamento departamento)
        {
            BS.ActualizarDepartamento(departamento);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            BS.ActualizarUsuario(usuario);
        }

        public void AgregarDepartamento(Departamento departamento)
        {
            BS.AgregarDepartamento(departamento);
        }

        public void AgregarUsuario(Usuario usuario)
        {
            BS.AgregarUsuario(usuario);
        }

        public Departamento BuscarDepartamento(Departamento departamento)
        {
            return BS.BuscarDepartamento(departamento);
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            return BS.BuscarUsuario(usuario);
        }

        public void EliminarDepartamento(Departamento departamento)
        {
            BS.EliminarDepartamento(departamento);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            BS.EliminarUsuario(usuario);
        }

        public List<Departamento> ListarDepartamento()
        {
            return BS.ListarDepartamento();
        }

        public List<Usuario> ListarUsuario()
        {
            return BS.ListarUsuario();
        }

        public Usuario ValidarUsuario(string id, string pass)
        {
            return BS.ValidarUsuario(id,pass);
        }
    }
}
