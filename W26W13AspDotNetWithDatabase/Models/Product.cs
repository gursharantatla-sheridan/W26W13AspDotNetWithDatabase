namespace W26W13AspDotNetWithDatabase.Models
{
    public class Product
    {
        // scalar properties
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public int? CategoryId { get; set; }

        // navigation property
        public Category? Category { get; set; }
    }
}
