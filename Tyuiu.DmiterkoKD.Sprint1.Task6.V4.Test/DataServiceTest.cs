using Tyuiu.DmiterkoKD.Sprint1.Task6.V4.Lib;
namespace Tyuiu.DmiterkoKD.Sprint1.Task6.V4.Test
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
            string st = "желанный праведник приветсвовать медленный";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(st);
            string wait = "желанный, медленный";
            Assert.AreEqual(wait, res);
        }
    }
}