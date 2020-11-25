using System;

namespace interface_properties
{
    public class Reservation
    {
        public User MadeBy //class Program property
        { get; set; }

        public bool CanBeCancelledBy(User user)//class Program method
        {
            if (user.IsAdmin)
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
            //Humanoid myObj = new Humanoid();
            //myObj.Name = "Liam";
            //Console.WriteLine(myObj.Name);
        }
    }
}
