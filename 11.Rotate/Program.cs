using System;

namespace _11.Rotate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                旋转图像
                给定一个 n × n 的二维矩阵 matrix 表示一个图像。请你将图像顺时针旋转 90 度。

                你必须在 原地 旋转图像，这意味着你需要直接修改输入的二维矩阵。请不要 使用另一个矩阵来旋转图像。

                 

                示例 1：

                输入：matrix = [[1,2,3],[4,5,6],[7,8,9]]
                输出：[[7,4,1],[8,5,2],[9,6,3]]
                示例 2：

                输入：matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
                输出：[[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
                示例 3：

                输入：matrix = [[1]]
                输出：[[1]]
                示例 4：

                输入：matrix = [[1,2],[3,4]]
                输出：[[3,1],[4,2]]
                 

                提示：

                matrix.length == n
                matrix[i].length == n
                1 <= n <= 20
                -1000 <= matrix[i][j] <= 1000
                相关标签
                数组
                数学
                矩阵

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnhhkv/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
            int[][] s = new int[2][];
            s[0] = new int[3];
            s[1] = new int[3];
            Console.WriteLine(s.Length);
        }

        public static void rotate(int[][] matrix)
        {
            int length = matrix.Length;
            //因为是对称的，只需要计算循环前半行即可
            for (int i = 0; i < length / 2; i++)
                for (int j = i; j < length - i - 1; j++)
                {
                    int temp = matrix[i][j];
                    int m = length - j - 1;
                    int n = length - i - 1;
                    matrix[i][j] = matrix[m][i];
                    matrix[m][i] = matrix[n][m];
                    matrix[n][m] = matrix[j][n];
                    matrix[j][n] = temp;
                }
        }
    }
}