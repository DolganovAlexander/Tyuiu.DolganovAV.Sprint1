using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DolganovAV.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            int letterCount = value.Count(char.IsLetter);
            int charCount = value.Length - letterCount;
            return letterCount > charCount;
        }
    }
}
