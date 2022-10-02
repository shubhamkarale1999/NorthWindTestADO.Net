using DataAccess.Operations;
using System;
using System.Security.Cryptography;

namespace NorthWendTest
{
    internal class LoginMenu
    {
        internal static void Execute()
        {
            Console.WriteLine("================><=================");
            Console.WriteLine("====Please Choose Correst Option===");
            Console.WriteLine("================><=================");
            Console.WriteLine();
            Console.WriteLine("1.Employee Sales report");
            Console.WriteLine("2.Weekly sales report");
            Console.WriteLine("3.Product wise monthly report");
            Console.WriteLine("4.Exit");
            int choise=int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch(choise)
            {
                case 1:
                    {

                        EmployeeSalesReport.Execute();
                        LoginMenu.Execute();
                    }
                    break;
                    case 2:
                    {
                        WeeklysalesReport.Execute();
                        LoginMenu.Execute();
                    }
                    break ;
                    case 3:
                    {
                        ProductSalesReport.Execute();
                        LoginMenu.Execute();
                    }
                    break;
                     case 4:
                    {
                        
                    }
                    break;
                    default:
                    {
                        Console.WriteLine("Please Choose Correct Option");
                    }
                    break;
            }


        }
    }
}