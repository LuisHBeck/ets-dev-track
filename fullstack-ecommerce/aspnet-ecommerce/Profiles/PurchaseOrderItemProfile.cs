using AutoMapper;
using Data.Dtos.Purchase.OrderItem;
using Models;

namespace Profiles;

public class PurchaseOrderItemProfile : Profile
{
    public PurchaseOrderItemProfile()
    {
        CreateMap<CreatePurchaseOrderItemDto, PurchaseOrderItem>();
        CreateMap<PurchaseOrderItem, DetailingPurchaseOrderItemDto>()
            .ForMember(purchaseItemDto => purchaseItemDto.ProductId,
                opt => opt.MapFrom(purchaseItem => purchaseItem.Product.Id)
            );
    }
}