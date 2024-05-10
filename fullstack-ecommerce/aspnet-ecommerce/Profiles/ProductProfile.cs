using AutoMapper;
using Data.Dtos.Products;
using Dta.Dtos.Products;
using Models;

namespace Profiles;

public class ProductProfile : Profile
{  
    public ProductProfile()
    {
        CreateMap<CreateProductDto, Product>();
        CreateMap<Product, DetailingProductDto>();
        CreateMap<Product, PreviewProductDto>();
    }
}