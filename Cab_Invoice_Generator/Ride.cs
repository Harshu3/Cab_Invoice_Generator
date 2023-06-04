using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class Ride
    {
        public double distance;
        public int time;
        public RideTypes rideType;
        public readonly int MINIMUM_FARE;
        public readonly int COST_PER_KM;
        public readonly int COST_PER_MINUTE;
        public Ride(double distance, int time, RideTypes rideType)
        {
            this.distance = distance;
            this.time = time;
            this.rideType = rideType;

            if (RideTypes.NORMAL == rideType)
            {
                MINIMUM_FARE = 5;
                COST_PER_KM = 10;
                COST_PER_MINUTE = 1;
            }
            else
            {
                MINIMUM_FARE = 20;
                COST_PER_KM = 15;
                COST_PER_MINUTE = 2;
            }
        }
    }
}
