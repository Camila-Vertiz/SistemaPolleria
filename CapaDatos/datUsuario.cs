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
    public class datUsuario
    {
        #region sigleton
        private static readonly datUsuario _instancia = new datUsuario();
        //privado para evitar la instanciación directa
        public static datUsuario Instancia
        {
            get
            {
                return datUsuario._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public bool BuscarUsuario(string user_usuario, string contrasena_usuario)
        {
            SqlCommand cmd = null;
            entUsuario Use = new entUsuario();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_usuario", user_usuario);
                cmd.Parameters.AddWithValue("@contrasena_usuario", contrasena_usuario);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
        }
        #endregion singleton
    }
}
