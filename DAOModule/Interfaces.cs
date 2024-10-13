using EMSModule;
using System.Globalization;
namespace DAOModule
{
    public interface ICourierUserService
    {
        public String TrackingNumber { get; set; }
        string placeOrder(Courier courierObj);

        string getOrderStatus(string trackingNumber);

        string cancelOrder(string trackingNumber);

        string getAssignedOrder(Employee employeeID);
    }
    public interface ICourierAdminService {
        public int addCourierStaff(Employee employeename,Employee contactNumber);

    }
}
