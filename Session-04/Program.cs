using Session_04;

//--------- 1 ---------
Console.WriteLine("Please enter a string: ");
string inputString = Console.ReadLine();

var reverser = new Class1();

reverser.ReverseString(inputString);

Console.WriteLine($"Reversed String: {reverser.ReverseString(inputString)}");


//--------- 2 ---------
Console.WriteLine("Please enter a positive integer: ");
inputString = Console.ReadLine();

int inputInt = Convert.ToInt32(inputString);

var calculator = new Class2();

Console.WriteLine($"Calculated sum(1...{inputInt}): {calculator.CalculateSum(inputInt)}\n" +
    $"Calculated product(1...{inputInt}): {calculator.CalculateProduct(inputInt)}");

//--------- 3 ---------
Console.WriteLine("Please enter a positive integer: ");
inputString = Console.ReadLine();

inputInt = Convert.ToInt32(inputString);

var primeCalculator = new Class3();

Console.WriteLine($"Prime numbers in range (1, {inputInt}): {primeCalculator.FindPrimeNumbers(inputInt)}");

