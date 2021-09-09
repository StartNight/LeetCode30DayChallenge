using System.Collections.Generic;
using System.Linq;

namespace _31.SortedArrayToBST
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                将有序数组转换为二叉搜索树
                给你一个整数数组 nums ，其中元素已经按 升序 排列，请你将其转换为一棵 高度平衡 二叉搜索树。

                高度平衡 二叉树是一棵满足「每个节点的左右两个子树的高度差的绝对值不超过 1 」的二叉树。
                 

                示例 1：

                输入：nums = [-10,-3,0,5,9]
                输出：[0,-3,9,-10,null,5]
                解释：[0,-10,5,null,-3,null,9] 也将被视为正确答案：

                示例 2：

                输入：nums = [1,3]
                输出：[3,1]
                解释：[1,3] 和 [3,1] 都是高度平衡二叉搜索树。
                 

                提示：

                1 <= nums.length <= 104
                -104 <= nums[i] <= 104
                nums 按 严格递增 顺序排列
                相关标签
                树
                二叉搜索树
                数组
                分治
                二叉树

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xninbt/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
            */
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0) return null;
            int n = nums.Length;
            IList<int> L = new List<int>();
            IList<int> R = new List<int>();

            TreeNode root = new TreeNode(nums[n / 2]);
            for (int i = 0; i < n / 2; i++)
            {
                L.Add(nums[i]);
            }
            for (int i = (n / 2) + 1; i < n; i++)
            {
                L.Add(nums[i]);
            }

            root.left = SortedArrayToBST(L.ToArray());
            root.right = SortedArrayToBST(R.ToArray());
            return root;
        }

        public TreeNode sortedArrayToBST(int[] nums)
        {
            int n = nums.Length;
            return sortedArrayToBSTHelper(nums, 0, n - 1);
        }

        public TreeNode sortedArrayToBSTHelper(int[] nums, int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            int mid = start + (end - start) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = sortedArrayToBSTHelper(nums, start, mid - 1);
            root.right = sortedArrayToBSTHelper(nums, mid + 1, end);
            return root;
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