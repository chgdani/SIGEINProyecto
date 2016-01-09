using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGEIN
{
    public partial class Principal1 : System.Web.UI.Page
    {

        UNA.SIGEIN.WCF.IService1 wcf = new UNA.SIGEIN.WCF.Service1();
        UNA.SIGEIN.CONTENEDORES.Usuario contUsuario = new UNA.SIGEIN.CONTENEDORES.Usuario();
        UNA.SIGEIN.CONTENEDORES.Usuario contUsuario2 = new UNA.SIGEIN.CONTENEDORES.Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
           

            contUsuario = wcf.ValidarUsuario(Login1.UserName,Login1.Password);


            if (contUsuario.idusuario != null)
            {

                Response.Redirect("CrearCuenta.aspx");
            }
        }
      
}
}