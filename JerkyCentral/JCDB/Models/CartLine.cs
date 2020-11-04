namespace JCDB.Models
{
    public class CartLine
    {
        public int CartLineId { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }
        public int Quantity { get; set; }
    }
}