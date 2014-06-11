using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace coderzFramework.ConnectionString
{
    public class ConnectionStrings
    {
        public static string Northwind = ConfigurationSettings.AppSettings["DBNorthwind"];
    }
}
