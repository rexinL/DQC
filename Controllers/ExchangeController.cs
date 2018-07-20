using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ExchangeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: exchange
        public ActionResult Binance()
        {
            return View();
        }
        public ActionResult Bitfinex()
        {
            return View();
        }
        public ActionResult Okex()
        {
            return View();
        }
        public ActionResult Hubipro()
        {
            return View();
        }
        public ActionResult ZB()
        {
            return View();
        }
        public ActionResult Kraken()
        {
            return View();
        }
        public ActionResult HitBTC()
        {
            return View();
        }
        public ActionResult BitZ()
        {
            return View();
        }
        public ActionResult Top10Detail()
        {
            return View();
        }
        public ActionResult Top10DetailChart()
        {
            return View();
        }
        public ActionResult Top10DetailKChart()
        {
            return View();
        }
    }
}