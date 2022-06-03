using System;

namespace Servicios.Colecciones.Interfaces
{
   public interface iLista<Tipo> where Tipo : IComparable<Tipo>
{
    #region CRUD
    bool agregar(Tipo prmItem);

    bool insertar(int prmIndice, Tipo prmItem);

    bool remover(int prmIndice, ref Tipo prmItem);

    bool modificar(int prmIndice, Tipo prmItem);
    #endregion

    #region QUERY
    bool encontrar(Tipo prmItem, ref int prmIndice); 
    #endregion

}
}