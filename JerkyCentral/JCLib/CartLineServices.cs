using JCDB;
using JCDB.Models;
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
            repo.AddCartLine(cartLine);
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
        public List<CartLine> GetAllCartLines(int id)
        {
            List<CartLine> cartLines = repo.GetAllCartLinesByCartId(id);
            return cartLines;
        }
    }
}