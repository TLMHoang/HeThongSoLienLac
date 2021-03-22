using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Code
{
    public class QRCodeModel
    {
        [Display(Name = "QRCode Text")]
        public string QRCodeText { get; set; }
        [Display(Name = "QRCode Image")]
        public string QRCodeImagePath { get; set; }
        public QRCodeModel() { 
           }

        public QRCodeModel(string qrCodeText)
        {
            QRCodeText = qrCodeText;
          

        }
        public QRCodeModel(string qrCodeText,string qrCodeIMGPath)
        {
            QRCodeText = qrCodeText;
            QRCodeImagePath = qrCodeIMGPath;

        }
    }
}