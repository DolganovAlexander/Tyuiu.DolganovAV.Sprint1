using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DolganovAV.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            return Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(r, 3), 3);
        }
    }
}
