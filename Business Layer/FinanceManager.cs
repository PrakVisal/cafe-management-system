using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project.Class
{
    public class FinanceManager
    {
        public static decimal GetTotalAmountForPaymentMethod(string paymentMethod)
        {
            string query = "SELECT ISNULL(SUM(TotalRiel)/4100, 0) + ISNULL(SUM(TotalDollar), 0) FROM tbOrder WHERE PaymentMethodID = (SELECT PaymentMethodID FROM tbPaymentMethod WHERE PaymentMethod = @PaymentMethodName)";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentMethodName", paymentMethod);

                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        public static int GetOrderCountForPaymentMethod(string paymentMethod)
        {
            string query = "SELECT COUNT(*) FROM tbOrder WHERE PaymentMethodID = (SELECT PaymentMethodID FROM tbPaymentMethod WHERE PaymentMethod = @PaymentMethodName)";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentMethodName", paymentMethod);

                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public static decimal GetTotalStockInAmount()
        {
            string query = "SELECT ISNULL(SUM(Amount), 0) FROM tbStockIn";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        public static int GetStockInCount()
        {
            string query = "SELECT COUNT(*) FROM tbStockIn";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }
    }
}
