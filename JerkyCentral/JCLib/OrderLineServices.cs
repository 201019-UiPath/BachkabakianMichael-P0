using JCDB;
using JCDB.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JCLib
{
    public class OrderLineServices
    {
        private IOrderLineRepo repo;

        public OrderLineServices(IOrderLineRepo repo)
        {
            this.repo = repo;
        }
        public void AddOrderLine(OrderLine orderLine)
        {
            repo.AddOrderLineAsync(orderLine);
        }
        public void UpdateOrderLine(OrderLine orderLine)
        {
            repo.UpdateOrderLine(orderLine);
        }
        public void DeleteOrderLine(OrderLine orderLine)
        {
            repo.DeleteOrderLine(orderLine);
        }
        public OrderLine GetOrderLineById(int id)
        {
            OrderLine orderLine = repo.GetOrderLineByOrderLineId(id);
            return orderLine;
        }
        public Task<List<OrderLine>> GetAllOrderLines()
        {
            Task<List<OrderLine>> orderLines = repo.GetAllOrderLinesAsync();
            return orderLines;
        }
    }
}