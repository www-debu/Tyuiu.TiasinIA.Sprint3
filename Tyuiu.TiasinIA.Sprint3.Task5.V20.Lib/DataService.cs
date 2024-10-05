﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TiasinIA.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    sumSeries = sumSeries + (Math.Pow(x / Math.Sin(5), j));
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
