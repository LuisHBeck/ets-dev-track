using System.ComponentModel.DataAnnotations;

namespace Dta.Dtos.Product;

public class CreateProductDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public int StockQuantity { get; set; }
}