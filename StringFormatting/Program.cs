
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hello\nWorld!"); //escape character sequences to add newlines
Console.WriteLine("Hello\tWorld!"); //escape character sequences to add tabs

Console.WriteLine("Hello \"World\"!"); //insert a double-quotation mark in a literal string

Console.WriteLine("c:\\source\\repos"); //use the \\ to display a single backslash.

//A verbatim string literal will keep all whitespace and characters without the need to escape the backslash.
//    To create a verbatim string, use the @ directive before the literal string.

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

//Unicode escape characters
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");



//To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

//To concatenate two strings together, you use the string concatenation operator, which is the plus symbol +.
string firstName = "Bob";
string greeting = "Hello";
//string message = "Hello " + firstName;
//string messageAll = greeting + " " + firstName + "!";

//Console.WriteLine(message);
//Console.WriteLine(messageAll);

Console.WriteLine(greeting + " " + firstName + "!");

//String interpolation combines multiple values into a single literal string by using a "template" and one or more interpolation expressions.   
string message = $"Hello {firstName}!";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
string messageUpdated = $"{updateText} {version}";
Console.WriteLine(messageUpdated);

//Combine verbatim literals and string interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//challenge
string projectNames = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output:\n\t" + $@"C:\Exercise\{projectName}\data.txt");
Console.WriteLine(russianMessage + ":\n\t" + $@"C:\Exercise\{projectName}\ru-RU\data.txt");