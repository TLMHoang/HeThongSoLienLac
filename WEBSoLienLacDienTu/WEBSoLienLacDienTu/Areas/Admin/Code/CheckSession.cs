using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBSoLienLacDienTu.Areas.Admin.Code
{
    public class SessionTimeoutAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            if (HttpContext.Current.Session["TaiKhoanNhaTruong"] == null)
            {
                filterContext.Result = new RedirectResult("~/Admin/TaiKhoanTruong/Login");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}