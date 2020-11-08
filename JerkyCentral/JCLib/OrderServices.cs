using JCDB;
using JCDB.Models;
using System;
using System.Collections.Generic;

namespace JCLib
{
    public class OrderServices
    {
        private IOrderRepo repo;

        public OrderServices(IOrderRepo repo)
        {
            this.repo = repo;
        }
        public void AddOrder(Order order)
        {
            repo.AddOrder(order);
        }
        public void UpdateOrder(Order order)
        {
            repo.UpdateOrder(order);
        }
        public void DeleteOrder(Order order)
        {
            repo.DeleteOrder(order);
        }
        public Order GetOrderById(int id)
        {
            Order order = repo.GetOrderById(id);
            return order;
        }

        public Order GetOrderByDate(DateTime dt)
        {
            Order order = repo.GetOrderByDate(dt);
            return order;
        }
        
        public List<Order> GetAllOrders()
        {
            List<Order> orders = repo.GetAllOrders();
            return orders;
        }
    }
}