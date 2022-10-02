using System;
using DataAccess.Entities;
using DataAccess.Operations;

namespace NorthWendTest
{
    internal class ProductSalesReport
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog = Northwind; Integrated Security = True";

        private static ProductSalesReportOperation salesOperations=new ProductSalesReportOperation(connectionString);
        internal static void Execute()
        {
            Console.WriteLine("Please Enter Product Name");
            string ProductName=Console.ReadLine();
            Console.WriteLine("Please Enter Month");
            string Month=Console.ReadLine();
            Console.WriteLine("Please Enetr Year");
            int year=int.Parse(Console.ReadLine());

            ProductSales emp = salesOperations.GetSalesReport(ProductName, Month, year);

            Console.WriteLine("Product Name     :{0}",emp.ProductName);
            Console.WriteLine("Month Name       :{0}",emp.MonthName);
            Console.WriteLine("Total Price      :{0}",emp.TotalPrice);

            Console.ReadLine();



        }
    }
}