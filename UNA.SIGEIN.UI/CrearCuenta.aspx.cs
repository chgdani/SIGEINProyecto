using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGEIN
{
    public partial class CrearCuenta4 : System.Web.UI.Page
    {
        UNA.SIGEIN.WCF.IService1 wcf = new UNA.SIGEIN.WCF.Service1();
        UNA.SIGEIN.CONTENEDORES.Usuario contUsuario = new UNA.SIGEIN.CONTENEDORES.Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void limpiarTXT()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtContraseña.Text = "";
            txtDepartamento.Text = "";
            txtOcupacion.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtCorreo.Text = "";
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            contUsuario.idusuario = txtCedula.Text;
            contUsuario.nombreusuario = txtNombre.Text;
            contUsuario.contraseña = txtContraseña.Text;
            contUsuario.codigodepartamento = txtDepartamento.Text;
            contUsuario.ocupacion = txtOcupacion.Text;
            contUsuario.apellido1 = txtApellido1.Text;
            contUsuario.apellido2 = txtApellido2.Text;
            contUsuario.rol = "U";
            contUsuario.estatusbloqueo = 0;
            contUsuario.accesointrusos = 0;
            contUsuario.correoelectronico = txtCorreo.Text;

            wcf.AgregarUsuario(contUsuario);
            limpiarTXT();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            contUsuario.idusuario = txtCedula.Text;
            contUsuario.nombreusuario = txtNombre.Text;
            contUsuario.contraseña = txtContraseña.Text;
            contUsuario.codigodepartamento = txtDepartamento.Text;
            contUsuario.ocupacion = txtOcupacion.Text;
            contUsuario.apellido1 = txtApellido1.Text;
            contUsuario.apellido2 = txtApellido2.Text;
            contUsuario.rol = "U";
            contUsuario.estatusbloqueo = 0;
            contUsuario.accesointrusos = 0;
            contUsuario.correoelectronico = txtCorreo.Text;

            wcf.ActualizarUsuario(contUsuario);
            limpiarTXT();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            contUsuario.idusuario = txtCedula.Text;

            wcf.EliminarUsuario(contUsuario);
            limpiarTXT();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTXT();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}