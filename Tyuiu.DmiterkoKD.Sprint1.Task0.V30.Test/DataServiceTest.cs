using Tyuiu.DmiterkoKD.Sprint1.Task0.V30.Lib;
namespace Tyuiu.DmiterkoKD.Sprint1.Task0.V30.Test
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
            var res = ds.Calculate();
            Assert.AreEqual(96, res);
        }
    }
}