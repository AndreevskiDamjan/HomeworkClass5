int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthday.Year;
    if (today.Month < birthday.Month || (today.Month == birthday.Month && today.Day < birthday.Day))
    {
        age--;
    }

    return age;
}
Console.Write("Enter your birthday date (MM/dd/yyyy): ");
DateTime birthday = DateTime.Parse(Console.ReadLine());
int age = AgeCalculator(birthday);
Console.WriteLine($"Your age is {age}");

