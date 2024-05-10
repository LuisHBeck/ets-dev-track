namespace Data.Dtos.Products;

public class DetailingProductDto
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }
}