using Tyuiu.DmiterkoKD.Sprint1.Task5.V1.Lib;
namespace Tyuiu.DmiterkoKD.Sprint1.Task5.V1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double x1 = 10;
            double y1 = 20;
            double x2 = 15;
            double y2 = 30;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int result = Convert.ToInt32(res);
            int wait = 11;
            Assert.AreEqual(wait, result);
        }
    }
}