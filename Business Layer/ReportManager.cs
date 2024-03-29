using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RMS_Project.Business_Layer
{
    public class ReportManager
    {
        private const string connectionString = "Data Source=LAPTOP-ALHRF6DV\\SQLEXPRESS;Initial Catalog=ManagementSystem;Integrated Security=True";

        public DataTable GetInvoiceList()
        {
            string query = "SELECT o.OrderDate as InvoiceDate, o.CustomerID, " +
                "  o.TotalRiel, o.TotalDollar, pm.PaymentMethod as PaymentMethod FROM  " +
                "  tbOrder o INNER JOIN tbPaymentMethod pm ON o.PaymentMethodID = pm.PaymentMethodID;";

            return ExecuteQuery(query);
        }

        public DataTable GetStockInReport()
        {
            string query = "SELECT DISTINCT StockName, StockIn, UnitPrice, Amount, Date FROM tbStockIn";
            return ExecuteQuery(query);
        }

        public DataTable GetStockOutReport()
        {
            string query = "SELECT DISTINCT StockName, StockOut, UnitPrice, Amount, Date FROM tbStockOut";
            return ExecuteQuery(query);
        }

        public DataTable GetStockCountReport()
        {
            string query = "SELECT DISTINCT StockName, StockCount, UnitPrice, Amount FROM tbStockCount";
            return ExecuteQuery(query);
        }

        public DataTable GetStockAlertReport()
        {
            string query = "SELECT StockName, StockCount, " +
                           "CASE WHEN StockCount = 1 THEN 'Nearly Out of stock!' ELSE 'In stock' END AS AlertMessage " +
                           "FROM tbStockCount";
            return ExecuteQuery(query);
        }

        private DataTable ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw;
            }
        }
    }
}
