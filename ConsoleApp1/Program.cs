using EMSModule;
using DAOModule;
using ExceptionModule;
using UtilModule;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
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

        //ANS 10
        //Console.Write("Enter the Data: ");
        //string _Data = Console.ReadLine();
        //Console.Write("Enter the Details: ");
        //string _Detail = Console.ReadLine();
        //ValidateCustomerInfo(_Data, _Detail);
        //object[,] newarr = { (1, "Hello"), (2, "World") };
        //foreach (var item in newarr)
        //{
        //    Console.WriteLine(item);
        //}

        //ANS 7
        //TrackingWithLocationUpdate();

        User user = new User();
        Console.WriteLine("Enter UserId:");
        user.userID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"User ID is :{user.userID}");

        Console.WriteLine("Enter Empid");
        user.Empid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You entered empid=  {user.Empid}");

        //int p1=Int32.Parse(s3);

        Console.Read();

    }
    public static void ValidateCustomerInfo(string data, string detail)
    {
        if (detail.ToLower() == "name")
        {
            foreach (char c in data)
            {
                if (!char.IsLetter(c)  && (!char.IsUpper(data[0])))
                {
                    Console.WriteLine("Data is not name");
                    break;
                }
            }
            
        }
        else if (detail.ToLower() == "address")
        {
            foreach (char c in data)
            {
                if (!char.IsLetterOrDigit(c) && c!=' ')
                {
                    Console.WriteLine("Data is not address");
                    break;
                }
            }
            Console.WriteLine("Data is address");
        }
        else if (detail.ToLower() == "phone")
        {
            if (data.Length != 10) Console.WriteLine("Data is not Phone number"); ;

            foreach (char i in data)
            {
                if (Char.IsDigit(i))
                {
                    continue;
                }
                else
                {
                    if (!char.IsDigit(data[i])) Console.WriteLine("Data is not Phone Number");
                }
            }
            Console.WriteLine("Data is Phone number");
        }
        else
        {
            Console.WriteLine("Invalid data and detail");
        }
    }
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
    



}