namespace Labb1_MVC.Middlewares
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"I ErrorMiddleWare: {context.Request.Path}");
            await _next(context);

            Console.WriteLine($"I ErrorMiddleWare: {context.Response.StatusCode}");

            if(context.Response.StatusCode == 404)
            {
                context.Items["Message"] = "Sidan hittades inte";
                context.Request.Path = "/Home/Error";

                await _next(context);
            }
        }
    }
}
