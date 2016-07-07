using Nop.Web.Models.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nop.Web.Controllers
{
    /// <summary>
    /// 酒店
    /// </summary>
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
            HotelSearchModel searchModel = new Models.Hotel.HotelSearchModel();
            searchModel.From = DateTime.UtcNow;
            searchModel.To = DateTime.UtcNow.AddDays(1);
            return View(searchModel);
        }


    }
}