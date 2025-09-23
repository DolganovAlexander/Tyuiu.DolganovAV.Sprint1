using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DolganovAV.Sprint1.Task7.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        public double Calculate(double x, double y)
        {
            var res = x - (Math.Cos(Math.Pow(x, 3)) / (x * y - 3)) + (Math.Sin(Math.Pow(x, 5)) / (x * y + 5));
            return Math.Round(res,3);
        }
    }
}
