using Newtonsoft.Json;
using System.Net;



namespace RmsWebApi
{
    public class GlobalErrorMiddleware
    {
        public RequestDelegate request;
        public GlobalErrorMiddleware(RequestDelegate requestDelegate)
        {
            this.request = requestDelegate;
        }



        public async Task Invoke(HttpContext context, ILogger<GlobalErrorMiddleware> logger)
        {
            try
            {
                await request.Invoke(context);



            }
            catch (Exception ex)
            {
                await HandleException(context, ex, logger);
            }



        }



        public static Task HandleException(HttpContext context, Exception ex, ILogger<GlobalErrorMiddleware> logger)
        {
            logger.LogError(ex.ToString());



            var errorMessage = JsonConvert.SerializeObject(new { Message = ex.Message, Code = "RMS API ERROR" });




            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;



            return context.Response.WriteAsync(errorMessage);
        }
    }
}