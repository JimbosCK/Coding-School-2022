
//1
Console.WriteLine("Hello Dimitris!\n");

//2
Console.WriteLine("sum: " +  (2+3) + " Division: " + (2/(float)3) + "\n");

//3
Console.WriteLine(-1 + 5 * 6);
Console.WriteLine(38 + 5 % 7);
Console.WriteLine(14 + (-3 * 6)/(float)7 );
Console.WriteLine(2 + (13/(double)6)*6 + Math.Sqrt(7));
Console.WriteLine( (Math.Pow(6,4) + Math.Pow(5, 7)) / (float)(9 % 4) + "\n");

//4
ushort age = 25;
string gender = "male";
Console.WriteLine("You are " + gender + " and you look younger than " + age + ".\n");

//5
ulong totalSeconds = 31712463;
ulong years = (totalSeconds / (60 * 60 * 24 * 365));
ushort days = (ushort)((totalSeconds - (years * 60 * 60 * 24 * 365)) / (60 * 60 * 24));
ushort hours = (ushort)( (totalSeconds - (years * 60 * 60 * 24 * 365) - (ulong)(days * 60 * 60 * 24)) / (60 * 60 ));
ushort minutes = (ushort)( (totalSeconds - (ulong)(years * 60 * 60 * 24 * 365) - (ulong)(days * 60 * 60 * 24) - (ushort)(hours * 60 * 60) ) / 60);
uint remainingSeconds = (ushort) (totalSeconds - (ulong)(years * 60 * 60 * 24 * 365) - (ulong)(days * 60 * 60 * 24) - (ushort)(hours * 60 * 60) - (ushort)(minutes * 60) );

Console.WriteLine(totalSeconds + " seconds are: "  +  + years + " years, " + days + " days, " + hours + " hours, " + minutes + " minutes, " + remainingSeconds + " seconds.\n");

//6
TimeSpan t = TimeSpan.FromSeconds(totalSeconds);
years = (totalSeconds / (60 * 60 * 24 * 365));
string answerFromSeconds = string.Format("{0} years|{1} days|{2} hours|{3} minutes|{4} seconds.\n",
    years,
    t.Days,
    t.Hours,
    t.Minutes,
    t.Seconds);

Console.WriteLine(answerFromSeconds);

//7
float temperatureC = 36.6f;
float temperatureK = temperatureC + 273.15f;
float temperatureF = (temperatureC * 9) / 5 + 32;


string temperatureConversion = string.Format("{0} Celsius = {1} Kelvin = {2} Fahrenheit.",
    temperatureC,
    temperatureK,
    temperatureF);

Console.WriteLine(temperatureConversion);
