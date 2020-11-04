using JCDB;
using JCDB.Models;
using System.Threading.Tasks;
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
            repo.AddOrderAsync(order);
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
        public Task<List<Order>> GetAllOrders()
        {
            Task<List<Order>> orders = repo.GetAllOrdersAsync();
            return orders;
        }
    }
}