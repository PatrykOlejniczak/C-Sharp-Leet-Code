namespace Athene
{
    public class PalindromeLinkedListProblem
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public bool IsPalindrome(ListNode head)
        {
            var stack = new Stack<int>();

            var currentHead = head;
            while (currentHead != null)
            {
                stack.Push(currentHead.val);
                currentHead = currentHead.next;
            }

            stack.Reverse();

            currentHead = head;
            while (currentHead != null)
            {
                if (currentHead.val != stack.Pop())
                    return false;

                currentHead = currentHead.next;
            }

            return true;
        }
    }
}
