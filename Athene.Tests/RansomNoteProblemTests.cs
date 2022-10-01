namespace Athene.Tests
{
    internal class RansomNoteProblemTests
    {
        [Test]
        public void CanConstruct_NotCoverageCheckSingleLetter()
        {
            var ransomNote = new RansomNoteProblem();
            var result = ransomNote.CanConstruct("a", "b");

            Assert.IsFalse(result);
        }

        [Test]
        public void CanConstruct_CoverageCheckSingleLetter()
        {
            var ransomNote = new RansomNoteProblem();
            var result = ransomNote.CanConstruct("a", "a");

            Assert.IsTrue(result);
        }

        [Test]
        public void CanConstruct_NotCoverageCheckAllLetters()
        {
            var ransomNote = new RansomNoteProblem();
            var result = ransomNote.CanConstruct("aa", "ab");

            Assert.IsFalse(result);
        }

        [Test]
        public void CanConstruct_CoverageCheckAllLetters()
        {
            var ransomNote = new RansomNoteProblem();
            var result = ransomNote.CanConstruct("aa", "aab");

            Assert.IsTrue(result);
        }
    }
}
