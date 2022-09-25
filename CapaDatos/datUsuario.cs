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
        public entUsuario BuscarUsuario(string user_usuario, string contrasena_usuario)
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
                while (dr.Read())
                {
                    Use.user_usuario = dr["user_usuario"].ToString();
                    Use.contrasena_usuario = dr["contrasena_usuario"].ToString();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Use;
        }
        #endregion singleton
    }
}
