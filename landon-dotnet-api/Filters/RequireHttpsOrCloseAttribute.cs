using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace landon_dotnet_api.Filters
{
    public class RequireHttpsOrCloseAttribute : RequireHttpsAttribute
    {
        // Handle non https request context
        protected override void HandleNonHttpsRequest(AuthorizationFilterContext filterContext)
        {
            filterContext.Result = new StatusCodeResult(400);
        }
    }
}