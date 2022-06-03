
using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsListaEnlazada<Tipo> : iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativos

        private clsNodoEnlazado<Tipo> atrPrimero;
        private clsNodoEnlazado<Tipo> atrUltimo;
        #endregion

        #endregion
        #region Operaciones
        #region CRUD
        public bool agregar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool insertar(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool remover(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool modificar(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region QUERY

        public bool encontrar(Tipo prmItem, ref int prmIndice)
        {
            throw new NotImplementedException();
        }
        #endregion 
        #endregion

    }
}