using System;

namespace interface_properties
{
    public class Reservation
    {
        public User MadeBy //class Reservation property
        { get; set; }

        public bool CanBeCancelledBy(User user)//class Program method
        {
            if (user.IsAdmin)//user of type User class obj
                return true;
            if (user == MadeBy)
                return true;
            return false;
        }
    }

    public class User 
    {
      public bool IsAdmin//class User property
      { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Reservation myRes = new Reservation();
            
            //Humanoid myObj = new Humanoid();
            //myObj.Name = "Liam";
            //Console.WriteLine(myObj.Name);
        }
    }
}
