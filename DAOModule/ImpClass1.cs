using EMSModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOModule
{
    public class CourierUserServiceImpl : ICourierUserService
    {
       private Courier companyObj;
        public string TrackingNumber { get; set; }

        public string placeOrder(Courier courierObj)
        {
            companyObj = courierObj;
            return "Order placed successfully";
        }
        public string getOrderStatus(string trackingNumber)
        {
            if (companyObj.trackingNumber == trackingNumber)
            {
                return companyObj.status;
            }
            return "Invalid tracking number";
        }
        public string getStatus(string trackingNumber) {
            if (companyObj.trackingNumber == trackingNumber)
            {
                return companyObj.status;
            }
            return "Invalid tracking number";
        }
        public string cancelOrder(string trackingNumber)
        {
            if (companyObj.trackingNumber == trackingNumber)
            {
                companyObj.status = "Cancelled";
                return "Order cancelled successfully";
            }
            return "Invalid tracking number";
        }
        public string getAssignedOrder(Employee employeeID)
        {
            if (employeeID.role == "Delivery")
            {
                return "Assigned";
            }
            return "Not assigned";
        }
    }
    public class CourierAdminServiceImpl : CourierUserServiceImpl, ICourierAdminService
    {
        public int addCourierStaff(Employee employeename, Employee contactNumber)
        {
            return this.addCourierStaff(employeename, contactNumber);
        }
    }
    //public class CourierAdminServiceCollectionImpl : ICourierAdminService{ }
}
