using System;

namespace interface_properties
{
    public class Reservation
    {
        public User MadeBy //class Reservation property
        { get; set; }

        public bool CanBeCancelledBy(User user)//class Program method
        {
            //return the result of this expression
            return (user.IsAdmin || MadeBy == user);

            //^^refactored^^

        //    if (user.IsAdmin)//user of type User class obj
        //        return true;
        //    if (user == MadeBy)
        //        return true;
        //    return false;
        }
    }
    public class Menu
    {
        public string User
        { get; set; }

        public string AddMenuItem(User food)
        {
            //what am I accessing?
            return food.Name;
        }
    }

    public class User 
    {
      public bool IsAdmin//class User property
      { get; set; }
      public string Name
        { get; set; }
      public string Food
        { get; set; }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Reservation myRes = new Reservation();
            
            User myObj = new User();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}
