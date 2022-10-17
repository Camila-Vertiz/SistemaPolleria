﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPedido _instancia = new logPedido();
        //privado para evitar la instanciación directa
        public static logPedido Instancia
        {
            get
            {
                return logPedido._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public int ObtenerCorrelativo()
        {
            return datPedido.Instancia.ObtenerCorrelativo();
        }

        ///listado

        //public List<entPedido> ListaPedido()
        //{
        //    return datPedido.Instancia.ListaPedido();
        //}
        ///inserta
        public bool InsertarPedido(entPedido Pro, DataTable EDetalle_Pedido, out string Mensaje)
        {
            return datPedido.Instancia.InsertarPedido(Pro, EDetalle_Pedido, out Mensaje);
        }

        public bool RestarStock(int codigo_producto, int cantidad)
        {
            return datPedido.Instancia.RestarStock(codigo_producto, cantidad);
        }
        public bool SumarStock(int codigo_producto, int cantidad)
        {
            return datPedido.Instancia.SumarStock(codigo_producto, cantidad);
        }

        #endregion metodos
    }
}
