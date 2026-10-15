using Tyuiu.KvashninKA.Sprint2.Task2.V22.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task2.V22.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDoInShadedArea()
        {
            DataService ds = new DataService();

            int x = 3;
            int y = 3;
            
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void InvalidCheckDoInShadedArea()
        {
            DataService ds = new DataService();

            int x = 1;
            int y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);

        }
    }
}
