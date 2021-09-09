using System;
using System.Collections.Generic;

namespace _15.IsAnagram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                有效的字母异位词
                给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的字母异位词。

                注意：若 s 和 t 中每个字符出现的次数都相同，则称 s 和 t 互为字母异位词。

                 

                示例 1:

                输入: s = "anagram", t = "nagaram"
                输出: true
                示例 2:

                输入: s = "rat", t = "car"
                输出: false
                 

                提示:

                1 <= s.length, t.length <= 5 * 104
                s 和 t 仅包含小写字母
                 

                进阶: 如果输入字符串包含 unicode 字符怎么办？你能否调整你的解法来应对这种情况？

                相关标签
                哈希表
                字符串
                排序

                C#

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xn96us/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
            var r = IsAnagram("acacbac", "bbbbbac");
            Console.WriteLine(r);
        }

        private static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> kv = new Dictionary<char, int>();
            if (s.Length != t.Length) return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (kv.ContainsKey(s[i]))
                {
                    kv[s[i]] += 1;
                }
                else
                {
                    kv.Add(s[i], 1);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (kv.ContainsKey(t[i]))
                {
                    kv[t[i]] -= 1;
                }
                else
                {
                    kv.Add(t[i], 1);
                }
            }
            foreach (var item in kv)
            {
                if (item.Value != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}