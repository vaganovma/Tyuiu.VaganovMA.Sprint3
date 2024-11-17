using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.VaganovMA.Sprint3.Task5.V1.Lib;

public class DataService : ISprint3Task5V1
{
    public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
    {
        double SumSeries = 0;
        int i, k;
        for (i = startValue1; i <= stopValue1; i++)
        {
            for (k = startValue2; k <= stopValue2; k++)
            {
                SumSeries = SumSeries + 1 / (Math.Cos(startValue2)+x);
            }
        }
        return Math.Round(SumSeries, 3);
    }
} 
