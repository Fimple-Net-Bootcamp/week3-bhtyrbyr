using System.Diagnostics;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;

namespace WebAPI.Middlewares
{
    public class CustomExceptionMiddlware
    {
        private readonly RequestDelegate _next;
        private readonly ILogService _loggerService;
        public CustomExceptionMiddlware(RequestDelegate next, [FromServices] ILogService loggerService)
        {
            _next = next;
            _loggerService = loggerService;
        }

        public async Task Invoke(HttpContext context)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                _loggerService.Write(ConsoleColor.Magenta, "[Request]", 
                                     ConsoleColor.DarkYellow, "  HTTP ", 
                                     ConsoleColor.Cyan, context.Request.Method, 
                                     ConsoleColor.White, " - ", 
                                     ConsoleColor.Green, context.Request.Path);
                await _next(context);
                watch.Stop();
                _loggerService.Write(ConsoleColor.Magenta, "[Response]", 
                                     ConsoleColor.DarkYellow, " HTTP ",
                                     ConsoleColor.Cyan, context.Request.Method,
                                     ConsoleColor.White, " - ",
                                     ConsoleColor.Green, context.Request.Path,
                                     ConsoleColor.White, " responded ",
                                     (context.Response.StatusCode >= 200 && context.Response.StatusCode <=299) ? ConsoleColor.Green : ConsoleColor.Red, context.Response.StatusCode,
                                     ConsoleColor.White, " in ",
                                     ConsoleColor.Blue, watch.Elapsed.Milliseconds, ConsoleColor.White, " ms ",
                                     ConsoleColor.Yellow, context.Items.Count);
            }catch(System.Exception ex)
            {
                watch.Stop();
                await HandleException(context, ex, watch);
            }
        }

        private Task HandleException(HttpContext context, Exception ex, Stopwatch watch)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            _loggerService.Write(
                    ConsoleColor.DarkRed, "[Error]",
                    ConsoleColor.DarkYellow,"    HTTP ",
                    ConsoleColor.Cyan, context.Request.Method,
                    ConsoleColor.White, " - ",
                    ConsoleColor.Green, context.Request.Path,
                    ConsoleColor.White, " - ",
                    ConsoleColor.Red, context.Response.StatusCode,
                    ConsoleColor.White, " Error Message ",
                    ConsoleColor.Yellow, ex.Message,
                    ConsoleColor.White, " in ",
                    ConsoleColor.Blue, watch.Elapsed.Milliseconds, ConsoleColor.White, " ms"
                );
            //var result = JsonConvert.SerializeObject(new {error = ex.Message}, Formatting.None);
            var result = JsonSerializer.Serialize(new {error = ex.Message});
            return context.Response.WriteAsync(result);
        }
    }
    public static class CustomExceptionMiddlwareExtension
    {
        public static IApplicationBuilder UseCustomExceptionMiddle(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddlware>();
        }
    }
}