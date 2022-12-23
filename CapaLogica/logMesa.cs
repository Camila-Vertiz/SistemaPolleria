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
    public class logMesa
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMesa _instancia = new logMesa();
        //privado para evitar la instanciación directa
        public static logMesa Instancia
        {
            get
            {
                return logMesa._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entMesa> ListaMesas()
        {
            return datMesas.Instancia.ListaMesas();
        }
        public DataSet ListaMesasParaMozo()
        {
            return datMesas.Instancia.ListaMesasParaMozo();
        }
        ///inserta
        public void InsertaMesas(entMesa Pro)
        {
            datMesas.Instancia.InsertaMesas(Pro);
        }
        //busca
        public entMesa BuscaMesas(int idMesas)
        {
            try
            {
                return datMesas.Instancia.BuscaMesas(idMesas);
            }
            catch (Exception e) { throw e; }
        }
        public DataSet BuscarCapacidadMesas(int capacidad)
        {
            try
            {
                return datMesas.Instancia.BuscarCapacidadMesas(capacidad);
            }
            catch (Exception e) { throw e; }
        }
        //edita
        public void EditaMesas(entMesa Pro)
        {
            datMesas.Instancia.EditaMesas(Pro);
        }

        public Boolean EliminaMesas(entMesa Pro)
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
