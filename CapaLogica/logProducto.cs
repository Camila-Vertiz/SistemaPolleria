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

        ///inserta
        public void InsertaProducto(entProducto Pro)
        {
            datProducto.Instancia.InsertaProducto(Pro);
        }

        //edita
        public void EditaProducto(entProducto Pro)
        {
            datProducto.Instancia.EditaProducto(Pro);
        }

        public DataSet BuscaProducto(string n)
        {
            return datProducto.Instancia.BuscaProducto(n);
        }
        public DataSet BuscaNombreProducto(string n)
        {
            return datProducto.Instancia.BuscaNombreProducto(n);
        }
        #endregion metodos

    }
}
