using System;
using JCDB;
using JCDB.Models;
using JCLib;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JCUI.Menus
{
    class ViewOrderHistoryMenu : IMenu
    {

        private DBRepo repo;
        private User user;
        private OrderServices orderServices;

        public ViewOrderHistoryMenu(DBRepo dbRepo, User user)
        {
            this.repo = dbRepo;
            this.orderServices = new OrderServices(repo);
        }

        public void Start()
        {
            List<Order> orders = orderServices.GetOrdersByUserId(user.UserID);


            var AscList = orders.OrderBy(o => o.OrderDate);
            var DescList = orders.OrderBy(o => o.OrderDate).Reverse();

            foreach (Order order in orders)
            {

            }
            
            Console.WriteLine("");
        }
    }
}
