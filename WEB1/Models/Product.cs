namespace WEB1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Зв'язок з Order
        public ICollection<Order> Orders { get; set; }
    }

}
