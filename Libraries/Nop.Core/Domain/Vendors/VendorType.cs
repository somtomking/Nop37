using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Vendors
{
    public enum VendorType
    {
        /// <summary>
        /// 线上销售
        /// </summary>
        Online = 0,
        /// <summary>
        /// 酒店
        /// </summary>
        Hotel = 10,
        /// <summary>
        /// KTV
        /// </summary>
        KTV = 20,
        /// <summary>
        /// 餐饮
        /// </summary>
        Rrestaurant = 30,
        /// <summary>
        /// 票务服务
        /// </summary>
        TicketService = 40
    }
}
