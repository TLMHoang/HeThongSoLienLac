using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Code;
using WEBSoLienLacDienTu.Models;
using DTO;
using Newtonsoft.Json.Linq;

namespace WEBSoLienLacDienTu.Controllers
{
   
    public class XemHocPhiController : Controller
    {
        int idHocPhi;
        // GET: XemHocPhi
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public async Task<ActionResult> Index()
        {
          
            return View();
        }
        
        public async Task<ActionResult> DongHocPhi()
        {
            var hocPhiNo = await LoadHocPhiNo();
            var hocPhiThang = await LoadTongHocPhi();
            ViewBag.TongHocPhiThangVaNo = int.Parse(hocPhiThang != null ? hocPhiThang : "0") + int.Parse(hocPhiNo != null ? hocPhiNo : "0");
            ViewBag.TongHocPhi =hocPhiThang;
            if (hocPhiNo != null)
            {
                ViewBag.LstHocPhiNo = hocPhiNo;
            }
            else
            {
                ViewBag.LstHocPhiNo = null;
            }
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> DongHocPhi(FormCollection f)
        {

            var hocPhiNo = await LoadHocPhiNo();
            var hocPhiThang = await LoadTongHocPhi();
            var tongHocPhi = int.Parse(hocPhiThang != null ? hocPhiThang : "0") + int.Parse(hocPhiNo != null ? hocPhiNo : "0");
            ViewBag.TongHocPhiThangVaNo = tongHocPhi;
            ViewBag.TongHocPhi = hocPhiThang;
            if (hocPhiNo != null)
            {
                ViewBag.LstHocPhiNo = hocPhiNo;
            }
            else
            {
                ViewBag.LstHocPhiNo = null;
            }
            
            DataTable dt = await new HoaDonHocPhiDAL().ThemHoaDon(idHocPhi, TaiKhoanPhuHuynhController.ttHS.ID,DateTime.Now,0);
            return Redirect(ThanhToanMoMo(dt.Rows[0]["ID"].ToString(),tongHocPhi.ToString()));
        }
        public ActionResult ThanhToanThanhCong_MoMo()
        {
            return View();
        }
        public async Task<ActionResult> LoadHocPhi(int Thang)
        {

            List<HocPhiModels> lst = new List<HocPhiModels>();
            foreach (DataRow dr in (await new ThongTinHocPhiDAL().LayDT_ByID_Thang(TaiKhoanPhuHuynhController.ttHS.ID, Thang)).Rows)
            {
                lst.Add(new HocPhiModels(dr));
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        public async Task<string> LoadHocPhiNo()
        {
            DataTable lstHocPhiNo = await new ThongTinHocPhiDAL().LoadHocPhiNo(TaiKhoanPhuHuynhController.ttHS.ID);
            if (lstHocPhiNo.Rows.Count > 0)
            {
               
                return lstHocPhiNo.Rows[0]["Tien"].ToString();
            }
            else
            {
                return null;
            }
            
        }
        public async Task<string> LoadTongHocPhi()
        {
            DataTable dt = await new ThongTinHocPhiDAL().LoadThongTinHocPhi_IDHS(TaiKhoanPhuHuynhController.ttHS.ID);
            DataTable TongHocPhi = await new ThongTinHocPhiDAL().LoadTongHocPhi(DateTime.Now.Month,int.Parse(dt.Rows[0]["IDLoaiHocSinh"].ToString()),int.Parse(dt.Rows[0]["IDKhoi"].ToString()));
            if (TongHocPhi.Rows.Count > 0)
            {
                idHocPhi = int.Parse(TongHocPhi.Rows[0]["ID"].ToString());
                return TongHocPhi.Rows[0]["Tong"].ToString();
                
            }
            else
            {
                return null;
            }
            
        }
        protected string ThanhToanMoMo(string maDonHang, string tongCong)
        {
            string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
            string partnerCode = "MOMOU7HO20201012";
            string accessKey = "m7FdDFcxJQucpLhi";
            string serectkey = "LWdLzT6SZ1oPUJ0kak2kzBQOWgLkR3sS";
            string orderInfo = "DongHocPhi_";
            string returnUrl = "https://solienlac-us.tk/XemHocPhi/ThanhToanThanhCong_MoMo";
            string notifyurl = "https://solienlac-us.tk/";

            string amount = tongCong;
            string orderid = maDonHang;
            string requestId = maDonHang;
            string extraData = "";

            string rawHash = "partnerCode=" +
                             partnerCode + "&accessKey=" +
                             accessKey + "&requestId=" +
                             requestId + "&amount=" +
                             amount + "&orderId=" +
                             orderid + "&orderInfo=" +
                             orderInfo + "&returnUrl=" +
                             returnUrl + "&notifyUrl=" +
                             notifyurl + "&extraData=" +
                             extraData;

            log.Debug("rawHash = " + rawHash);
            MoMoSecurity crypto = new MoMoSecurity();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);
            log.Debug("Signature = " + signature);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "accessKey", accessKey },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderid },
                { "orderInfo", orderInfo },
                { "returnUrl", returnUrl },
                { "notifyUrl", notifyurl },
                { "extraData", extraData },
                { "requestType", "captureMoMoWallet" },
                { "signature", signature }

            };
            log.Debug("Json request to MoMo: " + message.ToString());
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

            JObject jmessage = JObject.Parse(responseFromMomo);
            log.Debug("Return from MoMo: " + jmessage.ToString());

            return jmessage.GetValue("payUrl").ToString();

        }
    }
}