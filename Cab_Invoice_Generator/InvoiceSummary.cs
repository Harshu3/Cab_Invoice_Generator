using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class InvoiceSummary
    {
        public int numberOfRides;
        public double totalFare;
        public double average;

        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.average = totalFare / numberOfRides;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) 
                return false;
            if (!(obj is InvoiceSummary)) 
                return false;
            InvoiceSummary invoiceSummary = (InvoiceSummary)obj;
            return numberOfRides == invoiceSummary.numberOfRides && totalFare == invoiceSummary.totalFare && average == invoiceSummary.average;
        }
    }
}
