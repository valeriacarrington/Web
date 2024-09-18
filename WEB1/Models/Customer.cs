namespace WEB1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Зв'язок з Order
        public ICollection<Order> Orders { get; set; }
    }

}
