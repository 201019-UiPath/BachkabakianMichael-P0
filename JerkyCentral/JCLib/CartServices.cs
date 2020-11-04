using JCDB;
using JCDB.Models;

namespace JCLib
{
    public class CartServices
    {
        private ICartRepo repo;

        public CartServices(ICartRepo repo)
        {
            this.repo = repo;
        }
        public void AddCart(Cart cart)
        {
            repo.AddCartAsync(cart);
        }
        public void UpdateCart(Cart cart)
        {
            repo.UpdateCart(cart);
        }
        public void DeleteCart(Cart cart)
        {
            repo.DeleteCart(cart);
        }
        public Cart GetCartById(int id)
        {
            Cart cart = repo.GetCartById(id);
            return cart;
        }
        public Cart GetCartByUserId(int UserId) 
        {
             Cart cart = repo.GetCartByUserId(UserId);
             return cart;
        }
    }
}