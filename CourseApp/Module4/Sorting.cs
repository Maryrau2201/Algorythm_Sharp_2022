using System;

namespace CourseApp.Module4
{
    public class Sorting
    {
        public static void GetSorting()
        {
            var numberWagons = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            var sValues = s.Split(' ');
            var arrayWagons = new int[numberWagons];
            var answerArray = new int[numberWagons];
            for (int e = 0; e < numberWagons; e++)
            {
                arrayWagons[e] = int.Parse(sValues[e]);
            }

            int megaHorosh = 0;
            int ultraGigaHorosh = 0;

            while (megaHorosh != numberWagons)
            {
                if (Stack.Empty() == true || (ultraGigaHorosh < numberWagons && arrayWagons[ultraGigaHorosh] < Stack.Back()))
                {
                    Stack.Push(arrayWagons[ultraGigaHorosh]);
                    ultraGigaHorosh++;
                }
                else
                {
                    answerArray[megaHorosh] += Stack.Back();
                    Stack.Pop();
                    megaHorosh++;
                }
            }

            bool isAnswer = true;

            for (int e = 0; e < answerArray.Length - 1; e++)
            {
                if (answerArray[e] > answerArray[e + 1])
                {
                    isAnswer = false;
                }
            }

            if (isAnswer == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
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
}