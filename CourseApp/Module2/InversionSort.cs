using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Module2
{
    public class InversionSort
    {
        private static long inversion = 0;

        public static int[] Merge(int[] a, int[] b)
        {
            int e = 0;
            int p = 0;
            int[] c = new int[a.Length + b.Length];
            for (int s = 0; s < c.Length; s++)
            {
                if (e == a.Length)
                {
                    c[s] = b[p];
                    p++;
                }
                else if (p == b.Length)
                {
                    c[s] = a[e];
                    e++;
                }
                else if (a[e] <= b[p])
                {
                    c[s] = a[e];
                    e++;
                }
                else
                {
                    c[s] = b[p];
                    p++;
                    inversion += a.Length - e;
                }
            }

            return c;
        }

        public static int[] Merge_sort(int[] v, int l, int r)
        {
            if (r - l == 1)
            {
                int[] res = new int[1];
                res[0] = v[l];
                return res;
            }

            int m = (l + r) / 2;

            int[] left = Merge_sort(v, l, m);
            int[] right = Merge_sort(v, m, r);

            int[] sort = Merge(left, right);

            return sort;
        }

        public static void Try()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] arr = new int[n];
            for (int e = 0; e < n; e++)
            {
                arr[e] = int.Parse(sValues[e]);
            }

            int[] v_sorted = Merge_sort(arr, 0, n);

            Console.WriteLine(inversion);
        }
    }
}