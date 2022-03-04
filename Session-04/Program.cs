using Session_04;

//--------- 1 ---------
Console.WriteLine("Please enter a string: ");
string inputString = Console.ReadLine();

var reverser = new Class1();

reverser.ReverseString(inputString);

Console.WriteLine($"Reversed String: {reverser.ReverseString(inputString)}");


//--------- 2 ---------
Console.WriteLine("Please enter a string: ");
inputString = Console.ReadLine();

int inputInt = Convert.ToInt32(inputString);

var calculator = new Class2();

Console.WriteLine($"Calculated sum: {calculator.CalculateSum(inputInt)}\n" +
    $"Calculated product: {calculator.CalculateProduct(inputInt)}");
