namespace Athene.Tests
{
    internal class PalindromeLinkedListTests
    {
        [Test]
        public void IsPalindrone_CheckCorrectPalindrome()
        {
            var fourthlistNode = new PalindromeLinkedListProblem.ListNode(1);
            var thirdlistNode = new PalindromeLinkedListProblem.ListNode(2, fourthlistNode);
            var secondlistNode = new PalindromeLinkedListProblem.ListNode(2, thirdlistNode);
            var firstlistNode = new PalindromeLinkedListProblem.ListNode(1, secondlistNode);

            var palindromeChecker = new PalindromeLinkedListProblem();
            var result = palindromeChecker.IsPalindrome(firstlistNode);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrone_CheckIncorrectPalindrome()
        {
            var secondlistNode = new PalindromeLinkedListProblem.ListNode(2);
            var firstlistNode = new PalindromeLinkedListProblem.ListNode(1, secondlistNode);

            var palindromeChecker = new PalindromeLinkedListProblem();
            var result = palindromeChecker.IsPalindrome(firstlistNode);

            Assert.IsFalse(result);
        }
    }
}
