using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class EmployeeSalesOperation
    {
        private string _connectionString;

        public EmployeeSalesOperation(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<EmployeeSales> GetEmployeeSales(DateTime from, DateTime to)
        {
            List<EmployeeSales> employee = new List<EmployeeSales>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[usp_EmployeeSalesReport] '{from}','{to}'", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeSales emps = new EmployeeSales();
                    emps.EmployeeID = (int)reader[0];
                    emps.OrderId= (string)reader[1];
                    emps.Count= (int)reader[2];

                    employee.Add(emps);


                }
                connection.Close();

            }
            return employee;
        }

    }
}
