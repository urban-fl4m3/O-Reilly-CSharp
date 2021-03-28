using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Chapter8_Program3
{
    internal class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare([AllowNull] Duck x, [AllowNull] Duck y)
        {
            if (x.Kind < y.Kind)
            {
                return -1;
            }

            if (x.Kind > y.Kind)
            {
                return 1;
            }

            return 0;
        }
    }
}
