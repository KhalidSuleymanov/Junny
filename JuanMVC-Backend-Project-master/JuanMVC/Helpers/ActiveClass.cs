﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace JuanMVC.Helpers
{
    public static class ActiveClass
    {
        public static string ActiveC(this IHtmlHelper htmlHelper, string controller, string action, string className = "active")
        {
            var currentController = htmlHelper.ViewContext.RouteData.Values["controller"] as string;
            var currentAction = htmlHelper.ViewContext.RouteData.Values["action"] as string;

            return (controller == currentController && action == currentAction) ? className : null;
        }

    }
}
