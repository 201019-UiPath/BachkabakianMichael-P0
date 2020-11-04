using System.Collections.Generic;
using System.Threading.Tasks;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for JerkyCentral orders
    /// </summary>
    public interface IOrderRepo
    {
        void AddOrderAsync(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order );
        Order GetOrderById(int id);
        Task<List<Order>> GetAllOrdersAsync();
    }
}