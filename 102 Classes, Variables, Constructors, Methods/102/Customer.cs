using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Custom constructor can be called by using "ctor" in code 
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name, string address = "You can set this to an optional constructor by doing this")   //this constructor is added ontop of the other so we can also use just the name instead of having all the information
        {
            Name = name;
            Address = address;
        }

        public Customer()  //this is a default constructor which has nothing inside the constructor ()
        {
            Name = "New Customer";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        public void SetDetails(string name, string address, string contactNumber = "NA")  /*here we are using a method to modify the constructor which is only called at the beggining of creating a new object 
                                                                                           the ="NA" is how you set a optional parameter, this means if we don't fill this part out while using the method it will be ok
                                                                                           , you can also use this in constructors too not just methods.                             */
        { 
            Name = name;
            Address = address;
            ContactNumber = contactNumber;   //note void means it returns nothing.
        }
    }   
}
