using EMSModule;
using System.Globalization;
namespace DAOModule
{
    public interface ICourierUserService
    {
        public String TrackingNumber { get; set; }
        string placeOrder(Courier courierObj);

        string getOrderStatus(int trackingNumber);

        bool cancelOrder(string trackingNumber,bool status);

        bool RemoveOrder(string trackingNumber);

        List<Courier> getAssignedOrder(Employee employeeID);
    }
    public interface ICourierAdminService {
        public int addCourierStaff(Employee employeename,Employee contactNumber);

    }
}
