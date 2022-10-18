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
    public class datPedido
    {
        #region sigleton
        private static readonly datPedido _instancia = new datPedido();
        //privado para evitar la instanciación directa
        public static datPedido Instancia
        {
            get
            {
                return datPedido._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            SqlCommand cmd = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                StringBuilder query = new StringBuilder();
                query.AppendLine("select count(*) +1 from Pedido");
                cmd = new SqlCommand(query.ToString(), cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();

                idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception e)
            {
                idCorrelativo = 0;
            }
            finally { cmd.Connection.Close(); }

            return idCorrelativo;
        }

        public bool InsertarPedido(entPedido pe, DataTable EDetalle_Pedido, out string Mensaje)
        {
            SqlCommand cmd = null;
            Boolean Respuesta = false;
            Mensaje = String.Empty;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mesa", pe.oMesa.id_mesa);
                cmd.Parameters.AddWithValue("@id_usuario", pe.oUsuario.id_usuario);
                cmd.Parameters.AddWithValue("@numeroDocumento_cliente", pe.numeroDocumento_cliente);
                cmd.Parameters.AddWithValue("@nombre_cliente", pe.nombre_cliente);
                cmd.Parameters.AddWithValue("@tipoComprobante_pedido", pe.tipoComprobante_pedido);
                cmd.Parameters.AddWithValue("@numeroComprobante_pedido", pe.numeroComprobante_pedido);
                cmd.Parameters.AddWithValue("@montoPago_pedido", pe.montoPago_pedido);
                cmd.Parameters.AddWithValue("@montoCambio_pedido", pe.montoCambio_pedido);
                cmd.Parameters.AddWithValue("@montoTotal_pedido", pe.montoTotal_pedido);
                cmd.Parameters.AddWithValue("@estado_pedido", pe.estado_pedido);
                cmd.Parameters.AddWithValue("@EDetalle_Pedido", EDetalle_Pedido);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                cn.Open();

                cmd.ExecuteNonQuery();
                Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception e)
            {
                Respuesta = false;
                Mensaje = e.Message;
            }
            finally { cmd.Connection.Close(); }
            return Respuesta;
        }

        public bool RestarStock(int codigo_producto, int cantidad)
        {
            bool respuesta = true;

            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                StringBuilder query = new StringBuilder();
                query.AppendLine("update Producto set stock_producto = stock_producto - @cantidad where codigo_producto=@codigo_producto");
                cmd = new SqlCommand(query.ToString(), cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@codigo_producto", codigo_producto);
                cn.Open();

                respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

            }
            catch (Exception e)
            {
                respuesta = false;
            }
            finally { cmd.Connection.Close(); }

            return respuesta;
        }

        public bool SumarStock(int codigo_producto, int cantidad)
        {
            bool respuesta = true;

            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                StringBuilder query = new StringBuilder();
                query.AppendLine("update Producto set stock_producto = stock_producto + @cantidad where codigo_producto=@codigo_producto");
                cmd = new SqlCommand(query.ToString(), cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@codigo_producto", codigo_producto);
                cn.Open();

                respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

            }
            catch (Exception e)
            {
                respuesta = false;
            }
            finally { cmd.Connection.Close(); }

            return respuesta;
        }

        public entPedido ObtenerPedido (string numero)
        {
            entPedido pedido = new entPedido();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                StringBuilder query = new StringBuilder();
                query.AppendLine("select pe.codigo_pedido, u.nombre_usuario, pe.numeroDocumento_cliente,pe.nombre_cliente,");
                query.AppendLine("pe.tipoComprobante_pedido, pe.numeroComprobante_pedido,");
                query.AppendLine("m.numero_mesa, m.ubicacion_mesa,");
                query.AppendLine("pe.montoPago_pedido,pe.montoCambio_pedido,pe.montoTotal_pedido,");
                query.AppendLine("convert(char(10),pe.fechaCreacion_pedido,103)[fechaCreacion_pedido]");
                query.AppendLine("from Pedido pe");
                query.AppendLine("inner join Usuario u on u.id_usuario=pe.id_usuario");
                query.AppendLine("inner join Mesa m on m.id_mesa=pe.id_mesa");
                query.AppendLine("where pe.numeroComprobante_pedido='@numero'");
                cmd = new SqlCommand(query.ToString(), cn);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.CommandType = CommandType.Text;
                cn.Open();

               using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        pedido = new entPedido()
                        {
                            codigo_pedido = int.Parse(dr["codigo_pedido"].ToString()),
                            oUsuario = new entUsuario() { nombre_usuario = dr["nombre_usuario"].ToString() },
                            numeroDocumento_cliente = dr["numeroDocumento_cliente"].ToString(),
                            nombre_cliente = dr["nombre_cliente"].ToString(),
                            tipoComprobante_pedido = dr["tipoComprobante_pedido"].ToString(),
                            numeroComprobante_pedido = dr["numeroComprobante_pedido"].ToString(),
                            oMesa = new entMesa { numero_mesa = dr["numero_mesa"].ToString(), ubicacion_mesa = dr["ubicacion_mesa"].ToString() },
                            montoPago_pedido = (float)Convert.ToDecimal(dr["montoPago_pedido"].ToString()),
                            montoCambio_pedido = (float)Convert.ToDecimal(dr["montoCambio_pedido"].ToString()),
                            montoTotal_pedido = (float)Convert.ToDecimal(dr["montoTotal_pedido"].ToString()),
                            fechaCreacion_pedido = Convert.ToDateTime(dr["fechaCreacion_pedido"].ToString())
                        };
                    }
                }

            }
            catch (Exception e)
            {
                pedido = new entPedido();
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return pedido;
        }

        public List<entDetallePedido> ObtenerDetallePedido(int codigo_pedido)
        {
            List<entDetallePedido> detallePedidos = new List<entDetallePedido>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("select p.nombre_producto, det.precioUnitario_detallePedido,det.cantidad_detallePedido,det.subtotal_detallePedido");
                query.AppendLine("from DetallePedido det");
                query.AppendLine("inner join Producto p on p.codigo_producto=det.codigo_producto");
                query.AppendLine("where det.id_detallePedido=@codigo_pedido");
                cmd = new SqlCommand(query.ToString(), cn);
                cmd.Parameters.AddWithValue("@codigo_pedido", codigo_pedido);
                cmd.CommandType = CommandType.Text;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        detallePedidos.Add(new entDetallePedido()
                        {
                            codigo_producto=new entProducto() { nombre_producto = dr["nombre_producto"].ToString() },
                            precioUnitario_detallePedido=(float)Convert.ToDecimal(dr["precioUnitario_detallePedido"].ToString()),
                            cantidad_detallePedido = Convert.ToInt32(dr["cantidad_detallePedido"].ToString()),
                            subtotal_detallePedido = (float)Convert.ToDecimal(dr["subtotal_detallePedido"].ToString()),

                        });
                    }
                }

            }
            catch (Exception e)
            {
                detallePedidos = new List<entDetallePedido>();
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return detallePedidos;
        }

        #endregion metodos
    }
}
