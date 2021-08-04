using System;
using System.Collections.Generic;
using System.IO;
namespace _14.FirstUniqChar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。

                示例：
                
                s = "leetcode"
                返回 0
                
                s = "loveleetcode"
                返回 2
                 
                
                提示：你可以假定该字符串只包含小写字母。
                
                相关标签
                队列
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xn5z8r/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
            FirstUniqChar("leetcode");
        }
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, bool> kv = new Dictionary<char, bool>();
            for (int i = 0; i < s.Length; i++)
            {
                if (kv.ContainsKey(s[i]))
                {
                    kv[s[i]] = true;
                }
                else
                {
                    kv.Add(s[i], false);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (kv[s[i]]==false)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
