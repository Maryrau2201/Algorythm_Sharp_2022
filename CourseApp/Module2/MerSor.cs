using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Module2
{
    public class MerSor
    {
        public static int[] Merge(int[] a, int[] b)
        {
            int ry = 0;
            int ba = 0;
            int[] c = new int[a.Length + b.Length];
            for (int k = 0; k < c.Length; k++)
            {
                if (ry == a.Length)
                {
                    c[k] = b[ba];
                    ba++;
                }
                else if (ba == b.Length)
                {
                    c[k] = a[ry];
                    ry++;
                }
                else if (a[ry] <= b[ba])
                {
                    c[k] = a[ry];
                    ry++;
                }
                else
                {
                    c[k] = b[ba];
                    ba++;
                }
            }

            return c;
        }

        public static int[] Merge_sort(int[] i, int hl, int ru)
        {
            if (ru - hl == 1)
            {
                int[] res = new int[1];
                res[0] = i[hl];
                return res;
            }

            int m = (hl + ru) / 2;

            int[] left = Merge_sort(i, hl, m);
            int[] right = Merge_sort(i, m, ru);

            int[] sort = Merge(left, right);

            Console.WriteLine("{0} {1} {2} {3}", hl + 1, ru, sort[0], sort[^1]);

            return Merge(left, right);
        }

        public static void Try()
        {
            int hl = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] arr = new int[hl];
            for (int ry = 0; ry < hl; ry++)
            {
                arr[ry] = int.Parse(sValues[ry]);
            }

            int[] v_sorted = Merge_sort(arr, 0, hl);

            Console.WriteLine("{0}", string.Join(" ", v_sorted));
        }
    }
}