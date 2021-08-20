using System;

namespace _29.IsSymmetric
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                对称二叉树
                给定一个二叉树，检查它是否是镜像对称的。
                 
                
                例如，二叉树 [1,2,2,3,4,4,3] 是对称的。
                
                    1
                   / \
                  2   2
                 / \ / \
                3  4 4  3
                 
                
                但是下面这个 [1,2,2,null,3,null,3] 则不是镜像对称的:
                
                    1
                   / \
                  2   2
                   \   \
                   3    3
                 
                
                进阶：
                
                你可以运用递归和迭代两种方法解决这个问题吗？
                
                相关标签
                树
                深度优先搜索
                广度优先搜索
                二叉树
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xn7ihv/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return isSymmetric(root.left, root.right);
        }

        public static bool isSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            if (left == null || right == null || left.val != right.val)
            {
                return false;
            }
            return isSymmetric(left.left, right.right) && isSymmetric(left.right, right.left);
        }

    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
