using ConsoleApp1;

Console.WriteLine("Input numbers: ");
string input = Console.ReadLine();
try
{
    int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
    double average = StatisticsHelper.CalculateAverage(numbers);
    Console.WriteLine($"Average: {average}");
    int max = StatisticsHelper.CalculateMax(numbers);
    Console.WriteLine($"Max: {max}");
    int min = StatisticsHelper.CalculateMin(numbers);
    Console.WriteLine($"Min: {min}");
}
catch (FormatException)
{
    Console.WriteLine("Error, please try again");
    
}

