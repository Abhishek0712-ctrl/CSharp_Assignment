using System.Reflection.Metadata;

namespace EMSModule
{
    public class User
    {
        public int userID{ get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int contactNumber { get; set; }
        public string address { get; set; }

    }

    public class  Courier
    {
        public int courierID { get; set; }
        public string senderName { get; set; }
        public string receiverName { get; set; }
        public string senderAddress { get; set; }
        public string receiverAddress { get; set; }
        public int weight { get; set; }
        public string status { get; set; }
        public string trackingNumber { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int userid { get; set; }
    }

    public class Employee
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int contactNumber { get; set; }
        public string role { get; set; }
        public double salary { get; set; }
    }
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
    }

    public class CourierCompany
    {
        public string companyName { get; set; }
        public List<Courier> couriersDetails { get; set; }
        public List<Employee> employeesDetails { get; set; }
        public List<Location> locationsDetails { get; set; }

    }
        public class Payment
    {
        public long PaymentID { get; set; }
        public long CourierID { get; set; }
        public double amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
    
}
