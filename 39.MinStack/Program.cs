using System;

namespace _39.MinStack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                最小栈
                设计一个支持 push ，pop ，top 操作，并能在常数时间内检索到最小元素的栈。

                push(x) —— 将元素 x 推入栈中。
                pop() —— 删除栈顶的元素。
                top() —— 获取栈顶元素。
                getMin() —— 检索栈中的最小元素。
                 

                示例:

                输入：
                ["MinStack","push","push","push","getMin","pop","top","getMin"]
                [[],[-2],[0],[-3],[],[],[],[]]

                输出：
                [null,null,null,null,-3,null,0,-2]
                解释：
                MinStack minStack = new MinStack();
                minStack.push(-2);
                minStack.push(0);
                minStack.push(-3);
                minStack.getMin();   --> 返回 -3.
                minStack.pop();
                minStack.top();      --> 返回 0.
                minStack.getMin();   --> 返回 -2.
                 

                提示：

                pop、top 和 getMin 操作总是在 非空栈 上调用。

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnkq37/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }
    }

    public class MinStack
    {
        //链表头，相当于栈顶
        private ListNode head;

        /** initialize your data structure here. */

        public MinStack()
        {
        }

        //压栈，需要判断栈是否为空
        public void Push(int x)
        {
            if (Empty())
                head = new ListNode(x, x, null);
            else
                head = new ListNode(x, Math.Min(x, head.min), head);
        }

        //出栈，相当于把链表头删除
        public void Pop()
        {
            if (Empty())
                throw new Exception("栈为空……");
            head = head.next;
        }

        //栈顶的值也就是链表头的值
        public int Top()
        {
            if (Empty())
                throw new Exception("栈为空……");
            return head.val;
        }

        //链表中头结点保存的是整个链表最小的值，所以返回head.min也就是
        //相当于返回栈中最小的值
        public int GetMin()
        {
            if (Empty())
                throw new Exception("栈为空……");
            return head.min;
        }

        //判断栈是否为空
        private bool Empty()
        {
            return head == null;
        }
    }

    internal class ListNode
    {
        public int val;
        public int min;//最小值
        public ListNode next;

        public ListNode(int val, int min, ListNode next)
        {
            this.val = val;
            this.min = min;
            this.next = next;
        }
    }
}