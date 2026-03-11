using ConsoleApp1;

Console.WriteLine("Input numbers: ");
string input = Console.ReadLine();
int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
double average = StatisticsHelper.CalculateAverage(numbers);
Console.WriteLine($"Average: {average}");
