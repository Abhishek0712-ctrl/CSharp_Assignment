namespace EMSModule
{
    public class User
    {
        private int _userid;
        public int userID
        {
            set
            {
                if ((value != 0) && !(value < 0))
                    _userid = value;
                else
                    Environment.Exit(1);
            }
            get
            {
                return _userid;
            }
        }
        private int _empid;
        public int Empid
        {
            set
            {
                if ((value != 0) && !(value < 0))
                    _empid = value;
                else
                    Environment.Exit(1);
            }
            get
            {
                return _empid;
            }
        }

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

    public class Payment
    {
        public long PaymentID { get; set; }
        public long CourierID { get; set; }
        public double amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }

    public class uservalidation
    {
        public string Username;
        public string Password;

        public uservalidation(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool CheckUser(string username, string password)
        {
            if (Username == username && Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
