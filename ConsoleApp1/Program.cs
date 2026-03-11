Console.WriteLine("Input numbers: ");
string input = Console.ReadLine();
int[] numbers = input.Split(' ').Select(int.Parse).ToArray();