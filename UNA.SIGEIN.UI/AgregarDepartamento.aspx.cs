using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGEIN
{
    public partial class AgregarDepartamento : System.Web.UI.Page
    {
       
        UNA.SIGEIN.WCF.IService1 wcf = new UNA.SIGEIN.WCF.Service1();
        UNA.SIGEIN.CONTENEDORES.Departamento contDepar = new UNA.SIGEIN.CONTENEDORES.Departamento();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void limpiarTXT() {

            txtCodigoDepar.Text = "";
            txtNombreDepar.Text = "";
            txtDescripcion.Text = "";
        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            contDepar.codigodepartamento = txtCodigoDepar.Text;
            contDepar.nombredepartamento = txtNombreDepar.Text;
            contDepar.descripcion = txtDescripcion.Text;

            wcf.AgregarDepartamento(contDepar);
            limpiarTXT();
            //GridView1.DataBind();
        }

        protected void btnModificar_Click1(object sender, EventArgs e)
        {
            contDepar.codigodepartamento = txtCodigoDepar.Text;
            contDepar.nombredepartamento = txtNombreDepar.Text;
            contDepar.descripcion = txtDescripcion.Text;

            wcf.ActualizarDepartamento(contDepar);
            limpiarTXT();
        }

        protected void btnEliminar_Click1(object sender, EventArgs e)
        {
            contDepar.codigodepartamento = txtCodigoDepar.Text;

            wcf.EliminarDepartamento(contDepar);
            limpiarTXT();
        }

        protected void btnLimpiar_Click1(object sender, EventArgs e)
        {
            limpiarTXT();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtCodigoDepar.Text = GridView1.SelectedRow.Cells[1].Text;
            //txtNombreDepar.Text = GridView1.SelectedRow.Cells[3].Text;
            //txtDescripcion.Text = GridView1.SelectedRow.Cells[2].Text;
        }
    }
}