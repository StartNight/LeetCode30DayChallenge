namespace _23.ReverseList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                反转链表
                给你单链表的头节点 head ，请你反转链表，并返回反转后的链表。
                 

                示例 1：

                输入：head = [1,2,3,4,5]
                输出：[5,4,3,2,1]
                示例 2：

                输入：head = [1,2]
                输出：[2,1]
                示例 3：

                输入：head = []
                输出：[]
                 

                提示：

                链表中节点的数目范围是 [0, 5000]
                -5000 <= Node.val <= 5000
                 

                进阶：链表可以选用迭代或递归方式完成反转。你能否用两种方法解决这道题？

                相关标签
                递归
                链表

                C#

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnnhm6/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            //保存当前节点的下一个结点
            ListNode next = head.next;
            //从当前节点的下一个结点开始递归调用
            ListNode reverse = ReverseList(next);
            //reverse是反转之后的链表，因为函数reverseList
            // 表示的是对链表的反转，所以反转完之后next肯定
            // 是链表reverse的尾结点，然后我们再把当前节点
            //head挂到next节点的后面就完成了链表的反转。
            head.next.next = head;
            head.next = null;
            return reverse;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}