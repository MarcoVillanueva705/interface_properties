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
        public void CanBeCancelledBy_AdminCancelling_ReturnTrue()
            //every test method has 3 parts:
            //1.specifies the method under test
            //2.the scenario being tested
            //3.the expected behavior

        {   
            //Arrange: Where we initialize our objects;

            var reservation = new Reservation();
            //fix tomorrow

            //Act: We call the method we're going to test

            bool result = reservation.CanBeCancelledBy(new User { IsAdmin = true});

            //Assert: Verify if the result is correct
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()

        {
            //arrange
            var user = new User();
            //act
            var reservation = new Reservation { MadeBy = user};

            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        
        }
        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            //arrange
            //trying to understand MadeBy
            var reservation = new Reservation { MadeBy = new User()};

            //act
            //two different User objects User.User()?
            //is new User in this case shorthand for User user = new User()?
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            //Assert.IsFalse(result);
            Assert.That(result, Is.False);//NUnit style
        }
        [Test]
        public void AddMenuItem_ItemIsFood_ReturnString()
        {
            //Arrange
            var menu = new Menu {AddFood = new User()};

            //Act
            var result = menu.AddMenuItem(new User());
            //Assert
            //add menu item test failed
            Assert.That(result, Is.NaN);
        }
             


        //netcoreapp2.1 cannot be referenced by .NETFramework, Version=4.6.1

        ////TDD 'test driven development'
        //You write your tests before writing
        //the production code

        //start by writing a test that will fail
        //because you don't have any application
        //code that would make it pass
        //right then you'll write the simplest code
        //that will make this test pass
        //use the simplest implementation that would make
        //the test pass
        //then, refactor the code if necessary

        //Benefits of TDD
        //Testable Source Code
        //Full Coverage by Tests
        //Simpler Implementation
    }
}
