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
        public DateTime NgaySinh { get; set; }
        public byte GioiTinh { get; set; }
        public string Lop { get; set; }
        public string Ten { get; set; }
        public QRCodeModel() { 
           }

        public QRCodeModel(string qrCodeText)
        {
            QRCodeText = qrCodeText;         

        }
        public QRCodeModel(string qrCodeText,string qrCodeIMGPath,DateTime ngaySinh,byte gioiTinh,string lop,string ten)
        {
            QRCodeText = qrCodeText;
            QRCodeImagePath = qrCodeIMGPath;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Lop = lop;
            Ten = ten;
        }
    }
}