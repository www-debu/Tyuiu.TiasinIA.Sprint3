using Tyuiu.TiasinIA.Sprint3.Task0.V9.Lib;

namespace Tyuiu.TiasinIA.Sprint3.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 56.552;

            Assert.AreEqual(res, wait);
        }
    }
}