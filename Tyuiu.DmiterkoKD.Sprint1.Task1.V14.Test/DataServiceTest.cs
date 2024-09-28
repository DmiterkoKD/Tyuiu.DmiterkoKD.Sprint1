using Tyuiu.DmiterkoKD.Sprint1.Task1.V14.Lib;
namespace Tyuiu.DmiterkoKD.Sprint1.Task1.V14.Test
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
            DataService ds = new DataService();
            double a = 3.0;
            double b = 2.0;
            double c = 1.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(7, res);
        }
    }
}