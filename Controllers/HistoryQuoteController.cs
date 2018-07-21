using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
  
    public class HistoryQuoteController : ApiController
    {
        Ticks20sec[] products = new Ticks20sec[]
       {
            new Ticks20sec { exchange_id = "Tomato Soup" },
            new Ticks20sec { exchange_id = "Tomato Soup" },
            new Ticks20sec  { exchange_id = "Tomato Soup" }
       };
        //public IEnumerable<Ticks20sec> GetAllProducts()
        //{
        //    return products;
        //}
        //    

        //   [HttpGet, ActionName("GetByDate")]
        [HttpGet, Route("api/HistoryQuote/GetByDate/{dt}")]       
        public string GetByDate(int dt )
        {
            DataTable dtable = VC.Tools.Helper.MysqlClientDBHelper.GetDataTable("select * from dbcoin.rw_tick_20s where dt="+dt +" order by timestamp ");

            return JsonConvert.SerializeObject(dtable);
        }


        [HttpGet, Route("api/HistoryQuote/GetSymbol/{dt}")]
        public string GetSymbol(int dt)
        {
            DataTable dtable = VC.Tools.Helper.MysqlClientDBHelper.GetDataTable("select distinct symbol from dbcoin.rw_tick_20s where dt=" + dt);

            return JsonConvert.SerializeObject(dtable);
        }
    }
}
