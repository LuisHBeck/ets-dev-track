using System.ComponentModel.DataAnnotations;

namespace Data.Dtos.Purchase;

public class CreatePurchaseOrderItemDto
{
    [Required]
    public int ProductId { get; set; }

    [Required]
    public int ProductQuantity { get; set; }
}