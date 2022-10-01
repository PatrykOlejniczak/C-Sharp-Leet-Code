namespace Athene.Tests
{
    internal class RomanToIntegerTests
    {
        [Test]
        public void CheckSingleCharacterTransformation()
        {
            var romanToInteger = new RomanToInteger();
            var result = romanToInteger.RomanToInt("I");

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void CheckOnlySubstractTransformation()
        {
            var romanToInteger = new RomanToInteger();
            var result = romanToInteger.RomanToInt("IV");

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void CheckMiddleSubstractTransformation()
        {
            var romanToInteger = new RomanToInteger();
            var result = romanToInteger.RomanToInt("XIV");

            Assert.That(result, Is.EqualTo(14));
        }

        [Test]
        public void CheckMultipleSameCharacterTransformation()
        {
            var romanToInteger = new RomanToInteger();
            var result = romanToInteger.RomanToInt("III");

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void CheckMultipleDifferentCharacterSmallTransformation()
        {
            var romanToInteger = new RomanToInteger();
            var result = romanToInteger.RomanToInt("LVIII");

            Assert.That(result, Is.EqualTo(58));
        }

        [Test]
        public void CheckMultipleDifferentCharacterLargeTransformation()
        {
            var romanToInteger = new RomanToInteger();
            var result = romanToInteger.RomanToInt("MCMXCIV");

            Assert.That(result, Is.EqualTo(1994));
        }
    }
}
