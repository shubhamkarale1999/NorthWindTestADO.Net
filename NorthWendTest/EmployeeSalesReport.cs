using DataAccess.Entities;
using DataAccess.Operations;
using System;
using System.Collections.Generic;

namespace NorthWendTest
{
    internal class EmployeeSalesReport
    {
        
            private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog = Northwind; Integrated Security = True";

            private static EmployeeSalesOperation salesOperations = new EmployeeSalesOperation(connectionString);

            
        public static void Execute()
        {
            try
            {
                Console.WriteLine("Please Enter From Date");
                DateTime from = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("=======================");
                Console.WriteLine("Please Enetr To date");
                DateTime to = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("======================");

                List<EmployeeSales> emp = salesOperations.GetEmployeeSales(from, to);

                foreach (EmployeeSales employee in emp)
                {
                    Console.WriteLine("EmployeeID   :{0}", employee.EmployeeID);
                    Console.WriteLine("OrderId      :{0}", employee.OrderId);
                    Console.WriteLine("Total Count  :{0}", employee.Count);
                    Console.WriteLine("=========================================================");
                }
                Console.WriteLine("Please press Enter");
                Console.ReadLine();
            }
            catch
            {
                LoginMenu.Execute();
            }
        }

    }
}
