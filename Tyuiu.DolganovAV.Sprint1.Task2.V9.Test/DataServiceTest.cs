using Tyuiu.DolganovAV.Sprint1.Task2.V9.Lib;
namespace Tyuiu.DolganovAV.Sprint1.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 5;
            var res = ds.CalculateVolumeCircle(r);
            Assert.AreEqual(523.599, res);
        }
    }
}
