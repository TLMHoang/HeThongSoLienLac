﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBSoLienLacDienTu.Areas.Admin.Controllers
{
    public class QuanLyMonHocController : Controller
    {
        // GET: Admin/QuanLyMonHoc
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}