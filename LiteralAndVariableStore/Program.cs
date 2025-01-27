
Console.WriteLine('b'); //char literal
Console.WriteLine(123); // int data type
Console.WriteLine(0.25F); // flaot data type
Console.WriteLine(2.625); // double data type
Console.WriteLine(12.39816m); // decimal data type
Console.WriteLine(true); // boolean data type
Console.WriteLine(false); // boolean data type

//it's only the displayed output that appears to be similar.
Console.WriteLine("123");
Console.WriteLine(123);


string firstName; //declare variables 
firstName = "Bob"; //assign value to variable
Console.WriteLine(firstName); //display value of variable

// reuse and reassign the variable as many times as you want
firstName = "Liem";
Console.WriteLine(firstName);

//implicitly typed local variable
var message = "Hello world!";

//challenge 
string personName = "Bob";
int messages = 3;
float temp = 34.4F;

Console.Write("Hello, " + personName + "! You have " + messages + " messages in your inbox.");
Console.Write(" The temperature is " + temp + " celsius.");
