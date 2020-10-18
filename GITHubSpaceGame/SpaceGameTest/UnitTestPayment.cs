using GITHubSpaceGame;
using NUnit.Framework;

namespace SpaceGameTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPaymetGet()
        {
            var controller = new PaymentController();
            var result = controller.Index();
            Assert.IsNotNull(result);
            Assert.Pass();
        }
    }
}