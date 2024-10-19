using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    internal class Customer
    {
        private string _password;

        private string _Name;

        public const int ThisNumberIs4 = 4;   //this is not assign a value during run time. , this won't be different for each creation of a object.   (we set a value at the backend and dont assign new value 

        public readonly string Color;  // this is assign a value dueing run time, this means this can be different with each creation of a object   (we assign a value but we can't change it) 



        //--------------------------------- write only properties 

        public string Password
        {
            set { _password = value; }
        }

        public string Name 
        { 
            get
            {  return _Name; }
            set
            {
                _Name = value;
            }
        }

        //-------------------------------- Constructor

        public Customer (string name, string color)
        {
            Name = name;
            Color = color;
            Password = string.Empty;
        }

        //--------------------------------- Method 

        public void DisplayDetail() //this method will be use to see that the const variable will remain constant 
        {
            Console.WriteLine($"Name:{Name}, Color:{Color}, Constant Number: {ThisNumberIs4}");
        }
    }
}
