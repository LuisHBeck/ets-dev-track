using Data.Dtos.Purchase.Order;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers;

[ApiController]
[Route("purchases")]
public class PurchaseController : ControllerBase
{
    private PurchaseService _purchaseService;

    public PurchaseController(PurchaseService purchaseService)
    {
        this._purchaseService = purchaseService;
    }

    [HttpPost]
    public IActionResult Create(CreatePurchaseOrderDto purchaseOrderDto) 
    {
        DetailingPurchaseOrderDto detailingPurchaseDto = _purchaseService.Create(purchaseOrderDto);
        return Ok(detailingPurchaseDto);
    }

    [HttpGet]
    public IEnumerable<DetailingPurchaseOrderDto> GetPurchases(
        [FromQuery] int skip = 0, [FromQuery] int take = 10
    ) 
    {
        return _purchaseService.GetPurchases(skip, take);
    }
}