using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TiasinIA.Sprint3.Task0.V9.Lib
{
    public class DataService : ISprint3Task0V9
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            
            for ( double i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + (Math.Pow(1 / (3 + Math.Pow(0.5, i)), i));
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
