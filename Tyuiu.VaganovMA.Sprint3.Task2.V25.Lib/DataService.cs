namespace Tyuiu.VaganovMA.Sprint3.Task2.V25.Lib;

using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task2V25
{
            //int value = 5;//n
            //int startValue = 1;//k
            //int stopValue = 13;
    public double GetSumSeries(int value, int startValue, int stopValue)
    {
        double SumSeries = 0;
        do
        {
            SumSeries = SumSeries + Math.Pow(4 / Math.Pow(startValue, value), 2);
            startValue++;
        }while (startValue <= stopValue) ;
        return Math.Round(SumSeries, 3);
    }
}
