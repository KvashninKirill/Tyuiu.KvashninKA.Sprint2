
using Tyuiu.KvashninKA.Sprint2.Task3.V18.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task3.V18.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 36;
            Assert.AreEqual(wait, res, 0.001);

        }

        [TestMethod]
        public void ValidCalculateCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res, 0.001);

        }
    }
}
