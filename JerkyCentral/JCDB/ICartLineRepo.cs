using System.Collections.Generic;
using System.Threading.Tasks;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data Access Interface for CartLines
    /// </summary>
    public interface ICartLineRepo
    {
        void AddCartLineAsync(CartLine cartLine);
        void UpdateCartLine(CartLine cartLine);
        void DeleteCartLine(CartLine cartLine);
        CartLine GetCartLineById(int id);
        Task<List<CartLine>> GetAllCartLinesByCartIdAsync(int id);
         
    }
}