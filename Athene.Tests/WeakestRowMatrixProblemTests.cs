namespace Athene.Tests
{
    internal class WeakestRowMatrixProblemTests
    {
        [Test]
        public void KWeakestRows_SecondCheckWeakestRow()
        {
            var input = new int[][]
            {
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 },
            };
            var expected = new int[] { 2, 0, 3 };

            var rowChecker = new WeakestRowMatrixProblem();
            var result = rowChecker.KWeakestRows(input, 3);
            
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void KWeakestRows_FirstCheckWeakestRow()
        {
            var input = new int[][]
            {
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 1, 0, 0 },
            };
            var expected = new int[] { 0, 2 };

            var rowChecker = new WeakestRowMatrixProblem();
            var result = rowChecker.KWeakestRows(input, 2);

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
