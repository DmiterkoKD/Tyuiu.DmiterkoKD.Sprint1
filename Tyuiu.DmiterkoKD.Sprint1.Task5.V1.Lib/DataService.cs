using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DmiterkoKD.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            var x = (x2 - x1) * (x2 - x1);
            var y = (y2 - y1) * (y2 - y1);
            var d = Math.Sqrt(x + y);
            var k = Convert.ToInt32(d);
            return k;
        }
    }
}
