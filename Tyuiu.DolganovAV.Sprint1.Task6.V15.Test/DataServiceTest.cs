using Tyuiu.DolganovAV.Sprint1.Task6.V15.Lib;
namespace Tyuiu.DolganovAV.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Hello, World!";
            Assert.AreEqual(true, ds.CheckLettersCount(value));
        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds =new DataService();
            string value = "Hello!!!!!!!!!!!!!!!!!";
            Assert.AreEqual(false, ds.CheckLettersCount(value));
        }
    }
}
