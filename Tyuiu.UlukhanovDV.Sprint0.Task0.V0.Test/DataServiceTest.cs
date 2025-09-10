
using Tyuiu.UlukhanovDV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.UlukhanovDV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Джабраил";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Джабраил", res);
        }
    }
}
