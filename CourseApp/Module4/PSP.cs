using System;

namespace CourseApp.Module4
{
    public class PSP
    {
        public static void GetPSP()
        {
            string parentheses = Console.ReadLine();
            int counter = 0;

            for (int e = 0; e < parentheses.Length; e++)
            {
                if (parentheses[e] == '(')
                {
                    Stack.Push(parentheses[e]);
                }
                else if (Stack.Empty() == false && parentheses[e] == ')')
                {
                    Stack.Pop();
                }
                else
                {
                    counter += 1;
                }
            }

            Console.WriteLine(counter + Stack.Size());
        }

        private class Stack
        {
            private static int[] buffer = new int[100000001];
            private static int tp = -1;

            public static void Push(int a)
            {
                tp++;
                buffer[tp] = a;
            }

            public static void Pop()
            {
                tp--;
            }

            public static int Size()
            {
                return tp + 1;
            }

            public static bool Empty()
            {
                return tp == -1;
            }

            public static void Clear()
            {
                tp = -1;
            }

            public static int Back()
            {
                return buffer[tp];
            }
        }
    }
}