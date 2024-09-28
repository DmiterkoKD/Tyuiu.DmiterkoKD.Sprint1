using Tyuiu.DmiterkoKD.Sprint1.Task2.V11.Lib;
namespace Tyuiu.DmiterkoKD.Sprint1.Task2.V11.Test
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
            int chas = 5;
            int min = 20;
            var res = ds.ConvertHoursMinutesToSeconds(chas, min);
            Assert.AreEqual(19200, res);
        }
    }
}