using CapaDatos;
using CapaEntidad;

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
        public bool BuscarUsuario(string user_usuario, string contrasena_usuario)
        {
            try
            {
                return datUsuario.Instancia.BuscarUsuario(user_usuario, contrasena_usuario);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos

    }
}