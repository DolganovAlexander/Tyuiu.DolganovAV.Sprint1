using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DolganovAV.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            var num1 = (int)(number * 10) % 10;
            var num2 = (int)(number * 100) % 10;
            var num3 = (int)(number * 1000) % 10;
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
