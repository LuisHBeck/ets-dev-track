namespace Infra.Exceptions.Middlewares;

public class ExceptionMiddleware
{
    private readonly RequestDelegate next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        this.next=next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch(Exception ex)
        {
            httpContext.Response.StatusCode = (int)ExceptionStatusCode.GetExceptionStatusCode(ex);
            await httpContext.Response.WriteAsync(ex.Message);
        }
    }
}

public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionMiddleware(
            this IApplicationBuilder builder
        )
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }