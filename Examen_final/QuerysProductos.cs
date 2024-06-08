using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final
{
    public class QuerysProductos
    {
        string Conexion2 = string.Empty;
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;
        DataTable TablaGenerica = null;
        public QuerysProductos() {
            Conexion cadena = new Conexion();
            Conexion2 = cadena.cadena();
        } 

        public void insertarProducto(EntidadProductos producto)
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            try
            {
                Conexion = new SqlConnection(Conexion2);
                Conexion.Open();
                Cadena = "INSERT INTO Productos VALUES('" + producto.Nombre+ "'," + producto.Precio + "," + producto.Existencia + "," + producto.Codigo_Usuario+ ")";
                Ejecutar = new SqlCommand(Cadena, Conexion);
                Ejecutar.CommandType = System.Data.CommandType.Text;
                Ejecutar.ExecuteNonQuery();
                Mensaje = "Usuario Insertado";
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

        public DataTable Productos()
        {
            DataTable dt = null;
            string Cadena = string.Empty;
            string resultado = string.Empty;
            try
            {
                dt = new DataTable();
                Conexion = new SqlConnection(Conexion2);
                Conexion.Open();

                Cadena = "select * from Productos";
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

        public string UpdateProducto(EntidadProductos Producto)
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            try
            {
                Conexion = new SqlConnection(Conexion2);
                Conexion.Open();
                Cadena = "UPDATE Productos SET Nombre = '" + Producto.Nombre + "',Precio = " + Producto.Precio + ",Existencia =" + Producto.Existencia + " WHERE Codigo= " +Producto.Codigo+ "";
                Ejecutar = new SqlCommand(Cadena, Conexion);
                Ejecutar.CommandType = System.Data.CommandType.Text;
                Ejecutar.ExecuteNonQuery();
                Mensaje = "Se termino de Modificar el producto con el codigo: ";
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
            return Mensaje;

        }

        public void deleteProductos(EntidadProductos Producto)
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            try
            {
                Conexion = new SqlConnection(Conexion2);
                Conexion.Open();
                Cadena = "delete Productos where Codigo= '" + Producto.Codigo + "'";
                Ejecutar = new SqlCommand(Cadena, Conexion);
                Ejecutar.CommandType = System.Data.CommandType.Text;
                Ejecutar.ExecuteNonQuery();
                Mensaje = "Usuario Eliminado";
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
