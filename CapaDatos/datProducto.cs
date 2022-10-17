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
        public entProducto BuscaProductoId(int codigoProducto)
        {
            SqlCommand cmd = null;
            entProducto Pro = new entProducto();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaProductoId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_producto", codigoProducto);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Pro.codigo_producto = Convert.ToInt32(dr["codigo_producto"]);
                    Pro.nombre_producto = dr["nombre_producto"].ToString();
                    Pro.categoria_producto = dr["categoria_producto"].ToString();
                    Pro.precio_unitario_producto = float.Parse(dr["precio_unitario_producto"].ToString());
                    Pro.descripcion_producto = dr["descripcion_producto"].ToString();
                    Pro.stock_producto = Convert.ToInt32(dr["stock_producto"]);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Pro;
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
        public DataSet BuscaNombreProducto(string nombre = null)
        {
            SqlCommand cmd = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarNombreProducto", cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombre_producto", nombre));
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
        public DataSet ConsultaProductoId(int codigoProducto)
        {
            SqlCommand cmd = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaProductoId", cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo_producto", codigoProducto));
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
        public Boolean InsertaProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_producto", Pro.nombre_producto);
                cmd.Parameters.AddWithValue("@categoria_producto", Pro.categoria_producto);
                cmd.Parameters.AddWithValue("@precio_unitario_producto", Pro.precio_unitario_producto);
                cmd.Parameters.AddWithValue("@descripcion_producto", Pro.descripcion_producto);
                cmd.Parameters.AddWithValue("@stock_producto", Pro.stock_producto);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public Boolean EditaProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_producto", Pro.codigo_producto);
                cmd.Parameters.AddWithValue("@nombre_producto", Pro.nombre_producto);
                cmd.Parameters.AddWithValue("@categoria_producto", Pro.categoria_producto);
                cmd.Parameters.AddWithValue("@precio_unitario_producto", Pro.precio_unitario_producto);
                cmd.Parameters.AddWithValue("@descripcion_producto", Pro.descripcion_producto);
                cmd.Parameters.AddWithValue("@stock_producto", Pro.stock_producto);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }


        public Boolean EliminaProductos(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_producto", Pro.codigo_producto);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }


        #endregion metodos
    }
}
