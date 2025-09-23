using Tyuiu.DolganovAV.Sprint1.Task7.V29.Lib;

namespace Tyuiu.DolganovAV.Sprint1.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 4.0;
            Assert.AreEqual(4.985, ds.Calculate(x, y));
        }
    }
}
