using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsPilaVector<Tipo> : iPila<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private int atrLongitud;
        private Tipo[] atrItems = new Tipo[];
        private int atrCapacidad;
        private bool atrFlexible = true;
        private int atrFactorCrecimiento = 1000;
        #endregion
        #region Constructores
        public clsPilaVector()
        {
            this.atrCapacidad = 0;
            this.atrItems = new Tipo[darCapacidad()];
            this.atrLongitud = 0;
            this.atrFlexible = true;
            this.atrFactorCrecimiento = 1000;
        }

        public clsPilaVector(int prmCapacidad)
        {
            this.atrCapacidad = prmCapacidad;
            this.atrItems = new Tipo[prmCapacidad];
            this.atrLongitud = 0;
            this.atrFlexible = true;
            this.atrFactorCrecimiento = 1000;
        }

        public clsPilaVector(int prmCapacidad, bool prmFlexible)
        {
            this.atrCapacidad = prmCapacidad;
            this.atrItems = new Tipo[prmCapacidad];
            this.atrLongitud = 0;
            this.atrFlexible = prmFlexible;
            this.atrFactorCrecimiento = 1000;
        }
        #endregion
        #region Operaciones
        #region Accesores
        public int darLongitud()
        {
            return atrLongitud;
        }
        public Tipo[] darItems()
        {
            return atrItems;
        }
        public int darCapacidad()
        {
            return atrCapacidad;
        }
        public bool esFlexible()
        {
            return atrFlexible;
        }
        public int darFactorCrecimiento()
        {
            return atrFactorCrecimiento;
        }
        #endregion
        #region CRUD
        public bool puedeApilar()
        {
            if (atrLongitud == atrCapacidad) return false;
            else return true;
        }
        public bool aumentarCapacidad()
        {
            if (esFlexible())
            {

                Tipo[] varItemsTemp = new Tipo[darLongitud() + atrFactorCrecimiento];
                atrItems = varItemsTemp;
                atrCapacidad = atrCapacidad + atrFactorCrecimiento;
                return true;

            }
            else return false; //borrar if
        }
        public bool apilar(Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        public bool desapilar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool reversar()
        {
            throw new NotImplementedException();
        }

        public bool ponerItems(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        #endregion 

        #endregion
    }
}
