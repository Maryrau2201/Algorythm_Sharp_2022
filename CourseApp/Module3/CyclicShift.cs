using System;
using System.Linq;

namespace CourseApp.Module3
{
    public class CyclicShift
    {
        public static int RabKar(string b, string t)
        {
            if (b == t)
            {
                return 0;
            }

            t = string.Concat(Enumerable.Repeat(t, 2));

            long q = 13;
            long m = 1;
            long p = 10000000 - 7;

            long first_hash = 0;
            long second_hash = 0;
            long xt = 1;

            foreach (char e in b.Reverse())
            {
                first_hash = (first_hash + (e * m)) % p;
                m = (m * q) % p;
            }

            m = 1;

            for (int e = b.Length - 1; e >= 0; e--)
            {
                second_hash = (second_hash + (t[e] * m)) % p;
                m = (m * q) % p;
            }

            for (int e = 0; e < b.Length - 1; e++)
            {
                xt = (xt * q) % p;
            }

            for (int e = 1; e < t.Length - b.Length + 1; e++)
            {
                if (first_hash == second_hash)
                {
                    return e - 1;
                }

                second_hash = q * (second_hash - (t[e - 1] * xt));
                second_hash += t[e + b.Length - 1];
                second_hash = second_hash % p;

                if ((second_hash < 0 && p > 0) || (second_hash > 0 && p < 0))
                {
                    second_hash += p;
                }
            }

            return -1;
        }

        public static void EnterValues()
        {
            string b = Console.ReadLine();
            string t = Console.ReadLine();

            int result = RabKar(b, t);

            Console.WriteLine(result);
        }
    }
}