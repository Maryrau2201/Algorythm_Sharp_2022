using System;

namespace CourseApp.Module3
{
    public class CircularString
    {
        public static int[] Prefix_function(string s)
        {
            int[] res = new int[s.Length];
            res[0] = 0;

            for (int e = 0; e < s.Length - 1; e++)
            {
                int b = res[e];

                while (b > 0 && s[e + 1] != s[b])
                {
                    b = res[b - 1];
                }

                if (s[e + 1] == s[b])
                {
                    res[e + 1] = b + 1;
                }
                else
                {
                    res[e + 1] = 0;
                }
            }

            return res;
        }

        public static void EnterValues()
        {
            string s = Console.ReadLine();

            int[] prefixs = Prefix_function(s);

            int result = s.Length - prefixs[s.Length - 1];

            Console.WriteLine(result);
        }
    }
}