using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Module3
{
    public class FindSubstring
    {
        public static long Get_hash(string s, int n, int p, int x)
        {
            long res = 0;
            for (int e = 0; e < n; e++)
            {
                res = ((res * x) + s[e]) % p;
            }

            return res;
        }

        public static void Rabin_karp(string s, string t, int p, int x)
        {
            long ht = Get_hash(t, t.Length, p, x);

            long hs = Get_hash(s, t.Length, p, x);

            long xt = 1;

            for (int i = 0; i < t.Length; i++)
            {
                xt = (xt * x) % p;
            }

            for (int e = 0; e <= s.Length - t.Length; e++)
            {
                if (ht == hs)
                {
                    Console.Write("{0} ", e);
                }

                if (e + t.Length < s.Length)
                {
                    hs = ((hs * x) - (s[e] * xt) + s[e + t.Length]) % p;
                    hs = (hs + p) % p;
                }
            }
        }

        public static void EnterValues()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            int p = 1000000000 + 7;
            int x = 26;

            Rabin_karp(s, t, p, x);
        }
    }
}