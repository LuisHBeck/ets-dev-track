using AutoMapper;
using Data;
using Data.Dtos.Purchase.Order;
using Models;

namespace Services;

public class PurchaseService
{
    private EcommerceContext _context;
    private IMapper _mapper;

    public PurchaseService(EcommerceContext context, IMapper mapper)
    {
        this._context = context;
        this._mapper = mapper;
    }

    public DetailingPurchaseOrderDto Create(CreatePurchaseOrderDto purchaseOrderDto)
    {
        PurchaseOrder purchaseOrder = _mapper.Map<PurchaseOrder>(purchaseOrderDto);
        _context.PurchaseOrders.Add(purchaseOrder);
        _context.SaveChanges();
        return _mapper.Map<DetailingPurchaseOrderDto>(purchaseOrder);
    }

    public List<DetailingPurchaseOrderDto> GetPurchases(int skip, int take)
    {
        return _mapper.Map<List<DetailingPurchaseOrderDto>>(
            _context.PurchaseOrders
                .Skip(skip).Take(take).ToList()
        );
    }
}