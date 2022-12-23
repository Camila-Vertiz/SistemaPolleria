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
    public class datMesas
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMesas _instancia = new datMesas();
        //privado para evitar la instanciación directa
        public static datMesas Instancia
        {
            get
            {
                return datMesas._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entMesa> ListaMesas()
        {
            SqlCommand cmd = null;
            List<entMesa> lista = new List<entMesa>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMesa Mes = new entMesa();
                    Mes.id_mesa = Convert.ToInt32(dr["id_mesa"]);
                    Mes.numero_mesa = dr["numero_mesa"].ToString();
                    Mes.capacidad_mesa = int.Parse(dr["capacidad_mesa"].ToString());
                    Mes.ubicacion_mesa = dr["ubicacion_mesa"].ToString();
                    Mes.estado_mesa = dr["estado_mesa"].ToString();
                    lista.Add(Mes);
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
        public DataSet ListaMesasParaMozo()
        {
            SqlCommand cmd = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaMesaParaMozo", cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(ds, "Mesa");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return ds;
        }

        public entMesa BuscaMesas(int NumeroMesa)
        {
            SqlCommand cmd = null;
            entMesa Mes = new entMesa();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mesa", NumeroMesa);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Mes.id_mesa = Convert.ToInt32(dr["id_mesa"]);
                    Mes.numero_mesa = dr["numero_mesa"].ToString();
                    Mes.capacidad_mesa = int.Parse(dr["capacidad_mesa"].ToString());
                    Mes.ubicacion_mesa = dr["ubicacion_mesa"].ToString();

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Mes;
        }
        public DataSet BuscarCapacidadMesas(int capacidad_mesa)
        {
            SqlCommand cmd = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCapacidadMesa", cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@capacidad_mesa", capacidad_mesa));
                da.SelectCommand = cmd;
                da.Fill(ds, "Mesa");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return ds;
        }
        public Boolean InsertaMesas(entMesa Mes)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_mesa", Mes.numero_mesa);
                cmd.Parameters.AddWithValue("@capacidad_mesa", Mes.capacidad_mesa);
                cmd.Parameters.AddWithValue("@ubicacion_mesa", Mes.ubicacion_mesa);
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



        public Boolean EditaMesas(entMesa Mes)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mesa", Mes.id_mesa);
                cmd.Parameters.AddWithValue("@numero_mesa", Mes.numero_mesa);
                cmd.Parameters.AddWithValue("@capacidad_mesa", Mes.capacidad_mesa);
                cmd.Parameters.AddWithValue("@ubicacion_mesa", Mes.ubicacion_mesa);
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


        public Boolean EliminaMesas(entMesa Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mesa", Pro.id_mesa);

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
