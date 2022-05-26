using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Module2
{
    public class RadixSort
    {
        public static string[] CountSort(string[] arstr, int phase, int len)
        {
            ulong e;
            List<string>[] arrayList = new List<string>[10];
            for (int f = 0; f < 10; f++)
            {
                arrayList[f] = new List<string>();
            }

            for (int b = 0; b < arstr.Length; b++)
            {
                int k = int.Parse(arstr[b].Substring(len - phase, 1));
                arrayList[k].Add(arstr[b]);
            }

            for (e = 0; e < 10; e++)
            {
                if (arrayList[e].Count == 0)
                {
                    Console.WriteLine("Bucket " + e + ": empty");
                }
                else
                {
                    Console.WriteLine("Bucket " + e + ": {0}", string.Join(", ", arrayList[e]));
                }
            }

            int l = 0;

            for (e = 0; e < 10; e++)
            {
                for (int f = 0; f < arrayList[e].Count; f++)
                {
                    arstr[l] = arrayList[e][f];
                    l++;
                }
            }

            return arstr;
        }

        public static void Radixsort(string[] arstr, ulong n)
        {
            int numpha = 1;
            int rang = arstr[0].Length;

            Console.WriteLine("Initial array:");
            Console.WriteLine("{0}", string.Join(", ", arstr));

            foreach (var i in Enumerable.Range(0, Convert.ToInt32(Math.Ceiling(Convert.ToDouble(-1 - (rang - 1)) / -1))).Select(x_1 => rang - 1 + (x_1 * -1)))
            {
                Console.WriteLine("**********");
                Console.WriteLine("Phase {0}", numpha);
                arstr = CountSort(arstr, numpha, rang);
                numpha++;
            }

            Console.WriteLine("**********");
            Console.WriteLine("Sorted array:");
            Console.Write("{0}", string.Join(", ", arstr));
        }

        public static void Try()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            string[] arstr = new string[n];
            for (ulong e = 0; e < n; e++)
            {
                arstr[e] = Console.ReadLine();
            }

            Radixsort(arstr, n);
        }
    }
}