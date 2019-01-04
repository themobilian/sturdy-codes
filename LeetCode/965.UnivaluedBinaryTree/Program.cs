/*
A binary tree is univalued if every node in the tree has the same value.
Return true if and only if the given tree is univalued.

Example 1:

Input: [1,1,1,1,1,null,1]
Output: true

Input: [2,2,2,5,2]
Output: false

Note:

The number of nodes in the given tree will be in the range [1, 100].
Each node's value will be an integer in the range [0, 99].
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _965.UnivaluedBinaryTree
{

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }


    class Program
    {
        public static int uniqueItem;
        static void Main(string[] args)
        {
            Program program = new Program();

            TreeNode root = new TreeNode(1);
            Random ran = new Random();

            for(int i = 0; i < 100; i++)
            {
                //program.insert(root,ran.Next(100));
                program.insert(root, 1);
            }
            Console.WriteLine("{0}", program.IsUnivalTree(root));
            Console.ReadLine();
        }

        public bool IsUnivalTree(TreeNode root)
        {
            uniqueItem = root.val;
            return traverse(root);
        }

        public bool traverse(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            if (uniqueItem != root.val)
            {
                return false;
            }
            return traverse(root.left) && traverse(root.right)&& (uniqueItem==root.val);
        }

        public TreeNode insert(TreeNode root, int v)
        {
            if (root == null)
            {
                root = new TreeNode(v);
            }
            else if (v < root.val)
            {
                root.left = insert(root.left, v);
            }
            else
            {
                root.right = insert(root.right, v);
            }

            return root;
        }

    }
}
