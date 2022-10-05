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
        //busca
        public entMesas BuscaMesas(int idMesas)
        {
            try
            {
                return datMesas.Instancia.BuscaMesas(idMesas);
            }
            catch (Exception e) { throw e; }
        }
        public entMesas BuscarCapacidadMesas(int capacidad)
        {
            try
            {
                return datMesas.Instancia.BuscarCapacidadMesas(capacidad);
            }
            catch (Exception e) { throw e; }
        }
        //edita
        public void EditaMesas(entMesas Pro)
        {
            datMesas.Instancia.EditaMesas(Pro);
        }

        public Boolean EliminaMesas(entMesas Pro)
        {
            try
            {
                return datMesas.Instancia.EliminaMesas(Pro);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos
    }
}
