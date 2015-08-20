public class Statistics
{
    public void PrintStatistics(double[] measurements, int count)
    {
        double max = 0;
        for (int i = 0; i < count; i++)
        {
            if (measurements[i] > max)
            {
                max = measurements[i];
            }
        }

        PrintMax(max);

        double min = max;
        for (int i = 0; i < count; i++)
        {
            if (measurements[i] < min)
            {
                max = measurements[i];
            }
        }

        PrintMin(min);

        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += measurements[i];
        }

        PrintAvg(sum / count);
    }
}