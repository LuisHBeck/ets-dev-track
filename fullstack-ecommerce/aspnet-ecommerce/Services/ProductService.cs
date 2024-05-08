using AutoMapper;
using Data;
using Data.Dtos.Product;
using Dta.Dtos.Product;
using Models;

namespace Services;

public class ProductService
{   
    private EcommerceContext _context;
    private IMapper _mapper;

    public ProductService(EcommerceContext context, IMapper mapper)
    {
        this._context = context;
        this._mapper = mapper;
    }

    public DetailingProductDto Create(CreateProductDto productDto)
    {
        Product product = _mapper.Map<Product>(productDto);
        _context.Add(product);
        _context.SaveChanges();
        return _mapper.Map<DetailingProductDto>(product);
    }

    public List<PreviewProductDto> GetProductPreview(int skip, int take)
    {
        List<Product> products = _context.Products
            .Skip(skip).Take(take).ToList();
        return _mapper.Map<List<PreviewProductDto>>(products);
    }
}