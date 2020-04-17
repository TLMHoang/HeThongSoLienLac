using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBSoLienLacDienTu.Home
{
    public class SessionTimeoutAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            if (HttpContext.Current.Session["TaiKhoanPhuHuynh"] == null)
            {
                filterContext.Result = new RedirectResult("~/TaiKhoanPhuHuynh/Index");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}