using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp.Module2
{
    public class BubbleSort
    {
        public static void BubbleSortMethod()
        {
            int b = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] arr = new int[b];
            for (int k = 0; k < b; k++)
            {
                arr[k] = int.Parse(sValues[k]);
            }

            bool swap = false;
            for (int k = 0; k < arr.Length - 1; k++)
            {
                for (int n = 0; n < arr.Length - k - 1; n++)
                {
                    if (arr[n] > arr[n + 1])
                    {
                        swap = true;
                        (arr[n], arr[n + 1]) = (arr[n + 1], arr[n]);
                        string result = string.Join(" ", arr);
                        Console.WriteLine(result);
                    }
                }
            }

            if (swap == false)
            {
                Console.WriteLine(0);
            }
        }
    }
}