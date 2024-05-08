using System.Net;

namespace Infra.Exceptions;

public static class ExceptionStatusCode
{
    private static Dictionary<Type, HttpStatusCode> exceptionStatusCode =   
        new Dictionary<Type, HttpStatusCode>
        {
            { typeof(ProductNotFoundException), HttpStatusCode.NotFound }
        };

    public static HttpStatusCode GetExceptionStatusCode(Exception exception)
    {
        bool exceptionFound = exceptionStatusCode.TryGetValue(
            exception.GetType(), 
            out var statusCode
        );
        return exceptionFound ? statusCode : HttpStatusCode.InternalServerError;
    }
}