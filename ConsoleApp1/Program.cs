using EMSModule;
using DAOModule;
using ExceptionModule;
using UtilModule;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Serialization;
internal class Program
{
    private static void Main(string[] args)
    {
        //--------------------Task 1------------------------
        //ANS 1
        //Console.Write("Enter the Status of your order: ");
        //string orders = Console.ReadLine();
        //OrderStatus(orders);


        //ANS 2
        //Console.Write("Enter the Weight in kg: ");
        //int _weight = Convert.ToInt32(Console.ReadLine());
        //ParcelCategory(_weight);

        //ANS 3
        //Console.Write("Select 1. for User and 2. for Employee: ");
        //int choice = Convert.ToInt32(Console.ReadLine());
        //if (choice == 1)
        //{
        //    Uservalidation();
        //}
        //else if (choice == 2)
        //{
        //    Empvalidation();
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Choice");
        //}

        //ANS 7
        //TrackingWithLocationUpdate();

        //ANS 9
        //ParcelTracking();

        //ANS 10
        //Console.Write("Enter the Data: ");
        //string _Data = Console.ReadLine();
        //Console.Write("Enter the Details: ");
        //string _Detail = Console.ReadLine();
        //ValidateCustomerInfo(_Data, _Detail);

        //ANS 11
        //AddressFormatting();

        //ANS 12
        //OrderConfirmationEmail();

        //ANS 13


        Console.Read();

    }

    

    //public static void ValidateCustomerInfo(string data, string detail)
    //{
    //    if (detail.ToLower() == "name")
    //    {
    //        foreach (char c in data)
    //        {
    //            if (!char.IsLetter(c)  && (!char.IsUpper(data[0])))
    //            {
    //                Console.WriteLine("Data is not name");
    //                break;
    //            }
    //        }

    //    }
    //    else if (detail.ToLower() == "address")
    //    {
    //        foreach (char c in data)
    //        {
    //            if (!char.IsLetterOrDigit(c) && c!=' ')
    //            {
    //                Console.WriteLine("Data is not address");
    //                break;
    //            }
    //        }
    //        Console.WriteLine("Data is address");
    //    }
    //    else if (detail.ToLower() == "phone")
    //    {
    //        if (data.Length != 10) Console.WriteLine("Data is not Phone number"); ;

    //        foreach (char i in data)
    //        {
    //            if (Char.IsDigit(i))
    //            {
    //                continue;
    //            }
    //            else
    //            {
    //                if (!char.IsDigit(data[i])) Console.WriteLine("Data is not Phone Number");
    //            }
    //        }
    //        Console.WriteLine("Data is Phone number");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Invalid data and detail");
    //    }
    //}
    ////private static void TrackingWithLocationUpdate()
    //{
    //    string[] trackingHistory = new string[5];

    //    trackingHistory[0] = "Parcel picked up from sender";
    //    trackingHistory[1] = "Arrived at local sorting center";
    //    trackingHistory[2] = "In transit to destination city";
    //    trackingHistory[3] = "Arrived at destination sorting center";
    //    trackingHistory[4] = "Out for delivery";

    //    Console.WriteLine("Tracking History for the Parcel:");
    //    for (int i = 0; i < trackingHistory.Length; i++)
    //    {
    //        Console.WriteLine($"{i + 1}. {trackingHistory[i]}");
    //    }
    //}

    //public static void Datavalidation(string Data, string Detail)
    //{
    //    if (Detail.ToLower() == "name")
    //    {
    //        //string special = "!@#$%^&*()_+";
    //        foreach (var item in Data)
    //        {
    //            if (!char.IsLetter(item))
    //                break;
    //            Console.WriteLine("Data is not Name");
    //        }
    //        Console.WriteLine("Data is Name");

    //    }
    //    else if (Detail == "Address" || Detail == "address")
    //    {
    //        string special = "!@#$%^&*()_+";
    //        for (int i = 0; i < Data.Length; i++)
    //        {
    //            if (!Data.Contains(special))
    //            {
    //                Console.WriteLine("Data is address");

    //            }
    //            else
    //            {
    //                break;
    //            }
    //        }
    //    }
    //    else if (Detail == "phone number")
    //    {
    //        if (Data.Length == 10)
    //        {
    //            foreach(char i in Data)
    //            {
    //                if (Char.IsDigit(i))
    //                {
    //                    continue;
    //                }
    //            }
    //            Console.WriteLine("The data is Phone Number");
    //        }
    //    }
    //    else { Console.WriteLine("Invalid Data"); }
    //}
    //private static void Empvalidation()
    //{
    //    List<Employee> emp = new List<Employee>();

    //    emp.Add(new Employee { employeeName = "Harry", password = "H@rry" });
    //    emp.Add(new Employee { employeeName = "Ron", password = "R0n" });
    //    emp.Add(new Employee { employeeName = "Hermione", password = "Hermi0ne" });

