using Data.Dtos.Purchase.OrderItem;
using Models;

namespace Data.Dtos.Purchase.Order;

public class DetailingPurchaseOrderDto
{
    public int Id { get; set; }
    public int ClientId { get; set; }

    public ICollection<DetailingPurchaseOrderItemDto> Items { get; set; }
}