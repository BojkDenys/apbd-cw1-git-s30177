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

    public static int CalculateMax(int[] array)
    {
        int max = int.MinValue;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    public static int CalculateMin(int[] array)
    {
        int min = array.Min();
        return min;
    }
}