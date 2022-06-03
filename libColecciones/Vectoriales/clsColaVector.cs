using System;
using Servicios.Colecciones.Interfaces;


namespace Servicios.Colecciones.Vectoriales
{
    public class clsColaVector<Tipo> : iCola<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Operaciones
        #region CRUD
        public bool encolar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool desencolar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion 
        #endregion
    }
}
