using System.Collections.Generic;

namespace _40.FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                Fizz Buzz
                写一个程序，输出从 1 到 n 数字的字符串表示。

                1. 如果 n 是3的倍数，输出“Fizz”；

                2. 如果 n 是5的倍数，输出“Buzz”；

                3.如果 n 同时是3和5的倍数，输出 “FizzBuzz”。

                示例：

                n = 15,

                返回:
                [
                    "1",
                    "2",
                    "Fizz",
                    "4",
                    "Buzz",
                    "Fizz",
                    "7",
                    "8",
                    "Fizz",
                    "Buzz",
                    "11",
                    "Fizz",
                    "13",
                    "14",
                    "FizzBuzz"
                ]
                相关标签
                数学
                字符串
                模拟

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xngt85/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }

        public IList<string> FizzBuzz(int n)
        {
            var ss = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                ss.Add("" + i);

                if (i % 3 == 0)
                {
                    ss[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    ss[i - 1] = "Buzz";
                }
                if (i % 15 == 0)
                {
                    ss[i - 1] = "FizzBuzz";
                }
            }
            return ss;
        }
    }
}