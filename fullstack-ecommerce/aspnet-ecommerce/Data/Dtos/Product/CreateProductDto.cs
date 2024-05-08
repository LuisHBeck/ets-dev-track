using System.ComponentModel.DataAnnotations;

namespace Dta.Dtos.Product;

public class CreateProductDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    [MaxLengthAttribute(300)]
    public string Description { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public int StockQuantity { get; set; }
}