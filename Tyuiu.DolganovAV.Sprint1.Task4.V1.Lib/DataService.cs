﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DolganovAV.Sprint1.Task4.V1.Lib
{
    public class DataService : ISprint1Task4V1
    {
        public double Calculate(double x)
        {
            return Math.Round(1 / Math.Pow((x + 2), 2), 3);
        }
    }
}
