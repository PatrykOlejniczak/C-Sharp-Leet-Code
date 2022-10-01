namespace Athene
{
    public class MiddleLinkedListProblem
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

        public ListNode MiddleNode(ListNode head)
        {
            var mid = head;
            var count = 0;
            while (head != null)
            {
                if ((count % 2) == 1)
                    mid = mid.next;

                ++count;
                head = head.next;
            }

            return mid;
        }
    }
}
