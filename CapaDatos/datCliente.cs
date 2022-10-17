using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entCliente> ListaCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.numeroDocumento_cliente = dr["numeroDocumento_cliente"].ToString();
                    Cli.tipoDocumento_cliente = dr["tipoDocumento_cliente"].ToString();
                    Cli.correo_cliente = dr["correo_cliente"].ToString();
                    Cli.telefono_cliente = dr["telefono_cliente"].ToString();
                    lista.Add(Cli);
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


        public entCliente BuscaCliente(string numeroDocumento_cliente)
        {
            SqlCommand cmd = null;
            entCliente Cli = new entCliente();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroDocumento_cliente", numeroDocumento_cliente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cli.numeroDocumento_cliente = dr["numeroDocumento_cliente"].ToString();
                    Cli.tipoDocumento_cliente = dr["tipoDocumento_cliente"].ToString();
                    Cli.correo_cliente = dr["correo_cliente"].ToString();
                    Cli.telefono_cliente = dr["telefono_cliente"].ToString();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Cli;
        }
        public Boolean InsertaCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroDocumento_cliente", Cli.numeroDocumento_cliente);
                cmd.Parameters.AddWithValue("@tipoDocumento_cliente", Cli.tipoDocumento_cliente);
                cmd.Parameters.AddWithValue("@nombre_cliente", Cli.nombre_cliente);
                cmd.Parameters.AddWithValue("@telefono_cliente", Cli.telefono_cliente);
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



        public Boolean EditaCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroDocumento_cliente", Cli.numeroDocumento_cliente);
                cmd.Parameters.AddWithValue("@tipoDocumento_cliente", Cli.tipoDocumento_cliente);
                cmd.Parameters.AddWithValue("@nombre_cliente", Cli.nombre_cliente);
                cmd.Parameters.AddWithValue("@telefono_cliente", Cli.telefono_cliente);
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

        public Boolean EliminaCliente(entCliente Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroDocumento_cliente", Pro.numeroDocumento_cliente);

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
    }


    #endregion metodos
}
