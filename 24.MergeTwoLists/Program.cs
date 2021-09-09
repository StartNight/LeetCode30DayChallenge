namespace _24.MergeTwoLists
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                合并两个有序链表
                将两个升序链表合并为一个新的 升序 链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

                示例 1：

                输入：l1 = [1,2,4], l2 = [1,3,4]
                输出：[1,1,2,3,4,4]
                示例 2：

                输入：l1 = [], l2 = []
                输出：[]
                示例 3：

                输入：l1 = [], l2 = [0]
                输出：[0]
                 

                提示：

                两个链表的节点数目范围是 [0, 50]
                -100 <= Node.val <= 100
                l1 和 l2 均按 非递减顺序 排列
                相关标签
                递归
                链表

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnnbp2/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
            */
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    curr.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    curr.next = l2;
                    l2 = l2.next;
                }
                curr = curr.next;
            }
            curr.next = l1 == null ? l2 : l1;
            return dummy.next;
        }

        // 递归
        public ListNode mergeTwoLists(ListNode linked1, ListNode linked2)
        {
            //只要有一个为空，就返回另一个
            if (linked1 == null || linked2 == null)
                return linked2 == null ? linked1 : linked2;
            //把小的赋值给first
            ListNode first = (linked2.val < linked1.val) ? linked2 : linked1;
            first.next = mergeTwoLists(first.next, first == linked1 ? linked2 : linked1);
            return first;
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