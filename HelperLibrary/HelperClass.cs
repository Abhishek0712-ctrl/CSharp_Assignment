using EMSModule;
using System;
using DAOModule;
using ExceptionModule;

namespace HelperLibrary
{
    public class HelperClass
    {
        CourierUserServiceImpl service = new CourierUserServiceImpl();
        public bool deleteCourier(string trackingNumber)
        {
            bool status = service.RemoveOrder(trackingNumber);
            return status;
        }

    }
}
