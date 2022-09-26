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
                    Use.id_usuario = Convert.ToInt32((dr["id_usuario"]));
                    Use.nombre_usuario = dr["nombre_usuario"].ToString();
                    Use.correo_usuario = dr["correo_usuario"].ToString();
                    Use.user_usuario = dr["user_usuario"].ToString();
                    Use.contrasena_usuario = dr["contrasena_usuario"].ToString();
                    Use.tipo_usuario = dr["tipo_usuario"].ToString();
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

        public string recoverPassword(string correo_usuario)
        {
            SqlCommand cmd = null;
            entUsuario Use = new entUsuario();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRecuperarContra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo_usuario", correo_usuario);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Use.nombre_usuario = dr["nombre_usuario"].ToString();
                    Use.correo_usuario = dr["correo_usuario"].ToString();
                    Use.user_usuario = dr["user_usuario"].ToString();
                    Use.contrasena_usuario = dr["contrasena_usuario"].ToString();

                    var mailService = new MailServices.SystemSupportMail();
                    mailService.sendMail(
                        subject: "SYSTEM: Password recovery request",
                        body: "Hola, " + Use.nombre_usuario + ".\nSolicitaste recuperar tu contraseña. \n" +
                        "Tu contraseña es: " + Use.contrasena_usuario + "\nSin embargo, le recomendamos cambiar su contraseña cuando entre al sistema.",
                        recipientMail: new List<string> { Use.correo_usuario }
                        );
                    return "Hola, " + Use.nombre_usuario + ".\nSolicitaste recuperar tu contraseña. \n" +
                        "Por favor revisa tu correo: " + Use.correo_usuario +
                        "\nSin embargo, le recomendamos cambiar su contraseña cuando entre al sistema.";
                }
                //else
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
                return "Lo sentimos, no existe una cuenta con ese correo o nombre de usuario.";
        }
    }
}
