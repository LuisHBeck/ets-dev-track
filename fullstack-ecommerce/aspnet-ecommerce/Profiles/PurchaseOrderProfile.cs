using AutoMapper;
using Data.Dtos.Purchase.Order;
using Models;

namespace Profiles;

public class PurchaseOrderProfile : Profile
{
    public PurchaseOrderProfile()
    {
        CreateMap<CreatePurchaseOrderDto, PurchaseOrder>();
        CreateMap<PurchaseOrder, DetailingPurchaseOrderDto>()
            .ForMember(purchaseDto => purchaseDto.Items,
                opt => opt.MapFrom(purchase => purchase.Items)
            );
    }
}