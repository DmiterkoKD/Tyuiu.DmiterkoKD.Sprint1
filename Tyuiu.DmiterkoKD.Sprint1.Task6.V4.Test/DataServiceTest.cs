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
            string st = "�������� ��������� ������������� ���������";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(st);
            string wait = "��������, ���������";
            Assert.AreEqual(wait, res);
        }
    }
}