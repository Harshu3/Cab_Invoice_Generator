using Cab_Invoice_Generator;
using System;

namespace CabInvoiceTestProject
{
    [TestClass]
    public class CabInvoiceTestClass
    {
        [TestMethod]
        //[DataRow("Invalid distance")]
        //[DataRow("null object")]
        [DataRow("")]
        public void Given_RideDetails_Should_Return_TotalFare(string expectedMsg)
        {
            try
            {
                //Ride ride = null;
                Ride ride = new Ride(5, 5, RideTypes.NORMAL);
                InvoiceGenerator invoice = new InvoiceGenerator();
                double actual = invoice.CalculateFare(ride);
                Assert.AreEqual(55, actual);
            }
            catch (CabInvoiceCustomException ex)
            {
                Assert.AreEqual(ex.Message, expectedMsg);
            }
        }
    }
}