using Tyuiu.DolganovAV.Sprint1.Task3.V17.Lib;
namespace Tyuiu.DolganovAV.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.502;
            bool check = true;
            var res = ds.ZeroCheck(x);
            Assert.AreEqual(check, res);
        }
    }
}
