using Application;

namespace TestProject
{
    public class CalculateTests
    {
        private Calculate _calculate;

        [SetUp]
        public void Setup()
        {
            _calculate = new Calculate();
        }

        [Test]
        public void TestCorrectSum()
        {
            int actual = _calculate.CorrectSum(1, 2, 3);

            int expected = 6;


            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestUnCorrectSum()
        {
            int actual = _calculate.UnCorrectSum(1, 2, 3);

            int expected = 6;


            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}