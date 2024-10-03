using Tyuiu.DmiterkoKD.Sprint1.Task7.V19.Lib;
namespace Tyuiu.DmiterkoKD.Sprint1.Task7.V19.Test
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
            double x = 2;
            
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            double wait = 15.409;
            Assert.AreEqual(wait, res);
        }
    }
}