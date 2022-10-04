using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProducto _instancia = new logProducto();
        //privado para evitar la instanciación directa
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public DataSet ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }

        /////inserta
        //public void InsertaProducto(entProducto Cli)
        //{
        //    datProducto.Instancia.InsertarProducto(Cli);
        //}

        //edita
        //public void EditaProducto(entProducto Cli)
        //{
        //    datProducto.Instancia.EditarProducto(Cli);
        //}
        //public void DeshabilitarProducto(entProducto Cli)
        //{
        //    datProducto.Instancia.DeshabilitarProducto(Cli);
        //}
        public DataSet BuscaProducto(string n)
        {
            return datProducto.Instancia.BuscaProducto(n);
        }
        #endregion metodos

    }
}
