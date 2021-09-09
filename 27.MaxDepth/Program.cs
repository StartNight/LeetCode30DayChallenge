﻿using System;

namespace _27.MaxDepth
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                二叉树的最大深度
                给定一个二叉树，找出其最大深度。

                二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。

                说明: 叶子节点是指没有子节点的节点。

                示例：
                给定二叉树 [3,9,20,null,null,15,7]，

                    3
                   / \
                  9  20
                    /  \
                   15   7
                返回它的最大深度 3 。

                相关标签
                树
                深度优先搜索
                广度优先搜索
                二叉树

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnd69e/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
            */
        }

        public static int MaxDepth(TreeNode root)
        {
            return root == null ? 0 : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
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