using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNA.SIGEIN.CONTENEDORES
{
    public class Usuario
    {
      private string IdUsuario, NombreUsuario, Contraseña, CodigoDepartamento, Ocupacion, Apellido1, Apellido2, Rol, CorreoElectronico;
      private int AccesoIntrusos, EstatusBloqueo;

        public string idusuario
        {
            get
            {
                return IdUsuario;
            }

            set
            {
                IdUsuario = value;
            }
        }

        public string nombreusuario
        {
            get
            {
                return NombreUsuario;
            }

            set
            {
                NombreUsuario = value;
            }
        }

        public string contraseña
        {
            get
            {
                return Contraseña;
            }

            set
            {
                Contraseña = value;
            }
        }

        public string codigodepartamento
        {
            get
            {
                return CodigoDepartamento;
            }

            set
            {
                CodigoDepartamento = value;
            }
        }

        public string ocupacion
        {
            get
            {
                return Ocupacion;
            }

            set
            {
                Ocupacion = value;
            }
        }

        public string apellido1
        {
            get
            {
                return Apellido1;
            }

            set
            {
                Apellido1 = value;
            }
        }

        public string apellido2
        {
            get
            {
                return Apellido2;
            }

            set
            {
                Apellido2 = value;
            }
        }

        public string rol
        {
            get
            {
                return Rol;
            }

            set
            {
                Rol = value;
            }
        }

        public string correoelectronico
        {
            get
            {
                return CorreoElectronico;
            }

            set
            {
                CorreoElectronico = value;
            }
        }

        public int accesointrusos
        {
            get
            {
                return AccesoIntrusos;
            }

            set
            {
                AccesoIntrusos = value;
            }
        }

        public int estatusbloqueo
        {
            get
            {
                return EstatusBloqueo;
            }

            set
            {
                EstatusBloqueo = value;
            }
        }
    }
}
