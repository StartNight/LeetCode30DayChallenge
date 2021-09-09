using System.Collections.Generic;

namespace _48.IsValid
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                有效的括号
                给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。

                有效字符串需满足：

                左括号必须用相同类型的右括号闭合。
                左括号必须以正确的顺序闭合。
                 

                示例 1：

                输入：s = "()"
                输出：true
                示例 2：

                输入：s = "()[]{}"
                输出：true
                示例 3：

                输入：s = "(]"
                输出：false
                示例 4：

                输入：s = "([)]"
                输出：false
                示例 5：

                输入：s = "{[]}"
                输出：true
                 

                提示：

                1 <= s.length <= 104
                s 仅由括号 '()[]{}' 组成
                相关标签
                栈
                字符串

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnbcaj/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }

        public bool IsValid(string s)
        {
            // 仅由括号 '()[]{}' 组成
            Stack<char> stack = new Stack<char>();
            char[] chars = s.ToCharArray();
            //遍历所有的元素
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                //如果是左括号，就把他们对应的右括号压栈
                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '{')
                {
                    stack.Push('}');
                }
                else if (c == '[')
                {
                    stack.Push(']');
                }
                else if (stack.Count == 0 || stack.Pop() != c)
                {
                    //否则就只能是右括号。
                    //1，如果栈为空，说明括号无法匹配。
                    //2，如果栈不为空，栈顶元素就要出栈，和这个右括号比较。
                    //如果栈顶元素不等于这个右括号，说明无法匹配，
                    //直接返回false。
                    return false;
                }
            }
            //最后如果栈为空，说明完全匹配，是有效的括号。
            //否则不完全匹配，就不是有效的括号
            return stack.Count == 0;
        }
    }
}