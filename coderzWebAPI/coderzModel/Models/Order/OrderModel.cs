using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderzModel.Models.Order
{
    public class OrderModel
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 Quanity { get; set; }
        public int Discount { get; set; }
        public decimal ExtendedPrice { get; set; }

        public class CustomerOrders
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime RequiredDate { get; set; }
            public DateTime ShippedDate { get; set; }
        }
    }
}
