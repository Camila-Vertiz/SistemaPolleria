using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datProducto
    {
        #region sigleton
        private static readonly datProducto _instancia = new datProducto();
        //privado para evitar la instanciación directa
        public static datProducto Instancia
        {
            get
            {
                return datProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>(); //instanciando una lista
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader(); //Ejecutamos el store procedure
                while (dr.Read()) //mientas el data reader tenga registros
                {
                    entProducto Pro = new entProducto();
                    Pro.codigo_producto = Convert.ToInt32(dr["codigo_producto"]);
                    Pro.nombre_producto = dr["nombre_producto"].ToString();
                    Pro.categoria_producto = dr["categoria_producto"].ToString();
                    Pro.precio_unitario_producto = (float) Convert.ToDouble(dr["precio_unitario_producto"]);
                    Pro.descripcion_producto = dr["descripcion_producto"].ToString();
                    lista.Add(Pro);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public DataSet BuscaProducto(string categoria = null)
        {
            SqlCommand cmd = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProducto", cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@categoria_producto", categoria));
                da.SelectCommand = cmd;
                da.Fill(ds, "Producto");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return ds;
        }
        #endregion metodos
    }
}
