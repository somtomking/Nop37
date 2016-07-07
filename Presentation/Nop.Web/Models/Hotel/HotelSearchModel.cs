using Nop.Web.Framework.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Web.Models.Hotel
{
    public class HotelSearchModel: BaseNopModel
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string Location { get; set; }
    }
}