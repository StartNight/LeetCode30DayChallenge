using System;
using System.Collections.Generic;

namespace _30.LevelOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                二叉树的层序遍历
                给你一个二叉树，请你返回其按 层序遍历 得到的节点值。 （即逐层地，从左到右访问所有节点）。 
                
                示例：
                二叉树：[3,9,20,null,null,15,7],
                
                    3
                   / \
                  9  20
                    /  \
                   15   7
                返回其层序遍历结果：
                
                [
                  [3],
                  [9,20],
                  [15,7]
                ]
                相关标签
                树
                广度优先搜索
                二叉树
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnldjj/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> r = new List<IList<int>>();
            if (root == null)
            {
                return r;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                // 一个队列做临时存储区域,用一个len变量做长度记录,这样每次for循环的时候就会把上次的存储的元素移除;
                List<int> curIndex = new List<int>();
                int len = q.Count;
                for (int i = 0; i < len; i++)
                {
                    TreeNode temp = q.Dequeue();
                    curIndex.Add(temp.val);
                    if (temp.left != null)
                        q.Enqueue(temp.left);
                    if (temp.right != null)
                        q.Enqueue(temp.right);
                }
                r.Add(curIndex);
            }
            return r;
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
