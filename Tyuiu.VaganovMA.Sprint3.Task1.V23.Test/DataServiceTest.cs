using Tyuiu.VaganovMA.Sprint3.Task1.V23.Lib;
namespace Tyuiu.VaganovMA.Sprint3.Task1.V23.Test;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetMultiplySeries()
    {
        DataService ds = new DataService();

        int value = 5;
        int startValue = 1;
        int stopValue = 5;

        double res = ds.GetMultiplySeries(value, startValue, stopValue);
        double wait = 245.155;

        Assert.AreEqual(wait, res);
    }
}