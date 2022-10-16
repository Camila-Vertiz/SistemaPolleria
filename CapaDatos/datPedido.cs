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
                cmd.Parameters.AddWithValue("@id_cliente", pe.oCliente.id_cliente);
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

        #endregion metodos
    }
}
