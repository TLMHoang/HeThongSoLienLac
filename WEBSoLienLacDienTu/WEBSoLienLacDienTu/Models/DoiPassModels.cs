using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Models
{
    public class DoiPassModels
    {
        [Required(ErrorMessage = "Vui Lòng Nhập Mật Khẩu Cũ !")]
        [DataType(DataType.Password)]
        public string MatKhauCu { get; set; }

        [Required(ErrorMessage = "Vui Lòng Nhập Mật Khẩu Mới !")]
        [DataType(DataType.Password)]
        public string MatKhauMoi { get; set; }

        [Required(ErrorMessage = "Vui Lòng Nhập Lại Mật Khẩu Mới !")]
        [Compare(otherProperty: "MatKhauMoi", ErrorMessage = "Mật Khẩu Mới Không Giống Nhau.")]
        [DataType(DataType.Password)]
        public string ConfirmMatKhauMoi { get; set; }
    }
}