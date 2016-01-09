using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.SIGEIN.CONTENEDORES;

namespace UNA.SIGEIN.DS
{
    public class CAD : IUsuario, IDepartamento
    {
        CONTENEDORES.Departamento conteDepartamento = new CONTENEDORES.Departamento();
        CONTENEDORES.Usuario conteUsuario = new CONTENEDORES.Usuario();

       
        public void AgregarUsuario(CONTENEDORES.Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AgregarUsuario";

            cmd.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@idUsuario"].Value = usuario.idusuario;

            cmd.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@nombre"].Value = usuario.nombreusuario;

            cmd.Parameters.Add(new SqlParameter("@contraseña", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@contraseña"].Value = usuario.contraseña;

            cmd.Parameters.Add(new SqlParameter("@codDepar", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@codDepar"].Value = usuario.codigodepartamento;

            cmd.Parameters.Add(new SqlParameter("@ocupacion", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@ocupacion"].Value = usuario.ocupacion;

            cmd.Parameters.Add(new SqlParameter("@ape1", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape1"].Value = usuario.apellido1;

            cmd.Parameters.Add(new SqlParameter("@ape2", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape2"].Value = usuario.apellido2;

            cmd.Parameters.Add(new SqlParameter("@rol", System.Data.SqlDbType.VarChar, 1));
            cmd.Parameters["@rol"].Value = usuario.rol;

            cmd.Parameters.Add(new SqlParameter("@estatusBloqueo", System.Data.SqlDbType.Bit));
            cmd.Parameters["@estatusBloqueo"].Value = usuario.estatusbloqueo;

            cmd.Parameters.Add(new SqlParameter("@accesoIntrusos", System.Data.SqlDbType.SmallInt));
            cmd.Parameters["@accesoIntrusos"].Value = usuario.accesointrusos;

            cmd.Parameters.Add(new SqlParameter("@correo", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@correo"].Value = usuario.correoelectronico;


            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public void ActualizarUsuario(CONTENEDORES.Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarUsuario";

            cmd.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@idUsuario"].Value = usuario.idusuario;

            cmd.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@nombre"].Value = usuario.nombreusuario;

            cmd.Parameters.Add(new SqlParameter("@contraseña", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@contraseña"].Value = usuario.contraseña;

            cmd.Parameters.Add(new SqlParameter("@codDepar", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@codDepar"].Value = usuario.codigodepartamento;

            cmd.Parameters.Add(new SqlParameter("@ocupacion", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@ocupacion"].Value = usuario.ocupacion;

            cmd.Parameters.Add(new SqlParameter("@ape1", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape1"].Value = usuario.apellido1;

            cmd.Parameters.Add(new SqlParameter("@ape2", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape2"].Value = usuario.apellido2;

            cmd.Parameters.Add(new SqlParameter("@rol", System.Data.SqlDbType.VarChar, 1));
            cmd.Parameters["@rol"].Value = usuario.rol;

            cmd.Parameters.Add(new SqlParameter("@estatusBloqueo", System.Data.SqlDbType.Bit));
            cmd.Parameters["@estatusBloqueo"].Value = usuario.estatusbloqueo;

            cmd.Parameters.Add(new SqlParameter("@accesoIntrusos", System.Data.SqlDbType.SmallInt));
            cmd.Parameters["@accesoIntrusos"].Value = usuario.accesointrusos;

            cmd.Parameters.Add(new SqlParameter("@correo", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@correo"].Value = usuario.correoelectronico;


            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public void EliminarUsuario(CONTENEDORES.Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarUsuario";

            cmd.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@idUsuario"].Value = usuario.idusuario;


            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public Usuario BuscarUsario(CONTENEDORES.Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlDataReader dtr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ConsultarUsuario";
              
            cmd.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@idUsuario"].Value = usuario.idusuario;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows)
            {
                dtr.Read();
                conteUsuario.idusuario = Convert.ToString(dtr[0]);
                conteUsuario.nombreusuario = Convert.ToString(dtr[1]);
                conteUsuario.contraseña = Convert.ToString(dtr[2]);
                conteUsuario.codigodepartamento = Convert.ToString(dtr[3]);
                conteUsuario.ocupacion = Convert.ToString(dtr[4]);
                conteUsuario.apellido1 = Convert.ToString(dtr[5]);
                conteUsuario.apellido2 = Convert.ToString(dtr[6]);
                conteUsuario.rol = Convert.ToString(dtr[7]);
                conteUsuario.estatusbloqueo = Convert.ToInt32(dtr[8]);
                conteUsuario.accesointrusos = Convert.ToInt32(dtr[9]);
                conteUsuario.correoelectronico = Convert.ToString(dtr[10]);
            }

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            cmd.Parameters.Clear();

            return conteUsuario;
        }

        public List<Usuario> ListaUsuario()
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("ConsultarUsuarios", cnn);

            SqlDataReader Lector;
            List<CONTENEDORES.Usuario> lista = new List<CONTENEDORES.Usuario>();
            CONTENEDORES.Usuario Temp;    
            cmd.CommandType = CommandType.StoredProcedure;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Temp = new CONTENEDORES.Usuario();
                    Temp.idusuario = Lector.GetValue(0).ToString();
                    Temp.nombreusuario = Lector.GetValue(1).ToString();
                    Temp.contraseña = Lector.GetValue(2).ToString();
                    Temp.codigodepartamento = Lector.GetValue(3).ToString();
                    Temp.ocupacion = Lector.GetValue(4).ToString();
                    Temp.apellido1 = Lector.GetValue(5).ToString();
                    Temp.apellido2 = Lector.GetValue(6).ToString();
                    Temp.rol = Lector.GetValue(7).ToString();
                    Temp.estatusbloqueo = (int)Lector.GetValue(8);
                    Temp.accesointrusos = (int)Lector.GetValue(9);
                    Temp.correoelectronico = Lector.GetValue(10).ToString();

                lista.Add(Temp);              
            }
            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            return lista;

        }

        public void AgregarDepartamento(CONTENEDORES.Departamento departamento)
        {

            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AgregarDepartamento";

            cmd.Parameters.Add(new SqlParameter("@codDepar", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@codDepar"].Value = departamento.codigodepartamento;

            cmd.Parameters.Add(new SqlParameter("@nomDepar", System.Data.SqlDbType.VarChar, 100));
            cmd.Parameters["@nomDepar"].Value = departamento.nombredepartamento;

            cmd.Parameters.Add(new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 200));
            cmd.Parameters["@descripcion"].Value = departamento.descripcion;



            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public void ActualizarDepartamento(CONTENEDORES.Departamento departamento)
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarDepartamento";

            cmd.Parameters.Add(new SqlParameter("@codDepar", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@codDepar"].Value = departamento.codigodepartamento;

            cmd.Parameters.Add(new SqlParameter("@nomDepar", System.Data.SqlDbType.VarChar, 100));
            cmd.Parameters["@nomDepar"].Value = departamento.nombredepartamento;

            cmd.Parameters.Add(new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 200));
            cmd.Parameters["@descripcion"].Value = departamento.descripcion;



            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public void EliminarDepartamento(CONTENEDORES.Departamento departamento)
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarDepartamento";

            cmd.Parameters.Add(new SqlParameter("@codDepar", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@codDepar"].Value = departamento.codigodepartamento;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public Departamento BuscarDepartamento(CONTENEDORES.Departamento departamento)
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlDataReader dtr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ConsultarDepartamento";

            cmd.Parameters.Add(new SqlParameter("@codDepar", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@codDepar"].Value = departamento.codigodepartamento;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows)
            {
                dtr.Read();
                conteDepartamento.codigodepartamento = Convert.ToString(dtr[0]);
                conteDepartamento.nombredepartamento = Convert.ToString(dtr[1]);
                conteDepartamento.descripcion = Convert.ToString(dtr[2]);
            }

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            cmd.Parameters.Clear();

            return conteDepartamento;
        }

        public List<Departamento> ListaDepartamento()
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("ConsultarDepartamentos", cnn);

            SqlDataReader Lector;
            List<CONTENEDORES.Departamento> lista = new List<CONTENEDORES.Departamento>();
            CONTENEDORES.Departamento Temp;
            cmd.CommandType = CommandType.StoredProcedure;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            Lector = cmd.ExecuteReader();
            while (Lector.Read())
            {
                Temp = new CONTENEDORES.Departamento();
                Temp.codigodepartamento = Lector.GetValue(0).ToString();
                Temp.nombredepartamento = Lector.GetValue(1).ToString();
                Temp.descripcion = Lector.GetValue(2).ToString();
        

                lista.Add(Temp);
            }
            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            return lista;

        }

        public Usuario ValidarUsuario(string id, string pass)
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True"); SqlDataReader dtr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ValidarUsuario";

            cmd.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@IdUsuario"].Value = id;

            cmd.Parameters.Add(new SqlParameter("@Contraseña", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Contraseña"].Value = pass;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows)
            {
                dtr.Read();
                conteUsuario.idusuario = Convert.ToString(dtr[0]);
                conteUsuario.contraseña = Convert.ToString(dtr[1]);
            }

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

            cmd.Parameters.Clear();
            return conteUsuario;
        }
    }
}


