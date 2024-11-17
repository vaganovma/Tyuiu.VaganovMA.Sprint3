using Tyuiu.VaganovMA.Sprint3.Task5.V1.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        DataService ds = new DataService();

        int x = 5;//x
        int startValue1 = 1;//i
        int stopValue1 = 3;
       
        int startValue2 = 1;//k
        int stopValue2 = 10;

        double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
        double wait = 6.3; //было 5.415;

        Assert.AreEqual(wait, res);
    }
}

