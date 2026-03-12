namespace ConsoleApp1;

public class StatisticsHelper
{
    public static double CalculateAverage1(int[] array)
    {
        return array.Average();
    }
    public static double CalculateAverage(int[] array)
    {
        int sum = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }
}