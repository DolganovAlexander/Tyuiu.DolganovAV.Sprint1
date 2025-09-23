using Tyuiu.DolganovAV.Sprint1.Task4.V1.Lib;
namespace Tyuiu.DolganovAV.Sprint1.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(0.016, res);
        }
    }
}
