using Tyuiu.VaganovMA.Sprint3.Task3.V21.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();

        

        double res = ds.GetSumSeries(value, startValue, stopValue);
        double wait = 16.016;

        Assert.AreEqual(wait, res);
    } 
} 
