using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DmiterkoKD.Sprint1.Task7.V19.Lib
{
    public class DataService : ISprint1Task7V19
    {
        public double Calculate(double x)
        {
            var m2 = Math.Pow(x, 2);
            var m3 = Math.Pow(x, 3);
            var m4 = Math.Pow(x, 4);
            var m5 = Math.Pow(x, 5);
            var z = x - ((7 * m2)/m3) + Math.Sin(x) + Math.Abs(m4 - m5);

            var res = Math.Round(z, 3);
            return res;
        }
    }
}
