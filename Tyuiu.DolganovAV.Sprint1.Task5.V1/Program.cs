using Tyuiu.DolganovAV.Sprint1.Task5.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Долганов А. В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Долганов Александр Витальевич | ПИНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет расстояние между двумя точками и печатает результат на экране *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x1,x2,y1,y2;
        Console.WriteLine("Введите координаты первой точки: ");
        Console.Write("x1 = ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1 = ");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координаты второй точки: ");
        Console.Write("x2 = ");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2 = ");
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.DistanceBetweenDots(x1, y1, x2, y2));
        Console.ReadLine();
    }
}