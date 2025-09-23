using Tyuiu.DolganovAV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.DolganovAV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1.0;
            double y1 = 4.0;
            double x2 = 8.0;
            double y2 = 8.0;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(8, res);
        }
    }
}
