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
       private CourierCompany _companyObj;

        public string TrackingNumber { get; set; }

        public string placeOrder(Courier courierObj)
        {
            
            return TrackingNumber;
        }
        public string getOrderStatus(string trackingNumber)
        {
            string courierStatus = null;
            //   throw new NotImplementedException();
            for (int i = 0; i <= _companyObj.couriercompanies.Count; i++)
            {
                List<Courier> couriers = _companyObj.couriercompanies[i].couriers;

                Courier courierdata = couriers.Find(c => c.trackingNumber == trackingNumber);
                courierStatus = courierdata.status;
            }
            return courierStatus;

        }
        public string cancelOrder(string trackingNumber)
        {
            if (_companyObj.couriersDetails.TrackingNumber == trackingNumber)
            {
                _companyObj.status = "Cancelled";
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

    public class CourierUserServiceCollectionImpl : ICourierUserService
    {
        public static CourierCompanyCollection companyObj;
        public string TrackingNumber { get; set; }

        public string placeOrder(Courier courierObj)
        {
            return TrackingNumber;
        }

        public string getOrderStatus(int trackingNumber)
        {
            return "status";
        }

        public bool cancelOrder(string trackingNumber)
        {
            return true;
        }

        public List<Courier> getAssignedOrder(Employee employeeID)
        {
            return new List<Courier>();
        }
    }
    public class CourierAdminServiceCollectionImpl : CourierUserServiceCollectionImpl,ICourierAdminService
    {

    }

}
