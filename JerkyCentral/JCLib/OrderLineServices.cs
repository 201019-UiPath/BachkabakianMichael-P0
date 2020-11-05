using JCDB;
using JCDB.Models;
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
            repo.AddOrderLine(orderLine);
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
        public List<OrderLine> GetAllOrderLines()
        {
            List<OrderLine> orderLines = repo.GetAllOrderLines();
            return orderLines;
        }
    }
}