using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogica
{
    public class logUsuario
    {
        #region sigleton
        private static readonly logUsuario _instancia = new logUsuario();
        //privado para evitar la instanciación directa
        public static logUsuario Instancia
        {
            get
            {
                return logUsuario._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public entUsuario BuscarUsuario(string user_usuario, string contrasena_usuario)
        {
            try
            {
                return datUsuario.Instancia.BuscarUsuario(user_usuario, contrasena_usuario);
            }
            catch (Exception e) { throw e; }
        }
        public DataSet BuscarMozo(string nombre_usuario, string tipo_usuario)
        {
            return datUsuario.Instancia.BuscarMozo(nombre_usuario, tipo_usuario);
        }
        public string recoverPassword(string correo_usuario)
        {
            try
            {
                return datUsuario.Instancia.recoverPassword(correo_usuario);
            }
            catch (Exception e) { throw e; }
        }

        public DataSet ListarMozos(string tipo_usuario)
        {
            return datUsuario.Instancia.ListarMozos(tipo_usuario);
        }
        #endregion metodos

    }
}