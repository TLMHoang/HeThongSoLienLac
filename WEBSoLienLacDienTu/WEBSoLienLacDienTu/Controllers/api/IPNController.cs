using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Code;


namespace WEBSoLienLacDienTu.Controllers.api
{
    public class IPNController : Controller
    {
        // GET: IPN
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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

        private void VerifyTask(HttpRequestBase ipnRequest)
        {
            var verificationResponse = string.Empty;

            try
            {
                var verificationRequest = (HttpWebRequest)WebRequest.Create("https://test-payment.momo.vn/gw_payment/transactionProcessor");

                //Set values for the verification request
                verificationRequest.Method = "POST";
                verificationRequest.ContentType = "application/x-www-form-urlencoded";
                var param = Request.BinaryRead(ipnRequest.ContentLength);
                var strRequest = Encoding.ASCII.GetString(param);

                //Add cmd=_notify-validate to the payload
                strRequest = "cmd=_notify-validate&" + strRequest;
                verificationRequest.ContentLength = strRequest.Length;

                //Attach payload to the verification request
                var streamOut = new StreamWriter(verificationRequest.GetRequestStream(), Encoding.ASCII);
                streamOut.Write(strRequest);
                streamOut.Close();

                //Send the request to PayPal and get the response
                var streamIn = new StreamReader(verificationRequest.GetResponse().GetResponseStream());
                verificationResponse = streamIn.ReadToEnd();
                streamIn.Close();

            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            ProcessVerificationResponse(verificationResponse);
        }


        private void LogRequest(HttpRequestBase request)
        {
            // Persist the request values into a database or temporary data store
        }
        //protected string KiemTra(string maDonHang, string tongCong)
        //{
        //    string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
        //    string partnerCode = "MOMOU7HO20201012";
        //    string accessKey = "m7FdDFcxJQucpLhi";
        //    string serectkey = "LWdLzT6SZ1oPUJ0kak2kzBQOWgLkR3sS";
        //    string amount = tongCong;
        //    string orderid = maDonHang;
        //    string requestId = maDonHang;
        //    int errorCode = 0 ;
        //    string orderInfo = "DongHocPhi_MaSo:" + TaiKhoanPhuHuynhController.ttHS.ID;
        //    string returnUrl = "https://solienlac-us.tk/XemHocPhi/ThanhToanThanhCong_MoMo";
        //    string notifyurl = "https://webhook.site/5e2e3092-2036-449e-b775-d041a3654d2c";

            
        //    string extraData = "";

        //    string rawHash = "partnerCode=" +
        //                     partnerCode + "&accessKey=" +
        //                     accessKey + "&requestId=" +
        //                     requestId + "&amount=" +
        //                     amount + "&orderId=" +
        //                     errorCode+ 0+
        //                     orderid + "&orderInfo=" +
        //                     orderInfo + "&returnUrl=" +
        //                     returnUrl + "&notifyUrl=" +
        //                     notifyurl + "&extraData=" +
        //                     extraData;

        //    log.Debug("rawHash = " + rawHash);
        //    MoMoSecurity crypto = new MoMoSecurity();
        //    //sign signature SHA256
        //    string signature = crypto.signSHA256(rawHash, serectkey);
        //    log.Debug("Signature = " + signature);

        //    //build body json request
        //    JObject message = new JObject
        //    {
        //        { "partnerCode", partnerCode },
        //        { "accessKey", accessKey },
        //        { "requestId", requestId },
        //        { "amount", amount },
        //        { "errorCode", errorCode },
        //        { "orderId", orderid },
        //        { "orderInfo", orderInfo },
        //        { "returnUrl", returnUrl },
        //        { "notifyUrl", notifyurl },
        //        { "extraData", extraData },
        //        { "requestType", "captureMoMoWallet" },
        //        { "signature", signature }

        //    };
        //    log.Debug("Json request to MoMo: " + message.ToString());
        //    string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

        //    JObject jmessage = JObject.Parse(responseFromMomo);
        //    log.Debug("Return from MoMo: " + jmessage.ToString());

        //    return jmessage.GetValue("payUrl").ToString();

        //}
        private void ProcessVerificationResponse(string verificationResponse)
        {
            if (verificationResponse.Equals("VERIFIED"))
            {
                NameValueCollection pay = HttpUtility.ParseQueryString(verificationResponse);
                string email = pay["payer_email"];
                string status = pay["payment_status"];
                string Name = pay["name"];
                string itemName = pay["item_name"];
                // check that Payment_status=Completed
                // check that Txn_id has not been previously processed
                // check that Receiver_email is your Primary PayPal email
                // check that Payment_amount/Payment_currency are correct
                // process payment
            }
            else if (verificationResponse.Equals("INVALID"))
            {
                //Log for manual investigation
            }
            else
            {
                //Log error
            }
        }
    }
}
