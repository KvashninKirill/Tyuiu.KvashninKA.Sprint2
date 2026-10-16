
using Tyuiu.KvashninKA.Sprint2.Task4.V4.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task4.V4.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = Math.Round(Math.Sin(1) + 2 * 5, 3);
            Assert.AreEqual(wait, res, 0.001);

        }

        [TestMethod]
        public void ValidCalculateCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = Math.Round(Math.Cos(1) + 2 * 5 * 1, 3);
            Assert.AreEqual(wait, res, 0.001);

        }
    }
}
