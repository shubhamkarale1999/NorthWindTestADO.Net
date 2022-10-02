using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class ProductSalesReportOperation
    {
        private string _connectionString;

        public ProductSalesReportOperation(string connectionString)
        {
            _connectionString = connectionString;
        }
        public ProductSales GetSalesReport(string productName, string month,int year)
        {
            ProductSales emp = new ProductSales();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"Execute [dbo].[usp_SalesByMonth] '{productName}',{month},'{year}'", connection);

                connection.Open();

                
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    emp.ProductName = (string)reader[0];
                    emp.MonthName= (string)reader[1];
                    emp.TotalPrice = (decimal)reader[2];

                }

                connection.Close();

            }

            return emp;
        }
    }
}
