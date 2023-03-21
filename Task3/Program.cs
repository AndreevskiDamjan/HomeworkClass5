int SumDigits()
{
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;
    while (num > 0)
    {
        int number = num % 10;
        sum += number;
        num /= 10;
    }
    return sum;
}
int digitSum = SumDigits();
Console.WriteLine($"The sum of digits is {digitSum}");
