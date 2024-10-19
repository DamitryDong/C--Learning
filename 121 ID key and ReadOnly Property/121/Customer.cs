using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121
{
    internal class Customer
    {

        //static field (variable) to hold identifier -------------------------------------------------------- variable
        
        private static int nextID =0;   //we are going to keep traack of each customer through a unique identifier therefore reapeated names wont matter. 
                                        //note that this is static so the variable doesn't exist in the constructor of the class. 


        private readonly int _id;       //readonly variables can only be assign once, they cannot be modify after being made, this ensure every customer will get a unique id and it increments


        //--------------------------------------------------------------------------------------------------- property

        public string Name { get; set; } 
        public string Address { get; set; }
        public string City { get; set; }

        
        public int ID                    //this makes a readonly property as you can't set it 
        {
            get         //here we code that it will return _id if it is call upon 
            {
                return _id; 
            }
        }          
        
        
        public Customer()
        {
            _id = nextID++;                 //here we increment the id like this to ensure that every customer made increments the id number
            Name = "New Customer";
            Address = string.Empty;
            City = string.Empty; 
        }

        //----------------------------------------------------------------------------------------------------- method

        //we now make a method that can be call to get the number of customer _id created

        public void GetDetailForID()
        {
            Console.WriteLine($"The Number of Id is {_id}");    
        }

    }
}
