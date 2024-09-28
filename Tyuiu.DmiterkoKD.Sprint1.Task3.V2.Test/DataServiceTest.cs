using Tyuiu.DmiterkoKD.Sprint1.Task3.V2.Lib;
namespace Tyuiu.DmiterkoKD.Sprint1.Task3.V2.Test
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
            double priceNotebook = 7.12;
            int amountNotebook = 5;
            double pricePencil = 3.05;
            int amountPencil = 8;
            double wait = priceNotebook * amountNotebook + pricePencil * amountPencil;
            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(wait, res);

            
        }
    }
}