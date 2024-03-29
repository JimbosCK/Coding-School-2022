﻿using Session_04;

//--------- 1 ---------
Console.WriteLine("-1-\nPlease enter a string: ");
string inputString = Console.ReadLine();

var reverser = new Class1();

reverser.ReverseString(inputString);

Console.WriteLine($"Reversed String: {reverser.ReverseString(inputString)}\n");


//--------- 2 ---------
Console.WriteLine("-2-\nPlease enter a positive integer: ");
inputString = Console.ReadLine();

int inputInt;
try
{
    inputInt = Convert.ToInt32(inputString);
}
catch (System.FormatException)
{
    inputInt = 0;
    Console.WriteLine("Error!: Not an integer received.\n");
}


var calculator = new Class2();

Console.WriteLine($"Calculated sum(1...{inputInt}): {calculator.CalculateSum(inputInt)}\n" +
    $"Calculated product(1...{inputInt}): {calculator.CalculateProduct(inputInt)}\n");

//--------- 3 ---------
Console.WriteLine("-3-\nPlease enter a positive integer: ");


inputString = Console.ReadLine();
try
{
    inputInt = Convert.ToInt32(inputString);
}
catch (System.FormatException)
{
    inputInt = 0;
    Console.WriteLine("Error!: Not an integer received.\n");
}


var primeCalculator = new Class3();

Console.WriteLine($"Prime numbers in range (1, {inputInt}): {primeCalculator.FindPrimeNumbers(inputInt)}\n\n-4-");


//--------- 4 ---------
int[] Array1 = new int[4] { 2, 4, 9, 12 };
int[] Array2 = new int[4] { 1, 3, 7, 10 };
int[] resultArray = new int[16];
var arrayMultiplicator = new Class4();

resultArray = arrayMultiplicator.Multiply2_4(Array1, Array2);

for (int i = 0; i < 16; i++){
    Console.Write(resultArray[i] + ", ");
}

//--------- 5 ---------
int[] Array = {0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
var sorter = new Class5();

int[] resultArray1 = new int[Array.Length];
resultArray1 = sorter.SortInsertion(Array);

Console.WriteLine("\n\n-5-");

for (int i = 1; i < resultArray1.Length; ++i)
{
    Console.Write(resultArray1[i] + ", ");
}