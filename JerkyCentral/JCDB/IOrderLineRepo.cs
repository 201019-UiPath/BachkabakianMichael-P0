using System.Collections.Generic;
using System.Threading.Tasks;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for orderlines
    /// </summary>
    public interface IOrderLineRepo
    {
        void AddOrderLineAsync(OrderLine orderline);
        void UpdateOrderLine(OrderLine orderLine);
        void DeleteOrderLine(OrderLine orderLine);
        OrderLine GetOrderLineByOrderLineId(int id);
        Task<List<OrderLine>> GetAllOrderLinesAsync();
    }
}