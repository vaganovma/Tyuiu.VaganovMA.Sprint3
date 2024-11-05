using Newtonsoft.Json.Linq;
using Tyuiu.VaganovMA.Sprint3.Task0.V10.Lib;
using System;
namespace Tyuiu.VaganovMA.Sprint3.Task0.V10.Test;
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
        double wait = 200;

        Assert.AreEqual(wait, res);
    }
} 