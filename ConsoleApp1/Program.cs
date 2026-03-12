using ConsoleApp1;

Console.WriteLine("Input numbers: ");
string input = Console.ReadLine();
try
{
    int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
    double average = StatisticsHelper.CalculateAverage(numbers);
    Console.WriteLine($"Average: {average}");
}
catch (FormatException)
{
    Console.WriteLine("Error, please try again");
    
}

