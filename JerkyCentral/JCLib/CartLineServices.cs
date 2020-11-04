using JCDB;
using JCDB.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JCLib
{
    public class CartLineServices
    {
        private ICartLineRepo repo;

        public CartLineServices(ICartLineRepo repo)
        {
            this.repo = repo;
        }
        public void AddCartLine(CartLine cartLine)
        {
            repo.AddCartLineAsync(cartLine);
        }
        public void UpdateCartLine(CartLine cartLine)
        {
            repo.UpdateCartLine(cartLine);
        }
        public void DeleteCartLine(CartLine cartLine)
        {
            repo.DeleteCartLine(cartLine);
        }
        public CartLine GetCartLineById(int id)
        {
            CartLine cartLine = repo.GetCartLineById(id);
            return cartLine;
        }
        public Task<List<CartLine>> GetAllCartLines(int id)
        {
            Task<List<CartLine>> cartLines = repo.GetAllCartLinesByCartIdAsync(id);
            return cartLines;
        }
    }
}