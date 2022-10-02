using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWendTest
{
    public class Program
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog = Northwind; Integrated Security = True";
        static void Main(string[] args)
        {
            LoginMenu.Execute();

        }
    }
}
