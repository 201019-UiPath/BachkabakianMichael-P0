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
        public List<CartLine> GetAllCartLinesByCart(int cartId)
        {
            List<CartLine> cartLines = repo.GetAllCartLinesByCartId(cartId);
            return cartLines;
        }
    }
}