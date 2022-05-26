using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp.Module2
{
    public class BubSorPar
    {
        public static void BubbleSortMethod()
        {
            int h = int.Parse(Console.ReadLine());
            int[] number = new int[h];
            int[] price = new int[h];
            for (int ry = 0; ry < h; ry++)
            {
                string s = Console.ReadLine();
                string[] sValues = s.Split(' ');
                number[ry] = int.Parse(sValues[0]);
                price[ry] = int.Parse(sValues[1]);
            }

            for (int ry = 0; ry < price.Length - 1; ry++)
            {
                for (int ba = 0; ba < price.Length - ry - 1; ba++)
                {
                    if (price[ba] < price[ba + 1])
                    {
                        (price[ba], price[ba + 1]) = (price[ba + 1], price[ba]);
                        (number[ba], number[ba + 1]) = (number[ba + 1], number[ba]);
                    }
                    else if (price[ba] == price[ba + 1])
                    {
                        if (number[ba] > number[ba + 1])
                        {
                            (number[ba], number[ba + 1]) = (number[ba + 1], number[ba]);
                            (price[ba], price[ba + 1]) = (price[ba + 1], price[ba]);
                        }
                    }
                }
            }

            for (int ry = 0; ry < h; ry++)
            {
                Console.WriteLine("{0} {1}", number[ry], price[ry]);
            }
        }
    }
}