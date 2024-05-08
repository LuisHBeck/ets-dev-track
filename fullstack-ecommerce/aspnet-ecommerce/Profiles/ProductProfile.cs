using AutoMapper;
using Data.Dtos.Product;
using Dta.Dtos.Product;
using Models;

namespace Profiles;

public class ProductProfile : Profile
{  
    public ProductProfile()
    {
        CreateMap<CreateProductDto, Product>();
        CreateMap<Product, DetailingProductDto>();
    }
}