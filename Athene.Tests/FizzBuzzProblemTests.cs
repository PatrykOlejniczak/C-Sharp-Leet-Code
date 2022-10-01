namespace Athene.Tests
{
    internal class FizzBuzzProblemTests
    {
        [Test]
        public void FizzBuzz_DisplaySingleFizzTest()
        {
            var buzzer = new FizzBuzzProblem();
            var result = buzzer.FizzBuzz(3);

            var expected = new List<string>()
            {
                "1", "2", "Fizz"
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void FizzBuzz_DisplaySingleBuzzTest()
        {
            var buzzer = new FizzBuzzProblem();
            var result = buzzer.FizzBuzz(5);

            var expected = new List<string>()
            {
                "1", "2", "Fizz", "4", "Buzz"
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void FizzBuzz_DisplaySingleFizzBuzzTest()
        {
            var buzzer = new FizzBuzzProblem();
            var result = buzzer.FizzBuzz(15);

            var expected = new List<string>()
            {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
