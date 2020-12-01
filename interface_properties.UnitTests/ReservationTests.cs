using System;
//fixed 'Arrange' error
using interface_properties;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace interface_properties.UnitTests
{
    [TestFixture]//attribute
    public class ReservationTests
    {
        [Test]//attribute w/one method
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
            //every test method has 3 parts:
            //1.specifies the method under test
            //2.the scenario being tested
            //3.the expected behavior

        {   
            //Arrange: Where we initialize our objects;

            var reservation = new Reservation();

            //Act: We call the method we're going to test

            bool result = reservation.CanBeCancelledBy(new User { IsAdmin = true});

            //Assert: Verify if the result is correct
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //fix test method tomorrow
        }
        //netcoreapp2.1 cannot be referenced by .NETFramework, Version=4.6.1
    }
}
