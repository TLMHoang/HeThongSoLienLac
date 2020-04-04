using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Hãy Nhập Tên Đăng Nhập !")]
        public string TaiKhoan { get; set; }
        [Required(ErrorMessage = "Hãy Nhập Mật Khẩu !")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
    }
}