using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class EmployeeSales
    {
        public int EmployeeID { get; set; }

        public string OrderId { get; set; }    

        public int Count { get; set; }
    }
}
