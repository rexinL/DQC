﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HistoryController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Raw()
        {
            return View();
        }

    }
}