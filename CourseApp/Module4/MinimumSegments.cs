using System;

public class MinimumSegments
{
    public static void GetMinimumSegments()
    {
        string sFirst = Console.ReadLine();
        string[] sFirstValues = sFirst.Split(' ');
        int[] arrFirst = new int[2];
        for (int e = 0; e < 2; e++)
        {
            arrFirst[e] = int.Parse(sFirstValues[e]);
        }

        string sSecond = Console.ReadLine();
        string[] sSecondValues = sSecond.Split(' ');
        int[] arrSecond = new int[arrFirst[0]];
        for (int e = 0; e < arrFirst[0]; e++)
        {
            arrSecond[e] = int.Parse(sSecondValues[e]);
        }

        for (int e = 0; e < arrFirst[1]; e++)
        {
            while (Deque.Empty() == false && arrSecond[e] < arrSecond[Deque.Front()])
            {
                Deque.Pop_Front();
            }

            Deque.Push_Front(e);
        }

        for (int e = arrFirst[1]; e < arrFirst[0]; e++)
        {
            Console.WriteLine(arrSecond[Deque.Back()]);

            while (Deque.Empty() == false && Deque.Back() <= e - arrFirst[1])
            {
                Deque.Pop_Back();
            }

            while (Deque.Empty() == false && arrSecond[e] < arrSecond[Deque.Front()])
            {
                Deque.Pop_Front();
                if (Deque.Size() == 0)
                {
                    Deque.Clear();
                }
            }

            Deque.Push_Front(e);
        }

        Console.WriteLine(arrSecond[Deque.Back()]);
    }

    private class Deque
    {
        private static int[] buffer = new int[100000001];
        private static int front = 0;
        private static int back = 100000001 - 1;
        private static int size = 0;

        public static void Push_Back(int t)
        {
            back++;
            if (back == 100000001)
            {
                back = 0;
            }

            buffer[back] = t;
            size++;
        }

        public static void Push_Front(int t)
        {
            front--;
            if (front < 0)
            {
                front = 100000001 - 1;
            }

            buffer[front] = t;
            size++;
        }

        public static void Pop_Back()
        {
            back--;
            if (back < 0)
            {
                back = 100000001 - 1;
            }

            size--;
        }

        public static void Pop_Front()
        {
            front++;
            if (front == 100000001)
            {
                front = 0;
            }

            size--;
        }

        public static void Clear()
        {
            front = 0;
            back = 100000001 - 1;
            size = 0;
        }

        public static int Front()
        {
            return buffer[front];
        }

        public static int Back()
        {
            return buffer[back];
        }

        public static int Size()
        {
            return size;
        }

        public static bool Empty()
        {
            return size == 0;
        }
    }
}