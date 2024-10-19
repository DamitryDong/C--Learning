
//to use a word usually used to write codes in a sentence, you'd need to use \ \ like this orelse it will error 
// if you use \\ this will show as just \
// of you use \n this will move the text down one line
using System.ComponentModel.DataAnnotations;

string s1 = "this is a \"string\" with \na backslash \\ and a colon: ";
Console.WriteLine(s1); 
Console.ReadKey();

// arrays 
int[] ArrayName = { 1, 2, 3, 4, 5, 6 }; // Array of any size
string[] ArrayName2 = new string[3] { "hi", "Hello", "Bye" }; //Expects 3 values

Console.WriteLine(ArrayName);
Console.WriteLine(ArrayName2);
Console.ReadKey();

