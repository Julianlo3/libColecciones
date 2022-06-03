using System;

namespace Servicios.Colecciones.Vectoriales    //CTRL M O
{
    public class clsListaVector<Tipo> : Interfaces.iLista<Tipo> where Tipo : IComparable<Tipo>
    {
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