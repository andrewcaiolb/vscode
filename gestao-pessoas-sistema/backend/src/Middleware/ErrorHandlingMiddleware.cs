public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        var result = JsonSerializer.Serialize(new { error = ex.Message });
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        return context.Response.WriteAsync(result);
    }
}