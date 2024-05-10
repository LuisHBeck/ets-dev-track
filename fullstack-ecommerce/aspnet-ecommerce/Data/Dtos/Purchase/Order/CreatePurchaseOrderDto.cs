using System.ComponentModel.DataAnnotations;
using Data.Dtos.Purchase.OrderItem;

namespace Data.Dtos.Purchase.Order;

public class CreatePurchaseOrderDto
{
    [Required]
    public int ClientId { get; set; }

    public List<CreatePurchaseOrderItemDto> Items { get; set; }
}