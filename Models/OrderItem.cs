namespace OrderApi.Models
{
    public class OrderItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CustomerId { get; set; }
    }
}
