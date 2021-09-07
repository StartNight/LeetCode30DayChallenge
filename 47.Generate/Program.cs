using System;
using System.Collections.Generic;

namespace _47.Generate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                杨辉三角
                给定一个非负整数 numRows，生成「杨辉三角」的前 numRows 行。
                
                在「杨辉三角」中，每个数是它左上方和右上方的数的和。
                
                
                示例 1:
                
                输入: numRows = 5
                输出: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
                示例 2:
                
                输入: numRows = 1
                输出: [[1]]
                 
                
                提示:
                
                1 <= numRows <= 30
                相关标签
                数组
                动态规划
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xncfnv/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }

        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();

            IList<int> temp = new List<int>();
            temp.Add(1);
            res.Add(temp);

            for (int i = 1; i < numRows; i++)
            {
                temp = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        temp.Add(1);
                    }
                    else
                    {
                        temp.Add(res[i - 1][j - 1] + res[i - 1][j]);
                    }

                }
                res.Add(temp);
            }
            return res;

        }
    }
}
