﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBSoLienLacDienTu.Code;

namespace WEBSoLienLacDienTu.Controllers
{
    [SessionTimeout]
    public class ThongBaoTruongCaNhanController : Controller
    {
        // GET: ThongBaoTruongCaNhan
        public ActionResult Index()
        {
            return View();
        }
    }
}