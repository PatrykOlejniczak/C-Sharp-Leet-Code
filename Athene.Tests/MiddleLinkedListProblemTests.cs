namespace Athene.Tests
{
    internal class MiddleLinkedListProblemTests
    {
        [Test]
        public void MiddleNode_CheckCorrectMiddleNodeOdd()
        {
            var fifthlistNode = new MiddleLinkedListProblem.ListNode(5);
            var fourthlistNode = new MiddleLinkedListProblem.ListNode(4, fifthlistNode);
            var thirdlistNode = new MiddleLinkedListProblem.ListNode(3, fourthlistNode);
            var secondlistNode = new MiddleLinkedListProblem.ListNode(2, thirdlistNode);
            var firstlistNode = new MiddleLinkedListProblem.ListNode(1, secondlistNode);

            var palindromeChecker = new MiddleLinkedListProblem();
            var result = palindromeChecker.MiddleNode(firstlistNode);

            Assert.That(3, Is.EqualTo(result.val));
        }

        [Test]
        public void MiddleNode_CheckCorrectMiddleNode()
        {
            var sixthlistNode = new MiddleLinkedListProblem.ListNode(6);
            var fifthlistNode = new MiddleLinkedListProblem.ListNode(5, sixthlistNode);
            var fourthlistNode = new MiddleLinkedListProblem.ListNode(4, fifthlistNode);
            var thirdlistNode = new MiddleLinkedListProblem.ListNode(3, fourthlistNode);
            var secondlistNode = new MiddleLinkedListProblem.ListNode(2, thirdlistNode);
            var firstlistNode = new MiddleLinkedListProblem.ListNode(1, secondlistNode);

            var middleNodeChecker = new MiddleLinkedListProblem();
            var result = middleNodeChecker.MiddleNode(firstlistNode);

            Assert.That(4, Is.EqualTo(result.val));
        }
    }
}
