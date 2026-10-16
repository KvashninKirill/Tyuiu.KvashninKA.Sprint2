
using Tyuiu.KvashninKA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task6.V11.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 5;
            int n = 15;
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual("16.05.2023", res);

        }
    }
}