using landon_dotnet_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace landon_dotnet_api.Filters
{
    public class JsonExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var error = new ApiError();

            error.Message = context.Exception.Message;
            error.Detail = context.Exception.StackTrace;

            context.Result = new ObjectResult(error)
            {
                StatusCode = 500
            };
        }
    }
}