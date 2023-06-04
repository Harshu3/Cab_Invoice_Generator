using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class InvoiceGenerator
    {
        public double CalculateFare(Ride ride)
        {
            try
            {
                if (ride.distance < 0)
                {
                    throw new CabInvoiceCustomException("Invalid distance", CabInvoiceCustomException.ExceptionTypes.INVALID_DISTANCE);
                }
                else if (ride.time < 0)
                {
                    throw new CabInvoiceCustomException("Invalid time", CabInvoiceCustomException.ExceptionTypes.INVALID_TIME);
                }
                else
                {
                    double totalFare = ride.distance * ride.COST_PER_KM + ride.time * ride.COST_PER_MINUTE;
                    return Math.Max(totalFare, ride.MINIMUM_FARE);
                }
            }
            catch (NullReferenceException ex)
            {
                throw new CabInvoiceCustomException("null object", CabInvoiceCustomException.ExceptionTypes.EMPTY_RIDE);
            }
        }
    }
}
