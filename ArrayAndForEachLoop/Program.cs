
//declare array that holds 5 elements
string[] studentNames = new string[5];

//initialize array elements

studentNames[0] = "Sarmad";
studentNames[1] = "Ali";
studentNames[2] = "Jalbani";
studentNames[3] = "Uzair";
studentNames[4] = "Ahmed";

//studentNames[5] = "Shahzad";

Console.WriteLine("First Student Name: " + studentNames[0]);
Console.WriteLine("Second Student Name: " + studentNames[1]);
Console.WriteLine("Third Student Name: " + studentNames[2]);
Console.WriteLine("Four Student Name: " + studentNames[3]);
Console.WriteLine("Five Student Name: " + studentNames[4]);

//re assign value to array element

studentNames[0] = "First Shahzad";
Console.WriteLine($"Re-assigned Student Name: {studentNames[0]}");

//now declare array and initialize it in single statement

string[] newStudents = [ "Sarmad", "Ali", "Jalbani", "Uzair", "Ahmed" ];
Console.WriteLine($"First Student Name: {newStudents[0]}");
Console.WriteLine($"Second Student Name: {newStudents[1]}");
Console.WriteLine($"Third Student Name: {newStudents[2]}");
Console.WriteLine($"Four Student Name: {newStudents[3]}");
Console.WriteLine($"Five Student Name: {newStudents[4]}");


//for each loop

foreach(string names in newStudents)
{
    Console.WriteLine($"Student Name: {names}");
}

// int array 

int[] studentIds = { 12, 13, 14, 15, 16 };
int sum = 0;
foreach (int items in studentIds)
{
    sum =+items;
    Console.WriteLine($"Student Id: {items}");
}

Console.WriteLine($"Sum of Student Ids: {sum}");

//challenege
string[] challengeArray = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach(string items in challengeArray)
{
    if (items.StartsWith("B"))
    {
        Console.WriteLine("Starts with B: " + items);
    }
}


