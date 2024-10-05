using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TiasinIA.Sprint3.Task2.V20.Lib
{
    public class DataService : ISprint3Task2V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multseries = 1;

            do
            {

                {
                    multseries = multseries * Math.Pow((2 / (Math.Cos(1) + 0.5)), startValue);
                    startValue++;
                }

            } while (startValue <= stopValue);
            return Math.Round(multseries, 3);
        }
    }
}
