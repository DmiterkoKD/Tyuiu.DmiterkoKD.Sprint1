using Tyuiu.DmiterkoKD.Sprint1.Task4.V11.Lib;
namespace Tyuiu.DmiterkoKD.Sprint1.Task4.V11.Test
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
            var x = 0.5;
            var y = 2.0;
            var wait = 0.063;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}