using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102
{
    //this class it internal, which means that it can only be accessed from within the same assembly
    internal class Car
    {
        //-----------------------------------------------------VARIABLES----------------------------------------------

        //member variable (outside of  methods but inside of class
        //private hides the variable from other classes, this mean that this can only be modifies inside the class 
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury; 

        //-----------------------------------------------------PROPERTY---------------------------------------------- YOU don't need this if you don't want any rules

        //This is a Property 
        //This creates a string which we can use to properly access and set the private string, this shows what we will get when we pull the variable and how to set it
        //we can use this to define exactly what _model and _brand can be set to and also how it it gotten outside of this class. 
        public string Model { get => _model; set => _model = value; } //This is the standard property without modification, to do this for any private member variable, you can use encapsulate by right clicking the variable. 

        public string Brand      //here we used the properties to put in more strict rules on setting and getting
        {
            get                         //GETTING RULES
            {
                if (_isLuxury)  //note that _isLuxury is a bool so you can use the if like this 
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }      

            set                         //SETTING RULES
            { 
                if (string.IsNullOrEmpty(value))  //note that the value key word is what is being passes , it is what brand is being set to.
                {
                    Console.WriteLine("You entered NOTHING");
                    _brand = "DefaultValue";
                } 
                else
                {
                    _brand = value;
                }
                    
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        //-----------------------------------------------------CONSTRUCTOR--------------------------------------------

        //this is a Constructor (whenever this is called in another class, it must follow the blueprint
        public Car(string model,string brand,bool isluxury) 
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"An car of the model {Model} and brand {Brand} has been created");

            IsLuxury = isluxury;
        }

        //-----------------------------------------------------METHODS-----------------------------------------------

        //you create a method like this
        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} and I'm Driving"); 
        }

    }
}
