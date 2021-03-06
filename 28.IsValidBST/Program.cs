namespace _28.IsValidBST
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                验证二叉搜索树
                给定一个二叉树，判断其是否是一个有效的二叉搜索树。

                假设一个二叉搜索树具有如下特征：

                节点的左子树只包含小于当前节点的数。
                节点的右子树只包含大于当前节点的数。
                所有左子树和右子树自身必须也是二叉搜索树。
                示例 1:

                输入:
                    2
                   / \
                  1   3
                输出: true
                示例 2:

                输入:
                    5
                   / \
                  1   4
                     / \
                    3   6
                输出: false
                解释: 输入为: [5,1,4,null,null,3,6]。
                     根节点的值为 5 ，但是其右子节点值为 4 。

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xn08xg/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。

             */
        }

        public static bool isValidBST(TreeNode root)
        {
            return isValidBST(root, long.MinValue, long.MaxValue);
        }

        // (min,max)
        public static bool isValidBST(TreeNode p, long min, long max)
        {
            if (p == null)
                return true;
            if (p.val <= min || p.val >= max)
                return false;
            return isValidBST(p.left, min, p.val) && isValidBST(p.right, p.val, max);
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
}