namespace Athene.Tests
{
    internal class ReduceNumberToZeroTests
    {
        [Test]
        public void NumberOfSteps_SampleOne()
        {
            var reducer = new ReduceNumberToZero();
            var result = reducer.NumberOfSteps(14);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void NumberOfSteps_SampleTwo()
        {
            var reducer = new ReduceNumberToZero();
            var result = reducer.NumberOfSteps(8);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void NumberOfSteps_SampleThree()
        {
            var reducer = new ReduceNumberToZero();
            var result = reducer.NumberOfSteps(123);

            Assert.That(result, Is.EqualTo(12));
        }
    }
}
