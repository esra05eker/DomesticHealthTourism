using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHT.App.Mvc.Attributes
{
    // Custom Yetliendirme Atribute oluşturuyoruz
    // Bu attribute controllerdaki action'ları sadece giriş yapmış kullanıcılar görebilir şeklinde kısıtlandırabileceğiz
    public class SessionAuthorizeAttribute : AuthorizeAttribute
    {
        // ana sınıfdan override et
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.Session["user"] != null; // Session["user"] null değilse giriş yapmıştır
        }

        // ana sınıfdan override et
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("/Account/Login"); // eğer giriş yapmamış ise yönlendirilecek sayfa
        }
    }
}