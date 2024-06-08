using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final
{
    public class QuerysUsuarios
    {

        string Conexion2 = string.Empty;
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;

        public QuerysUsuarios() {
            Conexion cadena = new Conexion();
            Conexion2 = cadena.cadena();
        }



        public DataTable Usuarios()
        {
            DataTable dt = null;
            string Cadena = string.Empty;
            string resultado = string.Empty;
            try
            {
                dt = new DataTable();
                Conexion = new SqlConnection(Conexion2);
                Conexion.Open();
                Cadena = "select * from Usuarios";
                Ejecutar = new SqlCommand(Cadena, Conexion);
                Adaptador = new SqlDataAdapter(Ejecutar);
                Adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexion.Dispose();
                Ejecutar.Dispose();
                Adaptador.Dispose();
            }
            return dt;
        }

        public void insertarUser(EntidadUsuarios usuario)
        {
            string Cadena = string.Empty;
            try
            {
                Conexion = new SqlConnection(Conexion2);
                Conexion.Open();
                Cadena = "INSERT INTO Usuarios VALUES('" + usuario.Usuario + "','" + usuario.Nombre + "')";
                Ejecutar = new SqlCommand(Cadena, Conexion);
                Ejecutar.CommandType = System.Data.CommandType.Text;
                Ejecutar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexion.Dispose();
                Ejecutar.Dispose();
            }
        }

    }
}
