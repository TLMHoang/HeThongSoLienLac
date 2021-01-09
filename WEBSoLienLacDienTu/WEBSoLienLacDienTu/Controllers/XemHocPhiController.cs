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
using System.IO;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Data.SqlClient;
using System.Configuration;

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
            ViewBag.TongHocPhi = hocPhiThang;
            if (hocPhiNo != null)
            {
                ViewBag.LstHocPhiNo = hocPhiNo + " VNĐ";
            }
            else
            {
                ViewBag.LstHocPhiNo = "Không Nợ";
            }
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> DongHocPhi(FormCollection f)
        {

            var hocPhiNo = await LoadHocPhiNo();
            var hocPhiThang = await LoadTongHocPhi();
            var tongHocPhi = int.Parse(hocPhiThang != null ? hocPhiThang.ToString() : "0") + Convert.ToInt32(hocPhiNo != null ? hocPhiNo.ToString() : "0");
            ViewBag.TongHocPhiThangVaNo = tongHocPhi;
            ViewBag.TongHocPhi = hocPhiThang;

            if (hocPhiNo != null)
            {
                ViewBag.LstHocPhiNo = hocPhiNo;
            }
            else
            {
                ViewBag.LstHocPhiNo = "Không Nợ";
            }

            DataTable dt = await new HoaDonHocPhiDAL().ThemHoaDon(idHocPhi, TaiKhoanPhuHuynhController.ttHS.ID, DateTime.Now, 1);

            return Redirect(ThanhToanMoMo(dt.Rows[0]["ID"].ToString(), tongHocPhi.ToString()));





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
                if (lstHocPhiNo.Rows[0]["Tien"].ToString() == "")
                {
                    return null;
                }
                else
                {
                    return lstHocPhiNo.Rows[0]["Tien"].ToString();
                }

            }
            else
            {
                return null;
            }

        }
        public async Task<string> LoadTongHocPhi()
        {
            DataTable dt = await new ThongTinHocPhiDAL().LoadThongTinHocPhi_IDHS(TaiKhoanPhuHuynhController.ttHS.ID);
            DataTable TongHocPhi = await new ThongTinHocPhiDAL().LoadTongHocPhi(DateTime.Now.Month, int.Parse(dt.Rows[0]["IDLoaiHocSinh"].ToString()), int.Parse(dt.Rows[0]["IDKhoi"].ToString()));
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
            string orderInfo = "DongHocPhi_MaSo:" + TaiKhoanPhuHuynhController.ttHS.ID;
            string returnUrl = "https://solienlac-us.tk/XemHocPhi/ThanhToanThanhCongMoMo";
            string notifyurl = "https://webhook.site/5e2e3092-2036-449e-b775-d041a3654d2c";

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
        private class IPNContext
        {
            public HttpRequest IPNRequest { get; set; }

            public string RequestBody { get; set; }

            public string Verification { get; set; } = String.Empty;
        }
        //[HttpPost]
        //public ActionResult Receive()
        //{
        //    IPNContext ipnContext = new IPNContext()
        //    {
        //        IPNRequest = Request
        //    };

        //    using (StreamReader reader = new StreamReader(ipnContext.IPNRequest.Body, Encoding.ASCII))
        //    {
        //        ipnContext.RequestBody = reader.ReadToEnd();
        //    }

        //    //Store the IPN received from PayPal
        //    LogRequest(ipnContext);

        //    //Fire and forget verification task
        //    Task.Run(() => VerifyTask(ipnContext));

        //    //Reply back a 200 code
        //    return View();
        //}
        [HttpPost]
        public HttpStatusCodeResult Receive()
        {
            //Store the IPN received from PayPal
            LogRequest(Request);

            //Fire and forget verification task
            Task.Run(() => VerifyTask(Request));

            //Reply back a 200 code
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        private void LogRequest(HttpRequestBase request)
        {
            throw new NotImplementedException();
        }

        private void VerifyTask(HttpRequestBase request)
        {
            throw new NotImplementedException();
        }

        private void VerifyTask(IPNContext ipnContext)
        {
            try
            {
                var verificationRequest = WebRequest.Create("https://test-payment.momo.vn/gw_payment/transactionProcessor");

                //Set values for the verification request
                verificationRequest.Method = "POST";
                verificationRequest.ContentType = "application/x-www-form-urlencoded";

                //Add cmd=_notify-validate to the payload
                string strRequest = "cmd=_notify-validate&" + ipnContext.RequestBody;
                verificationRequest.ContentLength = strRequest.Length;

                //Attach payload to the verification request
                using (StreamWriter writer = new StreamWriter(verificationRequest.GetRequestStream(), Encoding.ASCII))
                {
                    writer.Write(strRequest);
                }

                //Send the request to PayPal and get the response
                using (StreamReader reader = new StreamReader(verificationRequest.GetResponse().GetResponseStream()))
                {
                    ipnContext.Verification = reader.ReadToEnd();
                }
            }
            catch (Exception exception)
            {
                //Capture exception for manual investigation
            }

            ProcessVerificationResponse(ipnContext);
        }


        private void LogRequest(IPNContext ipnContext)
        {
            // Persist the request values into a database or temporary data store
        }

        private void ProcessVerificationResponse(IPNContext ipnContext)
        {
            if (ipnContext.Verification.Equals("VERIFIED"))
            {
                // check that Payment_status=Completed
                // check that Txn_id has not been previously processed
                // check that Receiver_email is your Primary PayPal email
                // check that Payment_amount/Payment_currency are correct
                // process payment
            }
            else if (ipnContext.Verification.Equals("INVALID"))
            {
                //Log for manual investigation
            }
            else
            {
                //Log error
            }
        }
        public ActionResult BotChat()
        {
            return PartialView();
        }
        public async Task<JsonResult> botChat_Post(string strText)
        {
            var text = strText;
            var str = botChat_Request(strText);
            await AddChat(new NoiDungChat(-1, TaiKhoanPhuHuynhController.TK.ID, DateTime.Now, strText,0));
            return Json(str, JsonRequestBehavior.AllowGet);
        }
        string cs = ConfigurationManager.ConnectionStrings["BotChat"].ConnectionString;
        public async Task<int> AddChat(NoiDungChat nd)
        {
            return await new BotChat().Them(nd);
        }
        public string botChat_Request(string strText)
        {
            try
            {
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5000/post");

                JObject postData = new JObject
                {
                    { "Text", strText },
                };

                var data = Encoding.UTF8.GetBytes(postData.ToString());

                httpWReq.ProtocolVersion = HttpVersion.Version11;
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/json";

                httpWReq.ContentLength = data.Length;
                httpWReq.ReadWriteTimeout = 30000;
                httpWReq.Timeout = 15000;
                Stream stream = httpWReq.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

                string jsonresponse = "";

                using (var reader = new StreamReader(response.GetResponseStream()))
                {

                    string temp = null;
                    while ((temp = reader.ReadLine()) != null)
                    {
                        jsonresponse += temp;
                    }
                }

                JObject jmessage = JObject.Parse(jsonresponse);

                //todo parse it
                return jmessage.GetValue("Text").ToString(); ;
                //return new MomoResponse(mtid, jsonresponse);

            }
            catch (WebException e)
            {
                return e.Message;
            }
        }
    }
}