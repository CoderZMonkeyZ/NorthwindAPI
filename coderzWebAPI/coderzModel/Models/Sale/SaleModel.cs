using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderzModel.Models.Sale
{
    public class SaleModel
    {
        public DateTime ShippedDate { get; set; }
        public Int32 OrderID { get; set; }
        public Decimal Subtotal { get; set; }
        public String Year { get; set; }
    }
}
