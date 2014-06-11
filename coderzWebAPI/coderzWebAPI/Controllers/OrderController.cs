using coderzModel.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace coderzWebAPI.Controllers
{
    public class OrderController : ApiController
    {
        [HttpGet]
        public OrderModelListSet GetOrderDetail(int orderID)
        {
            OrderModelListSet orderModelResults = new coderzAdapter.Order.OrderAdapter().GetOrdersDetailByOrderID(orderID);
            return orderModelResults;
        }

        [HttpGet]
        public List<OrderModel.CustomerOrders> GetCustomersOrdersByCustomerID(string customerID)
        {
            List<OrderModel.CustomerOrders> customerOrders = new coderzAdapter.Order.OrderAdapter().GetCustomerOrdersByID(customerID);
            return customerOrders;
        }
    }
}
