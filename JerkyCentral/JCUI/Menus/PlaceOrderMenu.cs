using JCDB;
using JCDB.Models;
using JCLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace JCUI.Menus
{
    class PlaceOrderMenu : IMenu
    {
        private User user;
        private Order order;
        private OrderServices orderServices;
        private OrderLineServices orderLineServices;
        private ProductServices productServices;
        private CartLineServices cartLineServices;
        private CartServices cartServices;

        public PlaceOrderMenu(DBRepo repo, User user)
        {
            this.orderServices = new OrderServices(repo);
            this.orderLineServices = new OrderLineServices(repo);
            this.cartLineServices = new CartLineServices(repo);
            this.productServices = new ProductServices(repo);
            this.user = user;

        }
        public void Start()
        {
            //1. make a new order object
            order = new Order()
            {
               UserId = user.UserID 
               
            };

            int sessionCartId = user.cart.CartId; 


            //2. convert cartline items to orderline items
            List<CartLine> sessionItems = cartLineServices.GetAllCartLinesByCart(sessionCartId);


            //3. add orderline items to order
            //4. submit order to repo

        }
    }
}