    //    FindEmp(emp);
    //}
    private static void Uservalidation()
    {
        
        List<User> users = new List<User>();

        users.Add(new User { userName = "John", password = "John@123" });
        users.Add(new User { userName = "Sam", password = "S@m" });
        users.Add(new User { userName = "Tom", password = "Tom@553" });
        users.Add(new User { userName = "Jerry", password = "Jerry@007" });
        FindUser(users);

    }
    private static void FindEmp(List<Employee> employees)
    {
        Console.Write("Enter the Employee name: ");
        Employee employee = new Employee();
        employee.employeeName = Console.ReadLine();
        Console.Write("Enter the Password: ");
        employee.password = Console.ReadLine();

        Employee foundorNot = employees.Find(e => e.employeeName == employee.employeeName && e.password == employee.password);

        if (foundorNot == null)
        {
            Console.WriteLine("Employee not Found");
        }
        else
        {
            Console.WriteLine("Employee Found");
        }
    }
    private static void FindUser(List<User> users)
    {
        Console.Write("Enter the Username: ");
        User user = new User();
        user.userName = Console.ReadLine();
        Console.Write("Enter the Password: ");
        user.password = Console.ReadLine();

        User foundorNot = users.Find(u => u.userName == user.userName && u.password == user.password);

        if (foundorNot == null)
        {
            Console.WriteLine("User not Found");
        }
        else
        {
            Console.WriteLine("User Found");
        }
    }

    private static void ParcelCategory(int _weight)
    {
        switch (_weight)
        {
            case < 2:
                Console.WriteLine("Parcel is of Light Category");
                break;
            case > 2 and <= 5:
                Console.WriteLine("Parcel is of Medium Category");
                break;
            case > 5:
                Console.WriteLine("Parcel is of Heavy Category");
                break;
            default:
                Console.WriteLine("Invalid Category");
                break;
        }
    }

    private static void OrderStatus(string orders)
    {
        string order = orders.ToLower();
        if (order == "delivered")
        {
            Console.WriteLine("order is delivered.");
        }
        else if (order == "processing")
        {
            Console.WriteLine("order is still in process.");
        }
        else if (order == "cancelled")
        {
            Console.WriteLine("order is cancelled");
        }
        else
        {
            Console.WriteLine("Invalid Status");
        }
    }

    private static void ParcelTracking()
    {
        string[,] trackingData = new string[,]
        {
            {"TRK001","In Transit"},
            {"TRK002","Delivered"},
            {"TRK003","Out for Delivery"},
            {"TRK004","Delivered"},
            {"TRK005","In Transit"},
            {"TRK006","Out for Delivery"}
        };

        Console.Write("Enter the parcel tracking number (Like : TRK003): ");
        string trackingNumber = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < trackingData.GetLength(0); i++)
        {
            if (trackingData[i, 0] == trackingNumber)
            {
                found = true;
                string status = trackingData[i, 1];
                if (status == "In Transit")
                {
                    Console.WriteLine("Parcel is currently in transit.");
                }
                else if (status == "Out for Delivery")
                {
                    Console.WriteLine("Parcel is out for delivery. It should arrive soon.");
                }
                else if (status == "Delivered")
                {
                    Console.WriteLine("Parcel has been delivered.");
                }
                else
                {
                    Console.WriteLine("Unknown status.");
                }
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Tracking Number is Invalid");
        }
    }

    public static void AddressFormatting()
    {
        List<string> address = new List<string>();

        Console.Write("Enter the amount of address you want to add: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter the street {i + 1}: ");
            string street = Console.ReadLine();

            Console.Write($"Enter the city {i + 1}: ");
            string city = Console.ReadLine();

            Console.Write($"Enter the state {i + 1}: ");
            string state = Console.ReadLine();

            Console.Write($"Enter the zip code {i + 1}: ");
            int zip = Convert.ToInt32(Console.ReadLine());

            string formattedStreet = Capitalize(street);
            string formattedCity = Capitalize(city);
            string formattedState = Capitalize(state);

            string formattedAddress = $"{formattedStreet}, {formattedCity}, {formattedState} - {zip}";

            address.Add(formattedAddress);
        }
        Console.WriteLine("All the Address are: ");
        for (int i=0; i < address.Count; i++)
        {
            Console.WriteLine($"{address[i]}");
        }
    }
    public static string Capitalize(string str)
    {
        string[] words = str.Split(' ');
        string result = "";
        foreach (string word in words)
        {
            result += char.ToUpper(word[0]) + word.Substring(1) + " ";
        }
        return result;
    }

    public static string GenerateOrderConfirmationEmail(string customerName, string orderNumber, string deliveryAddress, string deliveryDate)
    {
        string email = $"Dear {customerName},\n\n" +
                       $"Thank you for your order! Your order number is {orderNumber}.\n\n" +
                       $"Delivery Address:\n{deliveryAddress}\n\n" +
                       $"Your order is expected to be delivered on {deliveryDate}.\n\n" +
                       "If you have any questions, feel free to contact our support team.\n\n" +
                       "Best regards,\n" +
                       "The Courier Company Team";

        return email;
    }
    private static void OrderConfirmationEmail()
    {
        Console.WriteLine("Enter Customer Name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Enter Order Number:");
        string orderNumber = Console.ReadLine();

        Console.WriteLine("Enter Delivery Address (Street, City, State, Zip Code):");
        string deliveryAddress = Console.ReadLine();

        Console.WriteLine("Enter Expected Delivery Date (MM/DD/YYYY):");
        string deliveryDate = Console.ReadLine();

        // Step 2: Generate the order confirmation email
        string emailBody = GenerateOrderConfirmationEmail(customerName, orderNumber, deliveryAddress, deliveryDate);

        // Step 3: Display the generated email
        Console.WriteLine("\n--- Order Confirmation Email ---");
        Console.WriteLine(emailBody);
    }



}
