namespace Tyuiu.VaganovMA.Sprint3.Task0.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task0V10
{
    public double GetMultiplySeries(int value, int startValue, int stopValue)
    {
        //double sumSeries = 0;
        //int i;
        //for (i = startValue; i < stopValue; i++)
        //{
        //    sumSeries = sumSeries + Math.Pow(300 / (startValue + Math.Pow(value, startValue)), startValue);
        //}
        //return Math.Round(sumSeries, 3);
        double multSeries = 1;
        while (startValue <= stopValue)
        {
            multSeries = multSeries + Math.Pow((300 / (startValue + Math.Pow(value, startValue))), startValue);
            startValue++;
        }
        return Math.Round(multSeries, 3);
    }
}
