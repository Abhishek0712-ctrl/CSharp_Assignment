using EMSModule;
using UtilModule;
using ExceptionModule;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace DAOModule
{
    public class CourierUserServiceImpl : ICourierUserService
    {
       private CourierCompany _companyObj;

        Courier courier = new Courier();
        public string TrackingNumber { get; set; }

        public string placeOrder(Courier courierObj)
        {
            
            return TrackingNumber;
        }
        public string getOrderStatus(string trackingNumber)
        {


            return "None";
            //throw new NotImplementedException();
            //for (int i = 0; i <= _companyObj.couriercompanies.Count; i++)
            //{
            //    List<Courier> couriers = _companyObj.couriercompanies[i].couriers;

            //    Courier courierdata = couriers.Find(c => c.trackingNumber == trackingNumber);
            //    courierStatus = courierdata.status;
            //}
            //return courierStatus;

        }
        public bool RemoveOrder(string trackingNumber)
        {
            bool status = false;
            status = cancelOrder(trackingNumber, status);
            return status;

        }
        public bool cancelOrder(string trackingNumber,bool status)
        {
            SqlConnection cn = dbConnection.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("delete from courier where trackingNumber=" + trackingNumber, cn);
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    status = true;
                }
                return status;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
            

            //if (_companyObj.couriersDetails.TrackingNumber == trackingNumber)
            //{
            //    _companyObj.status = "Cancelled";
            //    return "Order cancelled successfully";
            //}
            return true;
        }
        public List<Courier> getAssignedOrder(Employee employeeID)
        {
            return null;

        }
    }
    public class CourierAdminServiceImpl : CourierUserServiceImpl, ICourierAdminService
    {
        public int addCourierStaff(Employee employeename, Employee contactNumber)
        {
            return this.addCourierStaff(employeename, contactNumber);
        }
    }

    public class CourierUserServiceCollectionImpl : ICourierAdminService
    {
        private CourierCompany _companyObj;
        public int addCourierStaff(Employee employeename, Employee contactNumber)
        {
            return this.addCourierStaff(employeename, contactNumber);
        }

    }
    public class CourierAdminServiceCollectionImpl : CourierUserServiceCollectionImpl,ICourierAdminService
    {

    }

}
