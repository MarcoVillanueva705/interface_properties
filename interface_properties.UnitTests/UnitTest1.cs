using System;
//fixed 'Arrange' error
using interface_properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace interface_properties.UnitTests
{
    [TestClass]//attribute
    public class ReservationTests
    {
        [TestMethod]//attribute w/one method
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
            //every test method has 3 parts:
            //1.specifies the method under test
            //2.the scenario being tested
            //3.the expected behavior

        {   
            //Arrange: Where we initialize our objects;

            var reservation = new Reservation();

            //Act: We call the method we're going to test

           var result = reservation.CanBeCancelledBy(new User { IsAdmin = True});

            //Assert: Verify if the result is correct
            Assert.IsTrue(result);
            //fix test method tomorrow
        }
    }
}
