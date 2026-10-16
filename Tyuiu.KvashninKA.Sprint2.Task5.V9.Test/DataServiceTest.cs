
using Tyuiu.KvashninKA.Sprint2.Task5.V9.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task5.V9.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int m = 5;
            int n = 15;
            string res = ds.FindDateOfNextDay(m, n);
            Assert.AreEqual("16.5", res);

            int m2 = 3;
            int n2 = 31;
            string res2 = ds.FindDateOfNextDay(m2, n2);
            Assert.AreEqual("1.4", res2);

        }
    }
}