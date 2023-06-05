using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class InvoiceGenerator
    {
        public double CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            try
            {
                foreach (Ride ride in rides)
                {
                    totalFare += CalculateFare(rides);
                }
                return totalFare;
            }
            catch (Exception ex)
            {
                throw new CabInvoiceCustomException("null object", CabInvoiceCustomException.ExceptionTypes.EMPTY_RIDE);
            }
        }
    }
}
