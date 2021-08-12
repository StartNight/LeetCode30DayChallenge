using System;

namespace _22.RemoveNthFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                删除链表的倒数第N个节点
                给你一个链表，删除链表的倒数第 n 个结点，并且返回链表的头结点。
                
                进阶：你能尝试使用一趟扫描实现吗？
                
                 
                
                示例 1：
                
                
                输入：head = [1,2,3,4,5], n = 2
                输出：[1,2,3,5]
                示例 2：
                
                输入：head = [1], n = 1
                输出：[]
                示例 3：
                
                输入：head = [1,2], n = 1
                输出：[1]
                 
                
                提示：
                
                链表中结点的数目为 sz
                1 <= sz <= 30
                0 <= Node.val <= 100
                1 <= n <= sz
                相关标签
                链表
                双指针
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xn2925/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }
        // 通过双指针,位移的方式
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode fast = head;
            ListNode slow = head;
            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }
            if (fast == null)
            {
                return head.next;
            }
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return head;
        }



        public static ListNode RemoveNthFromEnd1(ListNode head, int n)
        {
            ListNode node = head;
            int length = 0;
            while (node.next != null)
            {
                length++;
                node = node.next;
            }

            node = head;
            if (length - n == 0)
                return head.next;

            int last = length - n - 1;

            for (int i = 0; i < last; i++)
            {
                node = node.next;
            }
            node.next = node.next.next;
            return head;
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
