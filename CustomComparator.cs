using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparator
{
    class CustomComparator
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            CustomEvenOddComparer compare = new CustomEvenOddComparer();
            Array.Sort(numbers, compare);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
