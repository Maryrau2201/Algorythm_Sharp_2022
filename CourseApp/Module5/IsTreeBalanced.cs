﻿using System;
using System.Collections.Generic;

namespace CourseApp.Module5
{
    public class IsTreeBalanced
    {
        private Node root;

        public static void IsTreeBalancedMethod()
        {
            string s = Console.ReadLine();

            string[] values = s.Split(' ');

            var tree = new IsTreeBalanced();

            for (int e = 0; e < values.Length - 1; e++)
            {
                tree.Insert(int.Parse(values[e]));
            }

            if (tree.IsBalanced(tree.root))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        public void Insert(int data)
        {
            root = InnerInsert(data, root);
        }

        private Node InnerInsert(int data, Node root)
        {
            if (root == null)
            {
                return new Node(data);
            }

            if (root.Data > data)
            {
                root.Left = InnerInsert(data, root.Left);
            }
            else if (root.Data < data)
            {
                root.Right = InnerInsert(data, root.Right);
            }

            return root;
        }

        private bool IsBalanced(Node node)
        {
            int lh;

            int rh;

            if (node == null)
            {
                return true;
            }

            lh = Height(node.Left);
            rh = Height(node.Right);

            if (Math.Abs(lh - rh) <= 1 && IsBalanced(node.Left)
                && IsBalanced(node.Right))
            {
                return true;
            }

            return false;
        }

        private int Height(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }
    }
}