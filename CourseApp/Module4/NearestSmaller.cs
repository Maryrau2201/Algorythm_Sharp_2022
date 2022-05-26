using System;

public class NearestSmaller
{
    public static void GetNearestSmaller()
    {
        var numberElements = int.Parse(Console.ReadLine());
        var s = Console.ReadLine();
        var sValues = s.Split(' ');
        var arrayElements = new int[numberElements];
        var answerArray = new int[numberElements];
        for (int e = 0; e < numberElements; e++)
        {
            arrayElements[e] = int.Parse(sValues[e]);
        }

        int ind = numberElements - 1;
        while (ind >= 0)
        {
            while (Stack.Empty() == false && arrayElements[Stack.Back()] >= arrayElements[ind])
            {
                Stack.Pop();
            }

            if (Stack.Empty() == true)
            {
                answerArray[ind] = -1;
            }
            else
            {
                answerArray[ind] = Stack.Back();
            }

            Stack.Push(ind);

            ind--;
        }

        for (int e = 0; e < numberElements; e++)
        {
            Console.Write(answerArray[e] + " ");
        }
    }

    private class Stack
    {
        private static int[] buf = new int[100000001];
        private static int tp = -1;

        public static void Push(int a)
        {
            tp++;
            buf[tp] = a;
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
            return buf[tp];
        }
    }
}