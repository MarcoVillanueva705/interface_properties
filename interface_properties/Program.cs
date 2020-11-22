using System;

namespace interface_properties
{
    public class Program
    {
        //interface IPerson
        //{
        //    string Name
        //    {
        //        get; set;
        //    }// abstract property

        //}
        //comment out and still have access to Name property?

            // private string _name;
            public Human Name  // read-write instance property
            { get; set; }

                public bool IsTheName(Name name)
                {
                if (Name == "JoJo")
                    return true;
                return false;
                }
        
            public class Name 
            {
                public bool IsAdmin
            }


        static void Main(string[] args)
        {
            Humanoid myObj = new Humanoid();
            //myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}
