using System.Web.Mvc;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu
{
    public class HeThongTaiLieuAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HeThongTaiLieu";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HeThongTaiLieu_default",
                "HeThongTaiLieu/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}