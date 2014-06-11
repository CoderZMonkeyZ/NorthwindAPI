using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coderzFramework.ConnectionString;


namespace coderzFramework.Database
{
    public class Database : ConnectionStrings
    {
        //private static string connectionString { get { return ConnectionString.ConnectionStrings.Northwind; } }
        public static string NorthwindConnection = "Server=SGFSMOLINE;Database=Northwind;Trusted_Connection=True;";

        public Database()
        {
            //this.sCon = new SqlConnection(connectionString);
        }
    
        public DataSet GetSPDataSet(string storedProcedureName, Hashtable htParams)
        {
            DataSet results = new DataSet();
            using (SqlConnection sCon = new SqlConnection(NorthwindConnection))
            {
                using (SqlCommand sCmd = new SqlCommand(storedProcedureName, sCon))
                {
                    sCmd.CommandType = CommandType.StoredProcedure;
                    SetSqlParameters(sCmd, htParams);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sCmd))
                    {
                        sCon.Open();
                        adapter.Fill(results);
                        sCon.Close();
                    }
                }

            }
            return results;
        }

        private SqlCommand SetSqlParameters(SqlCommand sCmd, Hashtable htParams)
        {
            if (htParams != null)
            {
                foreach (string key in htParams.Keys)
                {
                    sCmd.Parameters.Add(new SqlParameter(key, htParams[key]));
                }
            }

            return sCmd;
        }
    }
}
