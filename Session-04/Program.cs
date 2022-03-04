using Session_04;

//--------- 1 ---------
Console.WriteLine("Please enter a string: ");
string inputString = Console.ReadLine();

var reverser = new Class1();

reverser.ReverseString(inputString);

Console.WriteLine($"Reversed String: {reverser.ReverseString(inputString)}");



