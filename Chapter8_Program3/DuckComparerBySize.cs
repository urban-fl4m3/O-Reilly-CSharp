using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Chapter8_Program3
{
    class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare([AllowNull] Duck x, [AllowNull] Duck y)
        {
            if (x.Size < y.Size)
            {
                return -1;
            }

            if (x.Size > y.Size)
            {
                return 1;
            }

            return 0;
        }
    }
}
