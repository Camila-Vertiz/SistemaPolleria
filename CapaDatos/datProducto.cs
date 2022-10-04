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
        public DataSet ListarProducto()
        {
            SqlCommand cmd = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaProducto", cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
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
