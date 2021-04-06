using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WEBSoLienLacDienTu.Areas.Admin.Models;
using WEBSoLienLacDienTu.Models;

namespace WEBSoLienLacDienTu.Controllers.api
{
    public class ScanQrAPIController : ApiController
    {
        public string Get()
        {
            return "Welcome To Web API";
        }
        public async Task<ThongTinHS_API> GetStudents(int iD)
        {            
            DataTable dt = await new ThongTinHSDAL().LayDT(iD);
            ThongTinHS hs = new ThongTinHS(dt.Rows[0]);
            DataTable dtLop = await new LopDAL().LayTenLop(hs.IDLop);
            GetNameClassModel l = new GetNameClassModel(dtLop.Rows[0]);
            ThongTinHS_API result = new ThongTinHS_API(hs,l.TenDayDu);
            await new DiemDanh_ScanQRDAL().Them(new DiemDanh_ScanQR(-1,iD,DateTime.Now));
            return result;
        }
        public async void CheckOut()
        {
            List<ThongTinHS> lstHS = await new DiemDanh_ScanQRDAL().LayLstHocSinhVang_QR();
            foreach(var item in lstHS)
            {
                await new DiemDanhDAL().Them(new DiemDanh(-1,item.ID,DateTime.Today.AddDays(1),0));
            }
        }

    }
}
