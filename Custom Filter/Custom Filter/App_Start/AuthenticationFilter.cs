using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Filters;

namespace Custom_Filter
{
    public class AuthenticationFilter:FilterAttribute,IAuthenticationFilter
    {

        public void OnAuthentication(AuthenticationContext context)
        {
            string user = (string) context.HttpContext.Session["user"];
            string actionName = context.RouteData.Values["action"].ToString();
            string controllerName = context.RouteData.Values["controller"].ToString();
            if (controllerName == "Home" && actionName == "Index") {  
            }
            else if (controllerName == "Home" && actionName == "Login")
            {
            }
            else if(user != "admin")
            {
                context.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext context)
        {
            if (context.Result == null || context.Result is HttpUnauthorizedResult)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary {
                    {"controller", "Home"},
                    {"action", "Index"},
                    {"returnUrl", context.HttpContext.Request.RawUrl}
                });
            }
        }

    }
}