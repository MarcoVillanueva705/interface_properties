﻿using System;

namespace interface_properties
{
    class Program
    {
        //interface IPerson
        //{
        //    string Name
        //    {
        //        get; set;
        //    }// abstract property
            
        //}
        //comment out and still have access to Name property?

        class Humanoid //: IPerson
        {
           // private string _name;
            public string Name  // read-write instance property
            {
                get;
                set;
            }

            public Humanoid() 
            {
                Name = "JoJo";
            }

    }

        static void Main(string[] args)
        {
            Humanoid myObj = new Humanoid();
            //myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}
