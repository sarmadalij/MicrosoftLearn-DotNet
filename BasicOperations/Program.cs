
// add two numeric values
using System.ComponentModel;
int result = 3 + 1 * 5 / 2;
Console.WriteLine(result+"Windows "+1+1);
Console.WriteLine(5 / 10);

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//Mix data types to force implicit type conversions
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

//odify the code you wrote to match the following code:
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

//addition, subtraction, multiplication, and division with integers
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//perform division using literal decimal data
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;
//cast int to decimal, you add the cast operator before the value.
//You use the name of the data type surrounded by parentheses in front of the value to cast it.
//In this case, you would add (decimal) before the variables first and second.
decimal quotientt = (decimal)first / (decimal)second;
Console.WriteLine(quotientt);

//determine the remainder after integer division
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//Order of operations
//In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:
//1:Parentheses(whatever is inside the parenthesis is performed first)
//2:Exponents
//3:Multiplication and Division (from left to right)
//4:Addition and Subtraction (from left to right)

//code to exercise C#'s order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);


//Increment and decrement
int value3 = 0;     // value is now 0.
value3 = value3 + 5; // value is now 5.
value3 += 5;        // value is now 10.

//code to increment and decrement a value

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);


//challenge
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5m / 9);
Console.WriteLine(celsius);