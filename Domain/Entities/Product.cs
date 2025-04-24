namespace Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int InventoryQuantity { get; set; }
        public string ImageSource { get; set; } = string.Empty;
        
        // Navigation property
        public Category? Category { get; set; }
    }
}
