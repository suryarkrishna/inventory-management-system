namespace server.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Sku { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int? CategoryId { get; set; }
}
