using Tyuiu.KvashninKA.Sprint2.Task7.V1.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task7.V1.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDoInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);

        }
    }
}