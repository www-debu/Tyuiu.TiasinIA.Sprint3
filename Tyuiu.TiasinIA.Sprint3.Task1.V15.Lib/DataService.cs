﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TiasinIA.Sprint3.Task1.V15.Lib
{
    public class DataService : ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multseries = 1;

            while (startValue <= stopValue)
            {
                multseries = multseries * ((Math.Pow(2, 2) * startValue) + 1);
                startValue++;
            }
            return Math.Round(multseries, 3);
        }
    }
}
