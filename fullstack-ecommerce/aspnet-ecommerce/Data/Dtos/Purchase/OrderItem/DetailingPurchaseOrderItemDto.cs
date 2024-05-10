using Models;

namespace Data.Dtos.Purchase.OrderItem;

public class DetailingPurchaseOrderItemDto
{
    // public int Id { get; set; }
    public int ProductId { get; set; }
    public int ProductQuantity { get; set; }
}