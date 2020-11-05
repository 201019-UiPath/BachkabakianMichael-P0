using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data Access Interface for CartLines
    /// </summary>
    public interface ICartLineRepo
    {
        void AddCartLine(CartLine cartLine);
        void UpdateCartLine(CartLine cartLine);
        void DeleteCartLine(CartLine cartLine);
        CartLine GetCartLineById(int id);
        List<CartLine> GetAllCartLinesByCartId(int id);
         
    }
}