using System.Collections.Generic;

namespace CustomComparator
{
    class CustomEvenOddComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 2 == 0 && y % 2 != 0)
            {
                return -1;
            }
            if (x % 2 == 0 && y % 2 == 0)
            {
                return x - y;
            }
            if (x % 2 != 0 && y % 2 != 0)
            {
                return x - y;
            }
            if (x % 2 != 0 && y % 2 == 0)
            {
                return 1;
            }
            
            return 0;
        }
    }
}
