using Tyuiu.VaganovMA.Sprint3.Task2.V25.Lib; 
 
[TestClass] 
public class DataServiceTest 
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        DataService ds = new DataService();

        int value = 5;//n
        int startValue = 1;//k
        int stopValue = 13;

        double res = ds.GetSumSeries(value, startValue, stopValue);
        double wait = 16.016;

        Assert.AreEqual(wait, res);
    }
} 
