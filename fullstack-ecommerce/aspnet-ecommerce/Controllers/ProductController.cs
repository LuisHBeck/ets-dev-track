using Data.Dtos.Products;
using Dta.Dtos.Products;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers;

[ApiController]
[Route("products")]
public class ProductController : ControllerBase
{
    private ProductService _productService;

    public ProductController(ProductService productService)
    {
        this._productService = productService;
    }

    [HttpPost]
    public IActionResult Create(CreateProductDto productDto)
    {
        DetailingProductDto product = _productService.Create(productDto);
        return CreatedAtAction(nameof(GetProductById), new {id = product.Id}, product);
    }

    [HttpGet("preview")]
    public IEnumerable<PreviewProductDto> GetProductPreview(
        [FromQuery] int skip=0, [FromQuery] int take=10
    )
    {
        List<PreviewProductDto> productPreviwList = _productService
            .GetProductPreview(skip, take);
        return productPreviwList;
    }

    [HttpGet("{id}")]
    public IActionResult GetProductById(int id)
    {
        PreviewProductDto? product = _productService.GetProductById(id);
        return Ok(product);
    }
}