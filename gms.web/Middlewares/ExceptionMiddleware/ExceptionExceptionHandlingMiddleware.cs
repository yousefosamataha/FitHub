using Microsoft.Extensions.Logging;

namespace gms.web.Middlewares.ExceptionMiddleware;
public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        await _next(httpContext);
        try
        {
            await _next(httpContext);
        }
        catch(Exception exception)
        {
            _logger.LogCritical(exception, "Exception Occurred: {Message}", exception.Message);
        }
    }
}
