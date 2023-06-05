using Cab_Invoice_Generator;
using System;

namespace CabInvoiceTestProject
{
    [TestClass]
    public class CabInvoiceTestClass
    {
        [TestMethod]
        [DataRow("")]
        public void Given_MultipleRides_Should_Return_TotalFare(string expectedMsg)
        {
            try
            {
                Ride[] rides = new Ride[]
                {
                    new Ride( 5, 5, RideTypes.NORMAL ),
                    new Ride( 2, 3, RideTypes.PREMIUM ),
                };
                InvoiceGenerator invoice = new InvoiceGenerator();
                double actual = invoice.CalculateFare(rides);
                Assert.AreEqual(91, actual);
            }
            catch (CabInvoiceCustomException ex)
            {
                Assert.AreEqual(expectedMsg, ex.Message);
            }
        }
    }
}