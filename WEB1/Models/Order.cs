namespace WEB1.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FilePath { get; set; } // Поле для зберігання посилання на файл

        // Зв'язок з Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Зв'язок з Product
        public ICollection<Product> Products { get; set; }
    }
}
