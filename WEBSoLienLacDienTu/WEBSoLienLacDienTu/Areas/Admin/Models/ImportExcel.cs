using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WEBSoLienLacDienTu.Areas.Admin.Code;

namespace WEBSoLienLacDienTu.Areas.Admin.Models
{
    public class ImportExcel
    {
        [Required(ErrorMessage = "Hãy Chọn File Excel !")]
        [FileExt(Allow = ".xls,.xlsx", ErrorMessage = "Chỉ Được Chọn File Excel !")]
        public HttpPostedFileBase file { get; set; }
    }
}