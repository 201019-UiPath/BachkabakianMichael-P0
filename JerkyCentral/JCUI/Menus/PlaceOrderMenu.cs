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
        private int locationId;

        public PlaceOrderMenu(DBRepo repo, User user, int locationId)
        {
            this.orderServices = new OrderServices(repo);
            this.orderLineServices = new OrderLineServices(repo);
            this.cartServices = new CartServices(repo);
            this.cartLineServices = new CartLineServices(repo);
            this.productServices = new ProductServices(repo);
            this.user = user;
            this.locationId = locationId;

        }
        public void Start()
        {
            //1. make a new order object
            order = new Order();
            
            order.UserId = user.UserID;
            order.LocationId = locationId;
            order.OrderDate = DateTime.Now;

            orderServices.AddOrder(order);

            Order order2 = orderServices.GetOrderByDate(order.OrderDate);


            Cart cart = cartServices.GetCartByUserId(user.UserID);

            
            //2. convert cartline items to orderline items
            List<CartLine> sessionItems = cartLineServices.GetAllCartLinesByCart(cart.CartId);

            foreach (CartLine item in sessionItems)
            {
                OrderLine orderLine = new OrderLine();
                orderLine.OrderId = order2.OrderId;
                orderLine.ProductId = item.ProductId;
                orderLine.Quantity = item.Quantity;
                orderLineServices.AddOrderLine(orderLine);

                cartLineServices.DeleteCartLine(item);
            }

            Console.WriteLine("Your order has been placed!\n");

        }
    }
}
