using System.Diagnostics.Tracing;

Console.WriteLine("Input a sentence: ");
string sentence = Console.ReadLine();
string[] splits = sentence.Split(" ");
foreach(string word in splits)
{
    Console.WriteLine(word);
}
