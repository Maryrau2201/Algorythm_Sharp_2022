using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Module2
{
    public class NumbDiff
    {
        private static long count = 1;

        public static int Partition(int[] ar, int l, int r)
        {
            int d = ar[l];
            int e = l - 1, b = r + 1;

            while (true)
            {
                do
                {
                    e++;
                }
                while (ar[e] < d);

                do
                {
                    b--;
                }
                while (ar[b] > d);

                if (e >= b)
                {
                    return b;
                }

                int temp = ar[e];
                ar[e] = ar[b];
                ar[b] = temp;
            }
        }

        public static void QuickSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int q = Partition(arr, l, r);

                QuickSort(arr, l, q);
                QuickSort(arr, q + 1, r);
            }
        }

        public static void Try()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] ar = new int[n];
            for (int e = 0; e < n; e++)
            {
                ar[e] = int.Parse(sValues[e]);
            }

            QuickSort(ar, 0, n - 1);

            for (int e = 1; e < n; e++)
            {
                if (ar[e - 1] != ar[e])
                {
                    count += 1;
                }
            }

            Console.WriteLine("{0}", count);
        }
    }
}