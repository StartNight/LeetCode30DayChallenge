namespace _16.IsPalindrome
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                验证回文串
                给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。

                说明：本题中，我们将空字符串定义为有效的回文串。
                 

                示例 1:

                输入: "A man, a plan, a canal: Panama"
                输出: true
                解释："amanaplanacanalpanama" 是回文串
                示例 2:

                输入: "race a car"
                输出: false
                解释："raceacar" 不是回文串
                 

                提示：

                1 <= s.length <= 2 * 105
                字符串 s 由 ASCII 字符组成
                相关标签
                双指针
                字符串

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xne8id/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }

        private static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length;
            while (left < right)
            {
                //判断s[left]是否是字母或数字，不是则left++
                while (left < right && !((s[left] >= 'a' && s[left] <= 'z') || (s[left] >= 'A' && s[left] <= 'Z') || (s[left] >= '0' && s[left] <= '9')))
                    left++;
                //判断s[right]是否是字母或数字，不是则leftright
                while (left < right && !((s[right] >= 'a' && s[right] <= 'z') || (s[right] >= 'A' && s[right] <= 'Z') || (s[right] >= '0' && s[right] <= '9')))
                    right--;
                if (!(
                    s[left] == s[right] ||//判断是否相等
                    ((s[left] == s[right] + 32 || s[left] == s[right] - 32) &&//判断是否一个是大写一个是小写
                    !((s[right] >= '0' && s[right] <= '9') || (s[left] >= '0' && s[left] <= '9')))
                    ))
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}