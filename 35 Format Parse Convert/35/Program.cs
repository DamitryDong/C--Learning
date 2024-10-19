//Implicit conversion
// converting data type to another bigger type that already consist of the other.

using System.Runtime.CompilerServices;

int myint = 0;
double myDouble = myint;

//explicit conversion / (CASTING) 
//converting a larger type into a smaller type
long mylong = 12345678910111213;
int myInt2 = (int)mylong;
Console.WriteLine(myInt2);

float myfloat = 123.123f;
myDouble = 13.2121321231231;
myfloat = (float)myDouble; 
Console.WriteLine(myfloat); 

Console.ReadKey();

// -------------------------------------------------------------------------------------------

//Conversion Helpers: Parse and Convert 
//we can parse a str into int if it's all numbers
string NumberString = "123";
int result = int.Parse(NumberString);

// we cal also use CONVERT (you can not convert value not the type to the type of data) 
string myBoolString = "true";
bool mybool = Convert.ToBoolean(myBoolString);
Console.WriteLine("myBool is " + mybool);
Console.ReadKey();

//--------------------------------------------------------------------------------------------

//Implicitely typed variabes
// var can be used to almost automatically determine the variable type 
var myFavoriteGenre = "LitRPGs";

var myFavoriteNumber = 14;

var yourFavoriteNumber = 13;

var ourNumbersCobined = myFavoriteNumber + yourFavoriteNumber;

Console.ReadKey();

//--------------------------------------------------------------------------------------------

//Operators and Order of Evaluation 
int num1 = 5;
int num2 = 13;

Console.WriteLine("addition num1 + num2 = " + (num1 + num2));

//This doesn't work because the first part has become a string and now we are subracting a int from a str
//we fix this by adding in brackets or through these means
Console.WriteLine($"subtraction {num1} - {num2} = " + (num1 - num2));
Console.WriteLine($"subtraction {num1} - {num2} = " + -8); 


Console.WriteLine($"multipication {num1} * {num2} = " + num1 * num2);
Console.WriteLine($"Division {num1} / {num2} = " + num1 / num2);
Console.ReadKey();

//--------------------------------------------------------------------------------------------


//char is a single character and is anything in the Utf-16 list (long list) 
// There's like smiley faces and many other things that are on the list that we can put in.
Char myFavoriteCharacter = '$';

//--------------------------------------------------------------------------------------------

//String formatting
// this says that where the {0} is add the first thing after the ',' and where the {1} is add te second thing after the ','
Console.WriteLine("the Number is {0}, and the second number is {1}", num1, num2 );  

//--------------------------------------------------------------------------------------------

//This will creat the message Hello and then World in a new line with a tab
string message = "Hello\n\tWorld!"; // Declare a string with special characters and escape sequences
Console.WriteLine(message); // Print the string to the console
Console.ReadKey();
