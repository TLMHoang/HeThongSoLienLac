using DTO;
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
        
        private void ProcessVerificationResponse(string verificationResponse)
        {
            string madonHang;
            string tongCong;

            if (verificationResponse.Equals("VERIFIED"))
            {
                //HoaDonHocPhi hoaDonHocPhi = new HoaDonHocPhi();
                //hoaDonHocPhi.IDHocPhi = "";
                //hoaDonHocPhi.ThanhToan = 0;
                //hoaDonHocPhi.IDHocSinh = "";
                //log.Info("order id" + Request.Form["custom"]);
                //NameValueCollection pay = HttpUtility.ParseQueryString(verificationResponse);
                //string email = pay["payer_email"];
                //string status = pay["payment_status"];
                //string Name = pay["name"];
                //string itemName = pay["item_name"];
               
                // check that Payment_status=Completed
                // check that Txn_id has not been previously processed
                // check that Receiver_email is your Primary PayPal email
                // check that Payment_amount/Payment_currency are correct
                // process payment
                log.Info("Momo says VERIFIED");
            }
            else if (verificationResponse.Equals("INVALID"))
            {
                log.Error("oops-INVALID");
                //Log for manual investigation
            }
            else
            {
                log.Info("Momo say" + verificationResponse);
                //Log error
            }
        }
    }
}
