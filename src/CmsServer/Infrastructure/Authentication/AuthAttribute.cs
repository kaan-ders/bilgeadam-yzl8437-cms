using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CmsServer.Infrastructure.Authentication
{
    public class AuthActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //eğer kullanıcı login olduysa bişey yapma, olmadıysa login sayfasına yönlendir
            var id = context.HttpContext.Session.Get("UserId");
            if(id == null)
                context.Result = new RedirectToActionResult("Login", "Auth", null);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }
    }
}
