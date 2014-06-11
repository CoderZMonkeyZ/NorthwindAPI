using coderzModel.Models.Order;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderzAdapter.Order
{
    public class OrderAdapter : BaseAdapter
    {
        private OrderModel orderModelResult = new OrderModel();
        //private List<OrderModel> orderModelResultList = new List<OrderModel>();
        private OrderModelListSet orderModelResultList = new OrderModelListSet();

        public OrderModelListSet GetOrdersDetailByOrderID(int orderID)
        {
            htParams["@OrderID"] = orderID;

            try
            {
                DataSet ds = results.GetSPDataSet("dbo.CustOrdersDetail", htParams);
                orderModelResultList = base.MappingOrderData(ds);
            }
            catch (Exception)
            {
                throw;
            }

            return orderModelResultList;
        }

        public List<OrderModel.CustomerOrders> GetCustomerOrdersByID(string customerID)
        {
            htParams["@CustomerID"] = customerID;
            List<OrderModel.CustomerOrders> customerOrderResults = new List<OrderModel.CustomerOrders>();
            try
            {
                DataSet ds = results.GetSPDataSet("dbo.CustOrdersOrders", htParams);
                customerOrderResults = base.CustomerOrdersMapping(ds);
            }
            catch (Exception)
            {
                
                throw;
            }

            return customerOrderResults;
        }
    }
}
