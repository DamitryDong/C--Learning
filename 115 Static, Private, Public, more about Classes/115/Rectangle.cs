using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115
{
    internal class Rectangle          //also note that you don't need to specify the constructor as it will use the default constructor () if you dont specify
    {

        public double Width { get; set; }
        public double Height { get; set; } 



        // Computed Property : you can also do mathamathical computing using a class Property
        public double Area        //note that if we don't put a set or get, if will lack the function to get or set with the property (read only/write only property) 
        {
            get { return Width * Height; }
        }

        //-------------------------------------------------------------------------- STATIC methods

        //In C#, the static keyword is used to declare members of a class that belong to the class iteself rather than any specific instance of the class. 
        public static void Dosomething()  //here we showcase the public keyword, this means you don't have to create a object of "Rectangle" to use this.you can just call this 
        {
            Rectangle r = new Rectangle();  
        }

        //--------------------------------------------------------------------------- Static fields (variable) 

        public static int NumberOfRectangles = 0;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
            NumberOfRectangles++;   //we used this in the constructor so each time a rectangle is made it will add 1 to the NumberOfRectangle variable
        }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
            
            NumberOfRectangles++; 
        }
    }
}
