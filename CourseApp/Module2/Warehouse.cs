using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Module2
{
    public class Warehouse
    {
        public static void Count_sort(int[] order_arr, int[] products_arr, int k)
        {
            int[] c = new int[k + 1];
            for (int e = 0; e < order_arr.Length; e++)
            {
                c[order_arr[e]]++;
            }

            int pos = 0;
            int kek = 0;
            int[] order = new int[k];
            string[] answer = new string[k];
            for (int e = 0; e < c.Length; e++)
            {
                if (c[e] != 0)
                {
                    order[pos++] = c[e];
                    if (products_arr[kek] >= order[kek])
                    {
                        Console.WriteLine("no");
                    }
                    else
                    {
                        Console.WriteLine("yes");
                    }

                    kek++;
                }
            }
        }

        public static void Try()
        {
            int products = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] products_arr = new int[products];
            for (int e = 0; e < products; e++)
            {
                products_arr[e] = int.Parse(sValues[e]);
            }

            int n = int.Parse(Console.ReadLine());
            s = Console.ReadLine();
            sValues = s.Split(' ');
            int[] order_arr = new int[n];
            for (int e = 0; e < n; e++)
            {
                order_arr[e] = int.Parse(sValues[e]);
            }

            Count_sort(order_arr, products_arr, products);
        }
    }
}