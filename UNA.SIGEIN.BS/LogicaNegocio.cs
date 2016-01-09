using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.SIGEIN.CONTENEDORES;
using UNA.SIGEIN.DS;

namespace UNA.SIGEIN.BS
{
    
    public class LogicaNegocio : ILogicaNegocio
    {
        DS.IDepartamento cadDepar = new DS.CAD();
        DS.IUsuario cadUsuario = new DS.CAD();
        public void ActualizarDepartamento(Departamento departamento)
        {
            cadDepar.ActualizarDepartamento(departamento);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            cadUsuario.ActualizarUsuario(usuario);
        }

        public void AgregarDepartamento(Departamento departamento)
        {
            cadDepar.AgregarDepartamento(departamento);
        }

        public void AgregarUsuario(Usuario usuario)
        {
            cadUsuario.AgregarUsuario(usuario);
        }

        public Departamento BuscarDepartamento(Departamento departamento)
        {
            return cadDepar.BuscarDepartamento(departamento);
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            return cadUsuario.BuscarUsario(usuario);
        }

        public void EliminarDepartamento(Departamento departamento)
        {
            cadDepar.EliminarDepartamento(departamento);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            cadUsuario.EliminarUsuario(usuario);
        }

        public List<Departamento> ListarDepartamento()
        {
            return cadDepar.ListaDepartamento();
        }

        public List<Usuario> ListarUsuario()
        {
            return cadUsuario.ListaUsuario();
        }

        public Usuario ValidarUsuario(string id, string pass)
        {
            return cadUsuario.ValidarUsuario(id,pass);
        }
    }
}
