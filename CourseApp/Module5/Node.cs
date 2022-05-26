﻿namespace CourseApp.Module5
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public int Data { get; set; }
    }
}