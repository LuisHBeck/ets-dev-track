namespace Infra.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(int id)
        : base("product with id: " + id +" not found")
    {
        
    }

    public ProductNotFoundException(string message)
        : base(message)
    {
        
    }

    public ProductNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
        
    }
}