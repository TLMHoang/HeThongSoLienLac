using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Areas.Admin.Controllers;

namespace WEBSoLienLacDienTu.Areas.Admin.Code
{
    public class SessionTimeoutAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            if (TaiKhoanTruongController.TK.Loai == 1)
            {
                if (HttpContext.Current.Session["TaiKhoanNhaTruong"] == null)
                {
                    filterContext.Result = new RedirectResult("~/Admin/TaiKhoanTruong/Login");
                    return;
                }
            }
            else
            {
                if (HttpContext.Current.Session["TaiKhoanGiaoVien"] == null)
                {
                    filterContext.Result = new RedirectResult("~/Admin/TaiKhoanTruong/Login");
                    return;
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}