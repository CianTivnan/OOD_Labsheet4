using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks_Customers
{
    public partial class SalesOrderHeader
    {
        public override string ToString()
        {
            return string.Format("{0}:{1} {2:C}",
                OrderDate.ToShortDateString(),
                SalesOrderID,
                TotalDue);
        }
    }
}
