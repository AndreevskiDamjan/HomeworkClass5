Console.WriteLine("Input a string: ");
string inputString = Console.ReadLine();
string printString = inputString.Substring((inputString.Length - 5), 5);
Console.WriteLine($@"The last 5 characters of your string are: ""{printString}""");
