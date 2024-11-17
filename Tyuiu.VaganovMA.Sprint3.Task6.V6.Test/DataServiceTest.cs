using Tyuiu.VaganovMA.Sprint3.Task6.V6.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumTheDivisors()
    {
        DataService ds = new DataService();

        
        int startValue = 16;
        int stopValue = 24;
       
        int res = ds.GetSumTheDivisors(startValue, stopValue);
        int wait = 11; // 203; 

        Assert.AreEqual(wait, res);
    }
}