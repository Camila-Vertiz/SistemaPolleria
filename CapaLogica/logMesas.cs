using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMesas
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMesas _instancia = new logMesas();
        //privado para evitar la instanciación directa
        public static logMesas Instancia
        {
            get
            {
                return logMesas._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entMesas> ListaMesas()
        {
            return datMesas.Instancia.ListaMesas();
        }
        ///inserta
        public void InsertaMesas(entMesas Pro)
        {
            datMesas.Instancia.InsertaMesas(Pro);
        }

        //edita
        public void EditaMesas(entMesas Pro)
        {
            datMesas.Instancia.EditaMesas(Pro);
        }

        #endregion metodos
    }
}
