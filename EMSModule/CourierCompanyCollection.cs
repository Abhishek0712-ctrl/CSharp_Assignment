using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSModule
{
    public class CourierCompanyCollection
    {
        public List<couriercompany> couriercompanies { get; set; }
        public CourierCompanyCollection(couriercompany company)
        {
            this.couriercompanies.Add(company);
        }
    }
}
