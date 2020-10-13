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
        // GET: XemHocPhi
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public async Task<ActionResult> Index()
        {
          
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index(FormCollection f)
        {

            return Redirect(ThanhToanMoMo("120tts","69300"));
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
        protected string ThanhToanMoMo(string maDonHang, string tongCong)
        {
            string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
            string partnerCode = "MOMOU7HO20201012";
            string accessKey = "m7FdDFcxJQucpLhi";
            string serectkey = "LWdLzT6SZ1oPUJ0kak2kzBQOWgLkR3sS";
            string orderInfo = "DongHocPhi";
            string returnUrl = "https://webbansach17dtha3.cf//Cart/Success";
            string notifyurl = "https://webbansach17dtha3.cf/";

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