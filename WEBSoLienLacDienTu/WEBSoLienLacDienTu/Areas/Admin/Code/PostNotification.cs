using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WEBSoLienLacDienTu.Areas.Admin.Code
{
    public class PostNotification
    {
        public PostNotification(string NameUser, string TitleEN, string ContentEN, string TitleVN, string ContentVN)
        {
            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ODliOGM5OTYtY2E0Yi00NzVkLTk5MzktNTc5ZTE4YzM2MGIy");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "24bb2a3a-7946-4823-aad5-5dc026481279",
                contents = new { en = ContentEN, vn = ContentVN },
                headings = new { en = TitleEN, vn = TitleVN },
                filters = new object[] { new { field = "tag", key = "id_user_PHHS", relation = "=", value = NameUser } }
            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
            }

            System.Diagnostics.Debug.WriteLine(responseContent);
        }
    }
}