namespace gms.web.Middlewares.RequestCultureMiddleware;

public static class RequestCultureMiddlewareExtenstion
{
    public static IApplicationBuilder UseRequestCulture(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestCultureMiddleware>();
    }
}
