using coderzFramework.Database;
using coderzModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderzAdapter
{
    public class BaseAdapter
    {
        public Database results = new Database();
        public Hashtable htParams = new Hashtable();
        

        //Products
        public List<coderzModel.Models.Product.ProductModel> MappingProductData(System.Data.DataSet dsResults)
        {
            List<coderzModel.Models.Product.ProductModel> productListModel = new List<coderzModel.Models.Product.ProductModel>();
            foreach (System.Data.DataRow currentRow in dsResults.Tables[0].Rows)
            {
                coderzModel.Models.Product.ProductModel product = new coderzModel.Models.Product.ProductModel();
                if (!string.IsNullOrEmpty(currentRow["ProductName"].ToString()))
                {
                    product.ProductName = currentRow["ProductName"].ToString();
                }

                if (!string.IsNullOrEmpty(currentRow["Total"].ToString()))
                {
                    product.ProductTotal = Convert.ToInt32(currentRow["Total"].ToString());
                }

                if (!string.IsNullOrEmpty(product.ProductName) && !string.IsNullOrEmpty(product.ProductTotal.ToString()))
                    productListModel.Add(product);
            }

            return productListModel;
        }

        //Orders
        public coderzModel.Models.Order.OrderModelListSet MappingOrderData(System.Data.DataSet ds) //List<coderzModel.Models.Order.OrderModel> MappingOrderData(System.Data.DataSet ds)
        {
            //List<coderzModel.Models.Order.OrderModel> orderListModel = new List<coderzModel.Models.Order.OrderModel>();
            coderzModel.Models.Order.OrderModelListSet orderListModel = new coderzModel.Models.Order.OrderModelListSet();
            orderListModel.OrderModelList = new List<coderzModel.Models.Order.OrderModel>();
            orderListModel.OrderResultCount = 0;

            foreach (System.Data.DataRow currentRow in ds.Tables[0].Rows)
            {
                coderzModel.Models.Order.OrderModel order = new coderzModel.Models.Order.OrderModel();

                if (!string.IsNullOrEmpty(currentRow["ProductName"].ToString()))
                {
                    order.ProductName = currentRow["ProductName"].ToString();
                }

                if (!string.IsNullOrEmpty(currentRow["UnitPrice"].ToString()))
                {
                    order.UnitPrice = (decimal)currentRow["UnitPrice"];
                }

                if (!string.IsNullOrEmpty(currentRow["Quantity"].ToString()))
                {
                    order.Quanity = (Int16)currentRow["Quantity"];
                }

                if (!string.IsNullOrEmpty(currentRow["Discount"].ToString()))
                {
                    order.Discount = (Int32)currentRow["Discount"];
                }

                if (!string.IsNullOrEmpty(currentRow["ExtendedPrice"].ToString()))
                {
                    order.ExtendedPrice = (decimal)currentRow["ExtendedPrice"];
                }
                //orderListModel.Add(order);
                orderListModel.OrderModelList.Add(order);
                orderListModel.OrderResultCount++;
            }

            return orderListModel;
        }
        public List<coderzModel.Models.Order.OrderModel.CustomerOrders> CustomerOrdersMapping(System.Data.DataSet ds)
        {
            List<coderzModel.Models.Order.OrderModel.CustomerOrders> customerOrdersResults = new List<coderzModel.Models.Order.OrderModel.CustomerOrders>();
            foreach (System.Data.DataRow currentRow in ds.Tables[0].Rows)
            {
                coderzModel.Models.Order.OrderModel.CustomerOrders customerOrders = new coderzModel.Models.Order.OrderModel.CustomerOrders();
                if (!string.IsNullOrEmpty(currentRow["OrderID"].ToString()))
                {
                    customerOrders.OrderID = (Int32)currentRow["OrderID"];
                }

                if (!string.IsNullOrEmpty(currentRow["OrderDate"].ToString()))
                {
                    customerOrders.OrderDate = (DateTime)currentRow["OrderDate"];
                }

                if (!string.IsNullOrEmpty(currentRow["RequiredDate"].ToString()))
                {
                    customerOrders.RequiredDate = (DateTime)currentRow["RequiredDate"];
                }

                if (!string.IsNullOrEmpty(currentRow["ShippedDate"].ToString()))
                {
                    customerOrders.ShippedDate = (DateTime)currentRow["ShippedDate"];
                }

                customerOrdersResults.Add(customerOrders);
            }

            return customerOrdersResults;
        }

        //Employees
        public coderzModel.Models.Employee.EmployeeModelList MappingEmployeeSalesCountry(System.Data.DataSet ds)
        {
            coderzModel.Models.Employee.EmployeeModelList employeeModelResults = new coderzModel.Models.Employee.EmployeeModelList();
            employeeModelResults.Employees = new List<coderzModel.Models.Employee.EmployeeModel>();

            foreach (System.Data.DataRow currentRow in ds.Tables[0].Rows)
            {
                coderzModel.Models.Employee.EmployeeModel employee = new coderzModel.Models.Employee.EmployeeModel();
                if (!string.IsNullOrEmpty(currentRow["Country"].ToString()))
                {
                    employee.Country = currentRow["Country"].ToString();
                }

                if (!string.IsNullOrEmpty(currentRow["LastName"].ToString()))
                {
                    employee.LastName = currentRow["LastName"].ToString();
                }

                if (!string.IsNullOrEmpty(currentRow["FirstName"].ToString()))
                {
                    employee.FirstName = currentRow["FirstName"].ToString();
                }

                if (!string.IsNullOrEmpty(currentRow["ShippedDate"].ToString()))
                {
                    employee.ShippedDate = (DateTime)currentRow["ShippedDate"];
                }

                if (!string.IsNullOrEmpty(currentRow["OrderID"].ToString()))
                {
                    employee.OrderID = (Int32)currentRow["OrderID"];
                }

                if (!string.IsNullOrEmpty(currentRow["SaleAmount"].ToString()))
                {
                    employee.SaleAmount = (decimal)currentRow["SaleAmount"];
                }

                employeeModelResults.EmployeeCount++;
                employeeModelResults.Employees.Add(employee);
            }

            return employeeModelResults;
        }

        public coderzModel.Models.Sale.SalesModelList MappingSalesByYear(System.Data.DataSet ds)
        {
            coderzModel.Models.Sale.SalesModelList salesModelList = new coderzModel.Models.Sale.SalesModelList();
            coderzModel.Models.Sale.SaleModel saleModel = new coderzModel.Models.Sale.SaleModel();
            salesModelList.Sales = new List<coderzModel.Models.Sale.SaleModel>();

            foreach (System.Data.DataRow currentRow in ds.Tables[0].Rows)
            {
                if (!string.IsNullOrEmpty(currentRow["ShippedDate"].ToString())) 
                {
                    saleModel.ShippedDate = (DateTime)currentRow["ShippedDate"];       
                }
                
                if (!string.IsNullOrEmpty(currentRow["OrderID"].ToString())) 
                {
                    saleModel.OrderID = (Int32)currentRow["OrderID"];
                }

                if (!string.IsNullOrEmpty(currentRow["Subtotal"].ToString())) 
                {
                    saleModel.Subtotal = (Decimal)currentRow["Subtotal"];
                }

                if (!string.IsNullOrEmpty(currentRow["Year"].ToString())) 
                {
                    saleModel.Year = currentRow["Year"].ToString();
                }

                salesModelList.Count++;
                salesModelList.Sales.Add(saleModel);
            }

            return salesModelList;
        }

        public List<coderzModel.Models.Product.ProductModel> MappingProductTopTenData(System.Data.DataSet ds)
        {
            List<coderzModel.Models.Product.ProductModel> productModelList = new List<coderzModel.Models.Product.ProductModel>();
            
            foreach (System.Data.DataRow currentRow in ds.Tables[0].Rows)
            {
                coderzModel.Models.Product.ProductModel productModel = new coderzModel.Models.Product.ProductModel();

                if (!string.IsNullOrEmpty(currentRow["TenMostExpensiveProducts"].ToString())) 
                {
                    productModel.ProductName = currentRow["TenMostExpensiveProducts"].ToString();
                }
                
                if (!string.IsNullOrEmpty(currentRow["UnitPrice"].ToString())) 
                {
                    productModel.UnitPrice = (decimal)currentRow["UnitPrice"];
                }
                
                productModelList.Add(productModel);
            }

            return productModelList;
        }
    }
}
