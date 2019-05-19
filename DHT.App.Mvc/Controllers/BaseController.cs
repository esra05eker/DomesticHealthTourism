using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DHT.App.Mvc.Controllers
{
    public abstract class BaseController : Controller
    {
        // Giriş yapmış hasta bilgisi
        protected Patient sessionUser;

        // giriş yapılmış mı
        protected bool isLoggedIn = false;


        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            sessionUser = (Patient)Session["user"];
            isLoggedIn = sessionUser != null;

            base.OnActionExecuting(filterContext);
        }

        protected void SetAlert(string type, string message)
        {
            TempData["AlertMessage"] = message;
            TempData["AlertType"] = type;

            switch (type)
            {
                case "success":
                    TempData["AlertIcon"] = "check";
                    break;
                case "danger":
                    TempData["AlertIcon"] = "times";
                    break;
                case "warning":
                    TempData["AlertIcon"] = "exclamation";
                    break;
                case "info":
                    TempData["AlertIcon"] = "info";
                    break;
                default:
                    break;
            }
        }

    }
}