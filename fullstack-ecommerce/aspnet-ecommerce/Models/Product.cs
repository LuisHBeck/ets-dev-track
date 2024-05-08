using System.ComponentModel.DataAnnotations;

namespace Models;

public class Product
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public int StockQuantity { get; set; }
}