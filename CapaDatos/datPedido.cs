//using CapaEntidad;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CapaDatos
//{
//    public class datPedido
//    {
//        #region singleton
//        private static readonly datPedido _instancia = new datPedido();
//        public static datPedido Instancia
//        {
//            get { return datPedido._instancia; }
//        }
//        #endregion singleton

//        #region metodos
//        public List<entPedido> ListarPedido()
//        {
//            SqlCommand cmd = null;
//            List<entPedido> lista = new List<entPedido>();
//            try
//            {
//                SqlConnection cn = Conexion.Instancia.conectar();
//                cmd = new SqlCommand("spListarPedido", cn);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cn.Open();
//                SqlDataReader dr = cmd.ExecuteReader();

//                while (dr.Read())
//                {
//                    entPedido Ped = new entPedido();
//                    //----Ped.idCliente = new entCliente();
//                    entCliente Cli = new entCliente();

//                    Ped.idPedido = Convert.ToInt32(dr["idPedido"]);
//                    Ped.estPedido = Convert.ToBoolean(dr["estPedido"]);
//                    Ped.fechPedido = Convert.ToDateTime(dr["fechPedido"]);

//                    //----Ped.idCliente.idCliente = Convert.ToInt32(dr["idCliente"]);
//                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
//                    Cli.RazonSocial = dr["RazonSocial"].ToString();


//                    Ped.idCliente = Cli;
//                    //Ped.idCliente.idCliente =Cli.idCliente;
//                    //Ped.idCliente = (entCliente) Cli.idCliente;
//                    //Ped.idCliente.idCliente = (int) Cli.idCliente;
//                    //Console.WriteLine("idCliente "+Ped.idCliente.idCliente);



//                    //////////pd.idDetPedido= Convert.ToInt16(dr["idDetPedido"]);
//                    //////////Ped.idPedido= pd.idPedido;
//                    //////////pd.cantProducto = Convert.ToInt16(dr["canProducto"]);
//                    //////////pd.precProducto = Convert.ToDecimal(dr["precProducto"]);
//                    //pd.Importe = Convert.ToDecimal(dr["Importe"]);
//                    //pd.Importe = (Decimal)(dr["Importe"]);
//                    Ped.TotPedido = Convert.ToDouble(dr["TotPedido"]);
//                    lista.Add(Ped);

//                }
//            }
//            catch (Exception e)
//            {
//                throw e;
//            }
//            finally { cmd.Connection.Close(); }
//            return lista;
//        }
//        public string InsertarPedido(entPedido Ped, List<entDetallePedido> Detalle)
//        {

//            SqlCommand cmd = null;
//            int idPed = 0;
//            String insertar = "";
//            try
//            {
//                SqlConnection cn = Conexion.Instancia.Conectar();
//                SqlTransaction tr = cn.BeginTransaction();
//                cmd.Transaction = tr;
//                cmd = new SqlCommand("spInsertaPedido", cn);
//                cmd.CommandType = CommandType.StoredProcedure;

//                cmd.Parameters.AddWithValue("@id_mesa", Ped.mesa.id_mesa);
//                cmd.Parameters.AddWithValue("@id_usuario", Ped.usuario.id_usuario);
//                cmd.Parameters.AddWithValue("@id_cliente", Ped.cliente.id_cliente);
//                cmd.Parameters.AddWithValue("@numeroDocumento_cliente", Ped.numeroDocumento_cliente);
//                cmd.Parameters.AddWithValue("@nombre_cliente", Ped.nombre_cliente);
//                cmd.Parameters.AddWithValue("@tipoComprobante_pedido", Ped.tipoComprobante_pedido);
//                cmd.Parameters.AddWithValue("@numeroComprobante_pedido", Ped.numeroComprobante_pedido);
//                cmd.Parameters.AddWithValue("@montoPago_pedido", Ped.montoPago_pedido);
//                cmd.Parameters.AddWithValue("@montoCambio_pedido", Ped.montoCambio_pedido);
//                cmd.Parameters.AddWithValue("@montoTotal_pedido", Ped.montoTotal_pedido);
//                cmd.Parameters.AddWithValue("@estado_pedido", Ped.estado_pedido);
//                cmd.Parameters.AddWithValue("@fechaCreacion_pedido", Ped.fechaCreacion_pedido);

//                cn.Open();
//                insertar = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE INTERO";
//                if (insertar.Equals("OK"))
//                {
//                    int ID;
//                    foreach(entDetallePedido dt in Detalle)
//                    {
//                        using (var cmd2 = cn.CreateCommand())
//                        {
//                            cmd.Connection = cn;
//                            cmd.Transaction = tr;
//                            cmd.CommandType = CommandType.StoredProcedure;
//                        }
//                    }
//                }

//                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
//                m.Direction = ParameterDirection.ReturnValue;
//                cmd.Parameters.Add(m);
//                cn.Open();
//                cmd.ExecuteNonQuery();
//                idPed = Convert.ToInt16(cmd.Parameters["@retorno"].Value);
//                return idPed;

//            }
//            catch (Exception e)
//            {
//                throw e;
//            }
//            finally { cmd.Connection.Close(); }

//        }
//        public Boolean InsertarDetPedido(entDetallePedido dPed)
//        {
//            SqlCommand cmd = null;
//            Boolean inserta = false;
//            try
//            {
//                SqlConnection cn = Conexion.Instancia.Conectar();
//                cmd = new SqlCommand("spInsertarDetPedido", cn);
//                cmd.CommandType = CommandType.StoredProcedure;

//                cmd.Parameters.AddWithValue("@idPedido", dPed.idPedido);
//                cmd.Parameters.AddWithValue("@idProducto", dPed.idProducto.idProducto);
//                cmd.Parameters.AddWithValue("@cantProducto", dPed.cantProducto);
//                cmd.Parameters.AddWithValue("@precProducto", dPed.precProducto);
//                //cmd.Parameters.AddWithValue("@igv", dPed. );

//                cn.Open();
//                int i = cmd.ExecuteNonQuery();
//                if (i > 0)
//                { inserta = true; }
//            }
//            catch (Exception e)
//            {
//                throw e;
//            }
//            finally { cmd.Connection.Close(); }
//            return inserta;
//        }
//        #endregion metodos
//    }
//}
