using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    public class GetOrdersRequest
    {
        public string OrderNumber { get; set; }

        public DateTime? OrderDateFrom { get; set; }

        public DateTime? OrderDateTo { get; set; }

        public DateTime? ShipmentDateFrom { get; set; }

        public DateTime? ShipmentDateTo { get; set; }

        public string OrderStatus { get; set; }

        public int? UserId { get; set; }
    }
}
