using System;
using System.Collections;
using System.Collections.Generic;

namespace _25.IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                回文链表
                请判断一个链表是否为回文链表。
                
                示例 1:
                
                输入: 1->2
                输出: false
                示例 2:
                
                输入: 1->2->2->1
                输出: true
                进阶：
                你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-   interview-     questions-   easy/xnv1oc/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }
        public static bool IsPalindrome(ListNode head)
        {

            ListNode node = head;
            Stack<int> stack = new Stack<int>();
            while (node != null)
            {
                stack.Push(node.val);
                node = node.next;
            }
            node = head;
            while (node != null)
            {
                if (stack.Peek() != node.val)
                {
                    return false;
                }
                stack.Pop();
                node = node.next;
            }
            return true;
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
